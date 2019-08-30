using Microsoft.VisualStudio.Text;
using Microsoft.VisualStudio.Text.Classification;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Color.Directive
{
	public class RegionType
	{
		public readonly IClassificationType Name;
		public readonly IClassificationType Desc;

		public RegionType
		(
			IClassificationType Name,
			IClassificationType Desc
		){
			this.Name = Name;
			this.Desc = Desc;
		}
	}

	internal class Classifier
	:
		IClassifier
	{
		private          bool        IsClassificationRunning;
		private readonly IClassifier IClassifier;

		#pragma warning disable 67
		public event EventHandler<ClassificationChangedEventArgs> ClassificationChanged;
		#pragma warning restore 67

		private readonly IClassificationType Directive;
		private readonly IClassificationType Directive_Hash;
		private readonly IClassificationType Directive_Name;
		private readonly IClassificationType Directive_Desc;
		private readonly IClassificationType Directive_Pragma;
		private readonly IClassificationType Directive_Pragma_Desc;
		private readonly IClassificationType Directive_Pragma_Region;
		private readonly IClassificationType Directive_Pragma_Region_Desc;
		private readonly IClassificationType Directive_Pragma_EndRegion;
		private readonly IClassificationType Directive_Pragma_public;
		private readonly IClassificationType Directive_Pragma_protected;
		private readonly IClassificationType Directive_Pragma_private;

		private readonly Dictionary<string, RegionType>          RegionTypes  = new Dictionary<string, RegionType>();
		private readonly Dictionary<string, IClassificationType> RegionGroups = new Dictionary<string, IClassificationType>();

		internal Classifier
		(
			IClassificationTypeRegistryService Registry,
			IClassifier                        Classifier
		)
		{
			IsClassificationRunning      = false;
			IClassifier                  = Classifier;

			Directive                    = Registry.GetClassificationType("Directive");
			Directive_Hash               = Registry.GetClassificationType("Directive.Hash");
			Directive_Name               = Registry.GetClassificationType("Directive.Name");
			Directive_Desc               = Registry.GetClassificationType("Directive.Desc");
			Directive_Pragma             = Registry.GetClassificationType("Directive.Pragma");
			Directive_Pragma_Desc        = Registry.GetClassificationType("Directive.Pragma.Desc");
			Directive_Pragma_Region      = Registry.GetClassificationType("Directive.Pragma.Region");
			Directive_Pragma_Region_Desc = Registry.GetClassificationType("Directive.Pragma.Region.Desc");
			Directive_Pragma_EndRegion   = Registry.GetClassificationType("Directive.Pragma.EndRegion");
			Directive_Pragma_public      = Registry.GetClassificationType("Directive.Pragma.Region.public");
			Directive_Pragma_protected   = Registry.GetClassificationType("Directive.Pragma.Region.protected");
			Directive_Pragma_private     = Registry.GetClassificationType("Directive.Pragma.Region.private");

			foreach (var Type in Meta.RegionTypes)
			{
				RegionTypes.Add(Type, new RegionType
				(
					Registry.GetClassificationType("Directive.Pragma.Region." + Type + ".Name"),
					Registry.GetClassificationType("Directive.Pragma.Region." + Type + ".Desc")
				));
			}

			foreach (var Group in Meta.RegionGroups)
				RegionGroups.Add(Group, Registry.GetClassificationType("Directive.Pragma.Region." + Group));
		}

		public IList<ClassificationSpan> GetClassificationSpans(SnapshotSpan Span)
		{
			if (IsClassificationRunning) return new List<ClassificationSpan>();

			try
			{
				IsClassificationRunning = true;
				return Classify(Span);
			}
			finally
			{
				IsClassificationRunning = false;
			}
		}

		private IList<ClassificationSpan> Classify(SnapshotSpan Span)
		{
			IList<ClassificationSpan> Spans = new List<ClassificationSpan>();

			if (Span.IsEmpty) return Spans;
			var Text = Span.GetText();

			foreach (Match Match in new Regex(@"(?<Hash>#)(?<Name>[^ \t\v\f]*)[ \t\v\f]*(?<Desc>.*)").Matches(Text))
			{
				var MatchedSpan   = new SnapshotSpan(Span.Snapshot, new Span(Span.Start + Match.Groups["Hash"].Index, Match.Groups["Hash"].Length));
				var Intersections = IClassifier.GetClassificationSpans(MatchedSpan);

				foreach (var Intersection in Intersections)
				{
					var Classifications = Intersection.ClassificationType.Classification.Split(new[]{" - "}, StringSplitOptions.None);

					// Comment must be classified as "cppLocalVariable".
					if (!Utils.IsClassifiedAs(Classifications, new[]{"preprocessor keyword"})) goto SkipVariable;

					// Prevent matching attributes.
					if (Utils.IsClassifiedAs(Classifications, new[]{"Attribute"})) goto SkipVariable;

					Spans.Add(new ClassificationSpan(new SnapshotSpan(Span.Snapshot, new Span(Span.Start + Match.Index, Match.Length)), Directive));

					Spans.Add(new ClassificationSpan(new SnapshotSpan
					(
						Span.Snapshot, new Span
						(
							Span.Start + Match.Groups["Hash"].Index,
							Match.Groups["Hash"].Length
						)), Directive_Hash
					));

					if (Match.Groups["Name"].Length > 0)
					Spans.Add(new ClassificationSpan(new SnapshotSpan
					(
						Span.Snapshot, new Span
						(
							Span.Start + Match.Groups["Name"].Index,
							Match.Groups["Name"].Length
						)), Directive_Name
					));

					if (Match.Groups["Desc"].Length > 0)
					Spans.Add(new ClassificationSpan(new SnapshotSpan
					(
						Span.Snapshot, new Span
						(
							Span.Start + Match.Groups["Desc"].Index,
							Match.Groups["Desc"].Length
						)), Directive_Desc
					));

					if(
							Match.Groups["Name"].Length > 0
						&&	Match.Groups["Name"].Value == "pragma"
					)
					{
						Spans.Add(new ClassificationSpan(new SnapshotSpan
						(
							Span.Snapshot, new Span
							(
								Span.Start + Match.Groups["Name"].Index,
								Match.Groups["Name"].Length
							)), Directive_Pragma
						));

						if (Match.Groups["Desc"].Length > 0)
						{
							Spans.Add(new ClassificationSpan(new SnapshotSpan
							(
								Span.Snapshot, new Span
								(
									Span.Start + Match.Groups["Desc"].Index,
									Match.Groups["Desc"].Length
								)), Directive_Pragma_Desc
							));

							var RegionMatch = Regex.Match
							(
								Match.Groups["Desc"].Value,
								"^(?<Region>region)[ \t\v\f]*(?<Desc>.*)"
							);

							if (RegionMatch.Groups["Region"].Length > 0)
							{
								Spans.Add(new ClassificationSpan(new SnapshotSpan
								(
									Span.Snapshot, new Span
									(
											Span.Start
										+	Match.Groups["Desc"].Index
										+	RegionMatch.Groups["Region"].Index,

										RegionMatch.Groups["Region"].Length
									)), Directive_Pragma_Region
								));

								if (RegionMatch.Groups["Desc"].Length > 0)
								Spans.Add(new ClassificationSpan(new SnapshotSpan
								(
									Span.Snapshot, new Span
									(
											Span.Start
										+	Match.Groups["Desc"].Index
										+	RegionMatch.Groups["Desc"].Index,

										RegionMatch.Groups["Desc"].Length
									)), Directive_Pragma_Region_Desc
								));
							}

							if (RegionMatch.Groups["Desc"].Length > 0)
							{
								var Body = RegionMatch.Groups["Desc"].Value;
								foreach (var Type in Meta.RegionTypes)
								{
									var TypeRegex = Type;
									if (TypeRegex == "enum")
									{
										TypeRegex = "enum([ \t\v\f]+(class|struct))?";
									}

									var BodyMatch = Regex.Match
									(
										Body,
										"^(?<Type>" + TypeRegex + ")[ \t\v\f]*(?<Desc>.*)"
									);

									if (BodyMatch.Success)
									{
										Spans.Add(new ClassificationSpan(new SnapshotSpan
										(
											Span.Snapshot, new Span
											(
													Span.Start
												+	Match.Groups["Desc"].Index
												+	RegionMatch.Groups["Desc"].Index
												+	BodyMatch.Groups["Type"].Index,

												BodyMatch.Groups["Type"].Length
											)), RegionTypes[Type].Name
										));

										if (BodyMatch.Groups["Desc"].Length > 0)
										Spans.Add(new ClassificationSpan(new SnapshotSpan
										(
											Span.Snapshot, new Span
											(
													Span.Start
												+	Match.Groups["Desc"].Index
												+	RegionMatch.Groups["Desc"].Index
												+	BodyMatch.Groups["Desc"].Index,

												BodyMatch.Groups["Desc"].Length
											)), RegionTypes[Type].Desc
										));
									}
								}

								var publicMatch = Regex.Match
								(
									Body,
									"^(?<Access>public):?($|[ \t\v\f])",

										RegexOptions.IgnoreCase
									|	RegexOptions.Compiled
								);

								if (publicMatch.Success)
								{
									Spans.Add(new ClassificationSpan(new SnapshotSpan
									(
										Span.Snapshot, new Span
										(
												Span.Start
											+	Match.Groups["Desc"].Index
											+	RegionMatch.Groups["Desc"].Index
											+	publicMatch.Groups["Access"].Index,

											publicMatch.Groups["Access"].Length
										)), Directive_Pragma_public
									));
								}

								var protectedMatch = Regex.Match
								(
									Body,
									"^(?<Access>protected):?($|[ \t\v\f])",

										RegexOptions.IgnoreCase
									|	RegexOptions.Compiled
								);

								if (protectedMatch.Success)
								{
									Spans.Add(new ClassificationSpan(new SnapshotSpan
									(
										Span.Snapshot, new Span
										(
												Span.Start
											+	Match.Groups["Desc"].Index
											+	RegionMatch.Groups["Desc"].Index
											+	protectedMatch.Groups["Access"].Index,

											protectedMatch.Groups["Access"].Length
										)), Directive_Pragma_protected
									));
								}

								var privateMatch = Regex.Match
								(
									Body,
									"^(?<Access>private):?($|[ \t\v\f])",

										RegexOptions.IgnoreCase
									|	RegexOptions.Compiled
								);

								if (privateMatch.Success)
								{
									Spans.Add(new ClassificationSpan(new SnapshotSpan
									(
										Span.Snapshot, new Span
										(
												Span.Start
											+	Match.Groups["Desc"].Index
											+	RegionMatch.Groups["Desc"].Index
											+	privateMatch.Groups["Access"].Index,

											privateMatch.Groups["Access"].Length
										)), Directive_Pragma_private
									));
								}

								foreach (var Group in Meta.RegionGroups)
								{
									var GroupRegex = Group;
									if (GroupRegex == "Enums")
									{
										GroupRegex = "(Enums|Enum ([Cc]lasses|[Ss]tructs))";
									}

									var GroupMatch = Regex.Match
									(
										Body,
										"(?<!\\w)(?<Group>" + GroupRegex + ")(?!\\w)",

											RegexOptions.IgnoreCase
										|	RegexOptions.Compiled
									);

									if (GroupMatch.Success)
									{
										Spans.Add(new ClassificationSpan(new SnapshotSpan
										(
											Span.Snapshot, new Span
											(
													Span.Start
												+	Match.Groups["Desc"].Index
												+	RegionMatch.Groups["Desc"].Index
												+	GroupMatch.Groups["Group"].Index,

												GroupMatch.Groups["Group"].Length
											)), RegionGroups[Group]
										));
									}
								}
							}
						}

						if(
								Match.Groups["Desc"].Length > 0
							&&	Match.Groups["Desc"].Value.StartsWith("endregion")
						){
							Spans.Add(new ClassificationSpan(new SnapshotSpan
							(
								Span.Snapshot, new Span
								(
									Span.Start + Match.Groups["Desc"].Index,
									Match.Groups["Desc"].Length
								)), Directive_Pragma_EndRegion
							));
						}
					}
				}

				SkipVariable:;
			}

			return Spans;
		}
	}
}
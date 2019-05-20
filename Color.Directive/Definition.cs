using System.ComponentModel.Composition;

using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Utilities;

namespace Color.Directive
{
	internal static class Definitions
	{
		// > The field is never used
		// Reason The field is used by MEF.
		#pragma warning disable 169
		#pragma warning disable IDE0051

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Directive")]
		private static readonly ClassificationTypeDefinition
		Definition_Directive;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Directive.Hash")]
		private static readonly ClassificationTypeDefinition
		Definition_Directive_Hash;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Directive.Name")]
		private static readonly ClassificationTypeDefinition
		Definition_Directive_Name;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Directive.Desc")]
		private static readonly ClassificationTypeDefinition
		Definition_Directive_Desc;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Directive.Pragma")]
		private static readonly ClassificationTypeDefinition
		Definition_Directive_Pragma;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Directive.Pragma.Desc")]
		private static readonly ClassificationTypeDefinition
		Definition_Directive_Pragma_Desc;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Directive.Pragma.Region")]
		private static readonly ClassificationTypeDefinition
		Definition_Directive_Pragma_Region;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Directive.Pragma.Region.Desc")]
		private static readonly ClassificationTypeDefinition
		Definition_Directive_Pragma_Region_Desc;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Directive.Pragma.Region.namespace.Name")]
		private static readonly ClassificationTypeDefinition
		Definition_Directive_Pragma_Region_namespace_Name;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Directive.Pragma.Region.namespace.Desc")]
		private static readonly ClassificationTypeDefinition
		Definition_Directive_Pragma_Region_namespace_Desc;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Directive.Pragma.Region.class.Name")]
		private static readonly ClassificationTypeDefinition
		Definition_Directive_Pragma_Region_class_Name;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Directive.Pragma.Region.class.Desc")]
		private static readonly ClassificationTypeDefinition
		Definition_Directive_Pragma_Region_class_Desc;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Directive.Pragma.Region.struct.Name")]
		private static readonly ClassificationTypeDefinition
		Definition_Directive_Pragma_Region_struct_Name;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Directive.Pragma.Region.struct.Desc")]
		private static readonly ClassificationTypeDefinition
		Definition_Directive_Pragma_Region_struct_Desc;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Directive.Pragma.Region.union.Name")]
		private static readonly ClassificationTypeDefinition
		Definition_Directive_Pragma_Region_union_Name;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Directive.Pragma.Region.union.Desc")]
		private static readonly ClassificationTypeDefinition
		Definition_Directive_Pragma_Region_union_Desc;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Directive.Pragma.Region.concept.Name")]
		private static readonly ClassificationTypeDefinition
		Definition_Directive_Pragma_Region_concept_Name;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Directive.Pragma.Region.concept.Desc")]
		private static readonly ClassificationTypeDefinition
		Definition_Directive_Pragma_Region_concept_Desc;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Directive.Pragma.Region.macro.Name")]
		private static readonly ClassificationTypeDefinition
		Definition_Directive_Pragma_Region_macro_Name;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Directive.Pragma.Region.macro.Desc")]
		private static readonly ClassificationTypeDefinition
		Definition_Directive_Pragma_Region_macro_Desc;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Directive.Pragma.EndRegion")]
		private static readonly ClassificationTypeDefinition
		Definition_Directive_Pragma_EndRegion;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Directive.Pragma.Region.public")]
		private static readonly ClassificationTypeDefinition
		Definition_Directive_Pragma_Region_public;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Directive.Pragma.Region.protected")]
		private static readonly ClassificationTypeDefinition
		Definition_Directive_Pragma_Region_protected;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Directive.Pragma.Region.private")]
		private static readonly ClassificationTypeDefinition
		Definition_Directive_Pragma_Region_private;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Directive.Pragma.Region.Usings")]
		private static readonly ClassificationTypeDefinition
		Definition_Directive_Pragma_Region_Usings;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Directive.Pragma.Region.Friends")]
		private static readonly ClassificationTypeDefinition
		Definition_Directive_Pragma_Region_Friends;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Directive.Pragma.Region.Members")]
		private static readonly ClassificationTypeDefinition
		Definition_Directive_Pragma_Region_Members;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Directive.Pragma.Region.Fields")]
		private static readonly ClassificationTypeDefinition
		Definition_Directive_Pragma_Region_Fields;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Directive.Pragma.Region.Specials")]
		private static readonly ClassificationTypeDefinition
		Definition_Directive_Pragma_Region_Specials;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Directive.Pragma.Region.Constructors")]
		private static readonly ClassificationTypeDefinition
		Definition_Directive_Pragma_Region_Constructors;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Directive.Pragma.Region.Operators")]
		private static readonly ClassificationTypeDefinition
		Definition_Directive_Pragma_Region_Operators;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Directive.Pragma.Region.Conversions")]
		private static readonly ClassificationTypeDefinition
		Definition_Directive_Pragma_Region_Conversions;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Directive.Pragma.Region.Methods")]
		private static readonly ClassificationTypeDefinition
		Definition_Directive_Pragma_Region_Methods;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Directive.Pragma.Region.Functions")]
		private static readonly ClassificationTypeDefinition
		Definition_Directive_Pragma_Region_Functions;

		#pragma warning restore IDE0051
		#pragma warning restore 169
	}
}
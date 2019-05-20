using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Media;

using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;

namespace Color.Directive
{
	using Color = System.Windows.Media.Color;

	internal static class Utils
	{
		// Characters of @Identifier that can be on every place (even on first character).
		internal static readonly string IdentifierCommonCharacters

			= @"(["

				// ASCII
				+ @"_a-zA-Z"

				// MSVC specific
				+ @"\$"

				// 16 bit
				+ @"\u00A8\u00AA\u00AD\u00AF"
				+ @"\u00B2-\u00B5\u00B7-\u00BA\u00BC-\u00BE\u00C0-\u00D6\u00D8-\u00F6\u00F8-\u00FF"
				+ @"\u0100-\u02FF\u0370-\u167F\u1681-\u180D\u180F-\u1DBF\u1E00-\u1FFF\u200B-\u200D"
				+ @"\u202A-\u202E\u203F-\u2040" + @"\u2054"
				+ @"\u2060-\u206F\u2070-\u20CF\u2100-\u218F\u2460-\u24FF\u2776-\u2793\u2C00-\u2DFF"
				+ @"\u2E80-\u2FFF\u3004-\u3007\u3021-\u302F\u3031-\u303F\u3040-\uD7FF\uF900-\uFD3D"
				+ @"\uFD40-\uFDCF\uFDF0-\uFE1F\uFE30-\uFE44\uFE47-\uFFFD"

			+ @"])"
		;

		// Simplified C++ identifier pattern (MSVC specific — includes `$`).
		internal static readonly string Identifier

			= @"("

				// Identifier cannot begin with underscore immnediatelly followed by upper letter.
				+ @"(?!_\p{Lu})"

				// Identifier cannot contain sequence of two underscores.
				+ @"(?!.*__)"

			+ @"("

				// First character (exactly one)
				+ IdentifierCommonCharacters

				// Next characters (any number)
				+ @"("

					+ IdentifierCommonCharacters
					+ @"|["

					// Not allowed as first character
					+ @"0-9" + @"\u0300-\u036F\u1DC0-\u1DFF\u20D0-\u20FF\uFE20-\uFE2F"

				+ @"])*"

			+ @"))"
		;

		// Convert `Win32Color` to `System.Windows.Media.Color`.
		private static Color GetColor(uint Win32Color)
		{
			if (Win32Color == 1) return Colors.Transparent;

			var Match = Regex.Match(
				Win32Color.ToString("x6"),
				@"(?<Blue>.{2})(?<Green>.{2})(?<Red>.{2})"
			);

			var Red   = byte.Parse(Match.Groups["Red"]  .Value, NumberStyles.HexNumber);
			var Green = byte.Parse(Match.Groups["Green"].Value, NumberStyles.HexNumber);
			var Blue  = byte.Parse(Match.Groups["Blue"] .Value, NumberStyles.HexNumber);

			return Color.FromRgb(Red, Green, Blue);
		}

		// Short  Get Color set in `Tools` → `Options` → `Fonts and Colors` → `Text Editor`.
		// Spare  `Colors.Gray`.
		internal static Color GetColorFromEditorOptions(string Name)
		{
			ThreadHelper.ThrowIfNotOnUIThread();

			if(!(Microsoft.VisualStudio.Shell.Package.GetGlobalService(
				typeof(SVsFontAndColorStorage)
			) is IVsFontAndColorStorage Storage)){
				return Colors.Gray;
			}

			Guid GuID = new Guid(FontsAndColorsCategory.TextEditor);
			var Category = Storage.OpenCategory(ref GuID, (uint)(
					__FCSTORAGEFLAGS.FCSF_READONLY
				|	__FCSTORAGEFLAGS.FCSF_LOADDEFAULTS
				|	__FCSTORAGEFLAGS.FCSF_NOAUTOCOLORS
			));

			if(Category != Microsoft.VisualStudio.VSConstants.S_OK) return Colors.Gray;

			var Info = new ColorableItemInfo[1];
			Storage.GetItem(Name, Info);

			Color Color = GetColor(Info[0].crForeground);

			return Color;
		}

		internal static void GetDTE()
		{
			ThreadHelper.ThrowIfNotOnUIThread();
			EnvDTE.DTE DTE = (EnvDTE.DTE) Package.GetGlobalService(typeof(EnvDTE.DTE));
		}

		// Check if $Source classifications contains any classification from $Search.
		internal static bool IsClassifiedAs(string[] Source, string[] Search){
			if (Source.Length == 0) return false;
			if (Search.Length == 0) return false;

			foreach (string SourceClassification in Source){
				foreach (string SearchClassification in Search){
					string SourceEntry = SourceClassification.ToLower();
					string SearchEntry = SearchClassification.ToLower();

					if(
							SourceEntry == SearchEntry
						||	SourceEntry.StartsWith(SearchEntry + ".")
					){
						return true;
					}
				}
			}

			return false;
		}

		// Check if $Source classifications contains $Search classification.
		internal static bool IsClassifiedAs(string[] Source, string Search){
			if (Source.Length == 0) return false;
			if (Search.Length == 0) return false;

			return IsClassifiedAs(Source, new string[]{Search});
		}
	}
}
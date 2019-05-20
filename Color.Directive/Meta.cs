using System;
using System.ComponentModel.Composition;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Animation;
using Microsoft.VisualStudio.Language.StandardClassification;
using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Utilities;
using System.Windows.Controls;

namespace Color.Directive
{
	internal static class Meta
	{
		internal static readonly string[] RegionTypes =
		{
			"namespace",
			"class",
			"struct",
			"union",
			"concept",
		};

		internal static readonly string[] RegionGroups =
		{
			"Usings",
			"Friends",
			"Members",
			"Fields",
			"Specials",
			"Constructors",
			"Operators",
			"Conversions",
			"Methods",
			"Functions",
		};
	}
}
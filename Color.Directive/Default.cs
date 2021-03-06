﻿namespace Color.Directive
{
	using Color = System.Windows.Media.Color;

	internal static class Default
	{
		internal static class Colors
		{
			private  static readonly Color GrayVeryDark   = Color.FromRgb( 64,  64,  64);
			private  static readonly Color GrayDark       = Color.FromRgb( 80,  80,  80);
			private  static readonly Color Gray           = Color.FromRgb(128, 128, 128);
			private  static readonly Color White          = Color.FromRgb(224, 224, 224);
			private  static readonly Color WhiteDark      = Color.FromRgb(176, 176, 176);
			private  static readonly Color Yellow         = Color.FromRgb(224, 224, 128);
			private  static readonly Color DarkYellow     = Color.FromRgb(152, 152,  96);
			private  static readonly Color Red            = Color.FromRgb(224, 128, 128);
			private  static readonly Color Orange         = Color.FromRgb(224, 176, 128);
			private  static readonly Color Pink           = Color.FromRgb(224, 128, 224);
			private  static readonly Color Green          = Color.FromRgb(176, 224, 128);
			private  static readonly Color Blue           = Color.FromRgb(128, 176, 224);
			private  static readonly Color Turquoise      = Color.FromRgb(128, 224, 176);
			private  static readonly Color Purple         = Color.FromRgb(176, 128, 224);

			internal static readonly Color Directive      = GrayDark;
			internal static readonly Color DirectivePunct = GrayVeryDark;
			internal static readonly Color DirectiveDesc  = Gray;
			internal static readonly Color Region         = WhiteDark;
			internal static readonly Color Type           = Green;
			internal static readonly Color Keyword        = Blue;
			internal static readonly Color Namespace      = Gray;
			internal static readonly Color Member         = Yellow;
			internal static readonly Color Static         = Red;
			internal static readonly Color Macro          = Purple;
			internal static readonly Color Header         = White;
			internal static readonly Color Meta           = White;
			internal static readonly Color Using          = Gray;
			internal static readonly Color Import         = Turquoise;
			internal static readonly Color Export         = Pink;
			internal static readonly Color Inherit        = DarkYellow;
			internal static readonly Color Object         = Orange;
			internal static readonly Color Enum           = Red;

			internal static readonly Color Public         = Color.FromRgb(128, 176,  96);
			internal static readonly Color Protected      = Color.FromRgb(152, 152,  96);
			internal static readonly Color Private        = Color.FromRgb(176, 128,  96);
		}
	}
}
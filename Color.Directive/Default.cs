namespace Color.Directive
{
	using Color = System.Windows.Media.Color;

	internal static class Default
	{
		internal static class Colors
		{
			private  static readonly Color GrayVeryDark   = Color.FromRgb( 64,  64,  64);
			private  static readonly Color GrayDark       = Color.FromRgb( 80,  80,  80);
			private  static readonly Color Gray           = Color.FromRgb(128, 128, 128);
			private  static readonly Color WhiteDark      = Color.FromRgb(176, 176, 176);
			private  static readonly Color Yellow         = Color.FromRgb(224, 224, 128);
			private  static readonly Color Red            = Color.FromRgb(224, 128, 128);
			private  static readonly Color Green          = Color.FromRgb(176, 224, 128);
			private  static readonly Color GreenDark      = Color.FromRgb(128, 176,  96);
			private  static readonly Color Blue           = Color.FromRgb(128, 176, 224);
			private  static readonly Color Purple         = Color.FromRgb(176, 128, 224);

			internal static readonly Color Directive      = GrayDark;
			internal static readonly Color DirectivePunct = GrayVeryDark;
			internal static readonly Color DirectiveDesc  = Gray;
			internal static readonly Color Region         = WhiteDark;
			internal static readonly Color Type           = Green;
			internal static readonly Color Keyword        = Blue;
			internal static readonly Color Namespace      = Gray;
			internal static readonly Color Access         = GreenDark;
			internal static readonly Color Member         = Yellow;
			internal static readonly Color Static         = Red;
			internal static readonly Color Macro          = Purple;
		}
	}
}
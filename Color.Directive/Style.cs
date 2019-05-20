using System.ComponentModel.Composition;
using Microsoft.VisualStudio.Language.StandardClassification;
using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Utilities;

namespace Color.Directive
{
	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Directive")]
	[Name("Directive")]
	[BaseDefinition(PredefinedClassificationTypeNames.Identifier)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Identifier)]
	[Order(After = "cppLocalVariable")]
	[Order(After = Priority.High)]
	internal sealed class Format_Directive
		: ClassificationFormatDefinition
	{
		public Format_Directive(){
			DisplayName = "C++ Directive";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Directive;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Directive.Hash")]
	[Name("Directive.Hash")]
	[BaseDefinition(PredefinedClassificationTypeNames.Identifier)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Identifier)]
	[Order(After = "cppLocalVariable")]
	[Order(After = Priority.High)]
	[Order(After = "Directive")]
	internal sealed class Format_Directive_Hash
		: ClassificationFormatDefinition
	{
		public Format_Directive_Hash(){
			DisplayName = "C++ Directive: \"#\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.DirectivePunct;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Directive.Name")]
	[Name("Directive.Name")]
	[BaseDefinition(PredefinedClassificationTypeNames.Identifier)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Identifier)]
	[Order(After = "cppLocalVariable")]
	[Order(After = Priority.High)]
	[Order(After = "Directive")]
	internal sealed class Format_Directive_Name
		: ClassificationFormatDefinition
	{
		public Format_Directive_Name(){
			DisplayName = "C++ Directive: Name";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Directive;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Directive.Desc")]
	[Name("Directive.Desc")]
	[BaseDefinition(PredefinedClassificationTypeNames.Identifier)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Identifier)]
	[Order(After = "cppLocalVariable")]
	[Order(After = Priority.High)]
	[Order(After = "Directive")]
	internal sealed class Format_Directive_Desc
		: ClassificationFormatDefinition
	{
		public Format_Directive_Desc(){
			DisplayName = "C++ Directive: Description";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.DirectiveDesc;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Directive.Pragma")]
	[Name("Directive.Pragma")]
	[BaseDefinition(PredefinedClassificationTypeNames.Identifier)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Identifier)]
	[Order(After = "cppLocalVariable")]
	[Order(After = Priority.High)]
	[Order(After = "Directive")]
	[Order(After = "Directive.Name")]
	internal sealed class Format_Directive_Pragma
		: ClassificationFormatDefinition
	{
		public Format_Directive_Pragma(){
			DisplayName = "C++ Directive: \"pragma\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Directive;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Directive.Pragma.Desc")]
	[Name("Directive.Pragma.Desc")]
	[BaseDefinition(PredefinedClassificationTypeNames.Identifier)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Identifier)]
	[Order(After = "cppLocalVariable")]
	[Order(After = Priority.High)]
	[Order(After = "Directive")]
	[Order(After = "Directive.Desc")]
	internal sealed class Format_Directive_Pragma_Desc
		: ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Desc(){
			DisplayName = "C++ Directive: \"pragma\": ​Description";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.DirectiveDesc;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Directive.Pragma.Region")]
	[Name("Directive.Pragma.Region")]
	[BaseDefinition(PredefinedClassificationTypeNames.Identifier)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Identifier)]
	[Order(After = "cppLocalVariable")]
	[Order(After = Priority.High)]
	[Order(After = "Directive")]
	[Order(After = "Directive.Desc")]
	internal sealed class Format_Directive_Pragma_Region
		: ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region(){
			DisplayName = "C++ Directive: \"pragma\": \"region\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.DirectiveDesc;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Directive.Pragma.Region.Desc")]
	[Name("Directive.Pragma.Region.Desc")]
	[BaseDefinition(PredefinedClassificationTypeNames.Identifier)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Identifier)]
	[Order(After = "cppLocalVariable")]
	[Order(After = Priority.High)]
	[Order(After = "Directive")]
	[Order(After = "Directive.Desc")]
	internal sealed class Format_Directive_Pragma_Region_Desc
		: ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region_Desc(){
			DisplayName = "C++ Directive: \"pragma\": \"region\": Description";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Region;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Directive.Pragma.Region.namespace.Name")]
	[Name("Directive.Pragma.Region.namespace.Name")]
	[BaseDefinition(PredefinedClassificationTypeNames.Identifier)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Identifier)]
	[Order(After = "cppLocalVariable")]
	[Order(After = Priority.High)]
	[Order(After = "Directive")]
	[Order(After = "Directive.Desc")]
	[Order(After = "Directive.Pragma.Region")]
	internal sealed class Format_Directive_Pragma_Region_namespace_Name
		: ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region_namespace_Name(){
			DisplayName = "C++ Directive: \"pragma\": \"region\": \"namespace\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Directive.Pragma.Region.namespace.Desc")]
	[Name("Directive.Pragma.Region.namespace.Desc")]
	[BaseDefinition(PredefinedClassificationTypeNames.Identifier)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Identifier)]
	[Order(After = "cppLocalVariable")]
	[Order(After = Priority.High)]
	[Order(After = "Directive")]
	[Order(After = "Directive.Desc")]
	[Order(After = "Directive.Pragma.Region")]
	internal sealed class Format_Directive_Pragma_Region_namespace_Desc
		: ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region_namespace_Desc(){
			DisplayName = "C++ Directive: \"pragma\": \"region\": \"namespace\": Description";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Namespace;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Directive.Pragma.Region.class.Name")]
	[Name("Directive.Pragma.Region.class.Name")]
	[BaseDefinition(PredefinedClassificationTypeNames.Identifier)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Identifier)]
	[Order(After = "cppLocalVariable")]
	[Order(After = Priority.High)]
	[Order(After = "Directive")]
	[Order(After = "Directive.Desc")]
	[Order(After = "Directive.Pragma.Region")]
	internal sealed class Format_Directive_Pragma_Region_class_Name
		: ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region_class_Name(){
			DisplayName = "C++ Directive: \"pragma\": \"region\": \"class\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Directive.Pragma.Region.class.Desc")]
	[Name("Directive.Pragma.Region.class.Desc")]
	[BaseDefinition(PredefinedClassificationTypeNames.Identifier)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Identifier)]
	[Order(After = "cppLocalVariable")]
	[Order(After = Priority.High)]
	[Order(After = "Directive")]
	[Order(After = "Directive.Desc")]
	[Order(After = "Directive.Pragma.Region")]
	internal sealed class Format_Directive_Pragma_Region_class_Desc
		: ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region_class_Desc(){
			DisplayName = "C++ Directive: \"pragma\": \"region\": \"class\": Description";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Type;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Directive.Pragma.Region.struct.Name")]
	[Name("Directive.Pragma.Region.struct.Name")]
	[BaseDefinition(PredefinedClassificationTypeNames.Identifier)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Identifier)]
	[Order(After = "cppLocalVariable")]
	[Order(After = Priority.High)]
	[Order(After = "Directive")]
	[Order(After = "Directive.Desc")]
	[Order(After = "Directive.Pragma.Region")]
	internal sealed class Format_Directive_Pragma_Region_struct_Name
		: ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region_struct_Name(){
			DisplayName = "C++ Directive: \"pragma\": \"region\": \"struct\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Directive.Pragma.Region.struct.Desc")]
	[Name("Directive.Pragma.Region.struct.Desc")]
	[BaseDefinition(PredefinedClassificationTypeNames.Identifier)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Identifier)]
	[Order(After = "cppLocalVariable")]
	[Order(After = Priority.High)]
	[Order(After = "Directive")]
	[Order(After = "Directive.Desc")]
	[Order(After = "Directive.Pragma.Region")]
	internal sealed class Format_Directive_Pragma_Region_struct_Desc
		: ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region_struct_Desc(){
			DisplayName = "C++ Directive: \"pragma\": \"region\": \"struct\": Description";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Type;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Directive.Pragma.Region.union.Name")]
	[Name("Directive.Pragma.Region.union.Name")]
	[BaseDefinition(PredefinedClassificationTypeNames.Identifier)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Identifier)]
	[Order(After = "cppLocalVariable")]
	[Order(After = Priority.High)]
	[Order(After = "Directive")]
	[Order(After = "Directive.Desc")]
	[Order(After = "Directive.Pragma.Region")]
	internal sealed class Format_Directive_Pragma_Region_union_Name
		: ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region_union_Name(){
			DisplayName = "C++ Directive: \"pragma\": \"region\": \"union\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Directive.Pragma.Region.union.Desc")]
	[Name("Directive.Pragma.Region.union.Desc")]
	[BaseDefinition(PredefinedClassificationTypeNames.Identifier)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Identifier)]
	[Order(After = "cppLocalVariable")]
	[Order(After = Priority.High)]
	[Order(After = "Directive")]
	[Order(After = "Directive.Desc")]
	[Order(After = "Directive.Pragma.Region")]
	internal sealed class Format_Directive_Pragma_Region_union_Desc
		: ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region_union_Desc(){
			DisplayName = "C++ Directive: \"pragma\": \"region\": \"union\": Description";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Type;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Directive.Pragma.Region.concept.Name")]
	[Name("Directive.Pragma.Region.concept.Name")]
	[BaseDefinition(PredefinedClassificationTypeNames.Identifier)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Identifier)]
	[Order(After = "cppLocalVariable")]
	[Order(After = Priority.High)]
	[Order(After = "Directive")]
	[Order(After = "Directive.Desc")]
	[Order(After = "Directive.Pragma.Region")]
	internal sealed class Format_Directive_Pragma_Region_concept_Name
		: ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region_concept_Name(){
			DisplayName = "C++ Directive: \"pragma\": \"region\": \"concept\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Directive.Pragma.Region.concept.Desc")]
	[Name("Directive.Pragma.Region.concept.Desc")]
	[BaseDefinition(PredefinedClassificationTypeNames.Identifier)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Identifier)]
	[Order(After = "cppLocalVariable")]
	[Order(After = Priority.High)]
	[Order(After = "Directive")]
	[Order(After = "Directive.Desc")]
	[Order(After = "Directive.Pragma.Region")]
	internal sealed class Format_Directive_Pragma_Region_concept_Desc
		: ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region_concept_Desc(){
			DisplayName = "C++ Directive: \"pragma\": \"region\": \"concept\": Description";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Type;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Directive.Pragma.Region.macro.Name")]
	[Name("Directive.Pragma.Region.macro.Name")]
	[BaseDefinition(PredefinedClassificationTypeNames.Identifier)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Identifier)]
	[Order(After = "cppLocalVariable")]
	[Order(After = Priority.High)]
	[Order(After = "Directive")]
	[Order(After = "Directive.Desc")]
	[Order(After = "Directive.Pragma.Region")]
	internal sealed class Format_Directive_Pragma_Region_macro_Name
		: ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region_macro_Name(){
			DisplayName = "C++ Directive: \"pragma\": \"region\": \"macro\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Directive.Pragma.Region.macro.Desc")]
	[Name("Directive.Pragma.Region.macro.Desc")]
	[BaseDefinition(PredefinedClassificationTypeNames.Identifier)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Identifier)]
	[Order(After = "cppLocalVariable")]
	[Order(After = Priority.High)]
	[Order(After = "Directive")]
	[Order(After = "Directive.Desc")]
	[Order(After = "Directive.Pragma.Region")]
	internal sealed class Format_Directive_Pragma_Region_macro_Desc
		: ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region_macro_Desc(){
			DisplayName = "C++ Directive: \"pragma\": \"region\": \"macro\": Description";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Type;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Directive.Pragma.EndRegion")]
	[Name("Directive.Pragma.EndRegion")]
	[BaseDefinition(PredefinedClassificationTypeNames.Identifier)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Identifier)]
	[Order(After = "cppLocalVariable")]
	[Order(After = Priority.High)]
	[Order(After = "Directive")]
	[Order(After = "Directive.Desc")]
	[Order(After = "Directive.Pragma.Region")]
	internal sealed class Format_Directive_Pragma_EndRegion
		: ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_EndRegion(){
			DisplayName = "C++ Directive: \"pragma\": \"endregion\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Directive;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Directive.Pragma.Region.public")]
	[Name("Directive.Pragma.Region.public")]
	[BaseDefinition(PredefinedClassificationTypeNames.Identifier)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Identifier)]
	[Order(After = "cppLocalVariable")]
	[Order(After = Priority.High)]
	[Order(After = "Directive")]
	[Order(After = "Directive.Desc")]
	[Order(After = "Directive.Pragma.Region")]
	internal sealed class Format_Directive_Pragma_Region_public
		: ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region_public(){
			DisplayName = "C++ Directive: \"pragma\": Public";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Access;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Directive.Pragma.Region.protected")]
	[Name("Directive.Pragma.Region.protected")]
	[BaseDefinition(PredefinedClassificationTypeNames.Identifier)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Identifier)]
	[Order(After = "cppLocalVariable")]
	[Order(After = Priority.High)]
	[Order(After = "Directive")]
	[Order(After = "Directive.Desc")]
	[Order(After = "Directive.Pragma.Region")]
	internal sealed class Format_Directive_Pragma_Region_protected
		: ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region_protected(){
			DisplayName = "C++ Directive: \"pragma\": protected";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Access;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Directive.Pragma.Region.private")]
	[Name("Directive.Pragma.Region.private")]
	[BaseDefinition(PredefinedClassificationTypeNames.Identifier)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Identifier)]
	[Order(After = "cppLocalVariable")]
	[Order(After = Priority.High)]
	[Order(After = "Directive")]
	[Order(After = "Directive.Desc")]
	[Order(After = "Directive.Pragma.Region")]
	internal sealed class Format_Directive_Pragma_Region_private
		: ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region_private(){
			DisplayName = "C++ Directive: \"pragma\": private";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Access;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Directive.Pragma.Region.Usings")]
	[Name("Directive.Pragma.Region.Usings")]
	[BaseDefinition(PredefinedClassificationTypeNames.Identifier)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Identifier)]
	[Order(After = "cppLocalVariable")]
	[Order(After = Priority.High)]
	[Order(After = "Directive")]
	[Order(After = "Directive.Desc")]
	[Order(After = "Directive.Pragma.Region")]
	internal sealed class Format_Directive_Pragma_Region_Usings
		: ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region_Usings(){
			DisplayName = "C++ Directive: \"pragma\": Usings";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Directive.Pragma.Region.Friends")]
	[Name("Directive.Pragma.Region.Friends")]
	[BaseDefinition(PredefinedClassificationTypeNames.Identifier)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Identifier)]
	[Order(After = "cppLocalVariable")]
	[Order(After = Priority.High)]
	[Order(After = "Directive")]
	[Order(After = "Directive.Desc")]
	[Order(After = "Directive.Pragma.Region")]
	internal sealed class Format_Directive_Pragma_Region_Friends
		: ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region_Friends(){
			DisplayName = "C++ Directive: \"pragma\": Friends";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Directive.Pragma.Region.Members")]
	[Name("Directive.Pragma.Region.Members")]
	[BaseDefinition(PredefinedClassificationTypeNames.Identifier)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Identifier)]
	[Order(After = "cppLocalVariable")]
	[Order(After = Priority.High)]
	[Order(After = "Directive")]
	[Order(After = "Directive.Desc")]
	[Order(After = "Directive.Pragma.Region")]
	internal sealed class Format_Directive_Pragma_Region_Members
		: ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region_Members(){
			DisplayName = "C++ Directive: \"pragma\": Members";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Member;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Directive.Pragma.Region.Fields")]
	[Name("Directive.Pragma.Region.Fields")]
	[BaseDefinition(PredefinedClassificationTypeNames.Identifier)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Identifier)]
	[Order(After = "cppLocalVariable")]
	[Order(After = Priority.High)]
	[Order(After = "Directive")]
	[Order(After = "Directive.Desc")]
	[Order(After = "Directive.Pragma.Region")]
	internal sealed class Format_Directive_Pragma_Region_Fields
		: ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region_Fields(){
			DisplayName = "C++ Directive: \"pragma\": Fields";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Static;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Directive.Pragma.Region.Specials")]
	[Name("Directive.Pragma.Region.Specials")]
	[BaseDefinition(PredefinedClassificationTypeNames.Identifier)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Identifier)]
	[Order(After = "cppLocalVariable")]
	[Order(After = Priority.High)]
	[Order(After = "Directive")]
	[Order(After = "Directive.Desc")]
	[Order(After = "Directive.Pragma.Region")]
	internal sealed class Format_Directive_Pragma_Region_Specials
		: ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region_Specials(){
			DisplayName = "C++ Directive: \"pragma\": Specials";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Member;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Directive.Pragma.Region.Constructors")]
	[Name("Directive.Pragma.Region.Constructors")]
	[BaseDefinition(PredefinedClassificationTypeNames.Identifier)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Identifier)]
	[Order(After = "cppLocalVariable")]
	[Order(After = Priority.High)]
	[Order(After = "Directive")]
	[Order(After = "Directive.Desc")]
	[Order(After = "Directive.Pragma.Region")]
	internal sealed class Format_Directive_Pragma_Region_Constructors
		: ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region_Constructors(){
			DisplayName = "C++ Directive: \"pragma\": Constructors";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Member;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Directive.Pragma.Region.Operators")]
	[Name("Directive.Pragma.Region.Operators")]
	[BaseDefinition(PredefinedClassificationTypeNames.Identifier)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Identifier)]
	[Order(After = "cppLocalVariable")]
	[Order(After = Priority.High)]
	[Order(After = "Directive")]
	[Order(After = "Directive.Desc")]
	[Order(After = "Directive.Pragma.Region")]
	internal sealed class Format_Directive_Pragma_Region_Operators
		: ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region_Operators(){
			DisplayName = "C++ Directive: \"pragma\": Operators";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Member;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Directive.Pragma.Region.Methods")]
	[Name("Directive.Pragma.Region.Methods")]
	[BaseDefinition(PredefinedClassificationTypeNames.Identifier)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Identifier)]
	[Order(After = "cppLocalVariable")]
	[Order(After = Priority.High)]
	[Order(After = "Directive")]
	[Order(After = "Directive.Desc")]
	[Order(After = "Directive.Pragma.Region")]
	internal sealed class Format_Directive_Pragma_Region_Methods
		: ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region_Methods(){
			DisplayName = "C++ Directive: \"pragma\": Methods";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Member;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Directive.Pragma.Region.Functions")]
	[Name("Directive.Pragma.Region.Functions")]
	[BaseDefinition(PredefinedClassificationTypeNames.Identifier)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Identifier)]
	[Order(After = "cppLocalVariable")]
	[Order(After = Priority.High)]
	[Order(After = "Directive")]
	[Order(After = "Directive.Desc")]
	[Order(After = "Directive.Pragma.Region")]
	internal sealed class Format_Directive_Pragma_Region_Functions
		: ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region_Functions(){
			DisplayName = "C++ Directive: \"pragma\": Functions";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Static;
		}
	}
}
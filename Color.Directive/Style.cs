using Microsoft.VisualStudio.Language.StandardClassification;
using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Utilities;
using System.ComponentModel.Composition;

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
	:
		ClassificationFormatDefinition
	{
		public Format_Directive()
		{
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
	:
		ClassificationFormatDefinition
	{
		public Format_Directive_Hash()
		{
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
	:
		ClassificationFormatDefinition
	{
		public Format_Directive_Name()
		{
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
	:
		ClassificationFormatDefinition
	{
		public Format_Directive_Desc()
		{
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
	:
		ClassificationFormatDefinition
	{
		public Format_Directive_Pragma()
		{
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
	:
		ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Desc()
		{
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
	:
		ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region()
		{
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
	:
		ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region_Desc()
		{
			DisplayName = "C++ Directive: \"pragma\": \"region\": Description";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Region;
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
	:
		ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_EndRegion()
		{
			DisplayName = "C++ Directive: \"pragma\": \"endregion\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Directive;
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
	:
		ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region_namespace_Name()
		{
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
	:
		ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region_namespace_Desc()
		{
			DisplayName = "C++ Directive: \"pragma\": \"region\": \"namespace\": Description";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Namespace;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Directive.Pragma.Region.using.Name")]
	[Name("Directive.Pragma.Region.using.Name")]
	[BaseDefinition(PredefinedClassificationTypeNames.Identifier)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Identifier)]
	[Order(After = "cppLocalVariable")]
	[Order(After = Priority.High)]
	[Order(After = "Directive")]
	[Order(After = "Directive.Desc")]
	[Order(After = "Directive.Pragma.Region")]
	internal sealed class Format_Directive_Pragma_Region_using_Name
	:
		ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region_using_Name()
		{
			DisplayName = "C++ Directive: \"pragma\": \"region\": \"using\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Directive.Pragma.Region.using.Desc")]
	[Name("Directive.Pragma.Region.using.Desc")]
	[BaseDefinition(PredefinedClassificationTypeNames.Identifier)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Identifier)]
	[Order(After = "cppLocalVariable")]
	[Order(After = Priority.High)]
	[Order(After = "Directive")]
	[Order(After = "Directive.Desc")]
	[Order(After = "Directive.Pragma.Region")]
	internal sealed class Format_Directive_Pragma_Region_using_Desc
	:
		ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region_using_Desc()
		{
			DisplayName = "C++ Directive: \"pragma\": \"region\": \"using\": Description";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Using;
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
	:
		ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region_macro_Name()
		{
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
	:
		ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region_macro_Desc()
		{
			DisplayName = "C++ Directive: \"pragma\": \"region\": \"macro\": Description";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Macro;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Directive.Pragma.Region.friend.Name")]
	[Name("Directive.Pragma.Region.friend.Name")]
	[BaseDefinition(PredefinedClassificationTypeNames.Identifier)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Identifier)]
	[Order(After = "cppLocalVariable")]
	[Order(After = Priority.High)]
	[Order(After = "Directive")]
	[Order(After = "Directive.Desc")]
	[Order(After = "Directive.Pragma.Region")]
	internal sealed class Format_Directive_Pragma_Region_friend_Name
	:
		ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region_friend_Name()
		{
			DisplayName = "C++ Directive: \"pragma\": \"region\": \"friend\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Directive.Pragma.Region.friend.Desc")]
	[Name("Directive.Pragma.Region.friend.Desc")]
	[BaseDefinition(PredefinedClassificationTypeNames.Identifier)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Identifier)]
	[Order(After = "cppLocalVariable")]
	[Order(After = Priority.High)]
	[Order(After = "Directive")]
	[Order(After = "Directive.Desc")]
	[Order(After = "Directive.Pragma.Region")]
	internal sealed class Format_Directive_Pragma_Region_friend_Desc
	:
		ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region_friend_Desc()
		{
			DisplayName = "C++ Directive: \"pragma\": \"region\": \"friend\": Description";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Directive.Pragma.Region.component.Name")]
	[Name("Directive.Pragma.Region.component.Name")]
	[BaseDefinition(PredefinedClassificationTypeNames.Identifier)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Identifier)]
	[Order(After = "cppLocalVariable")]
	[Order(After = Priority.High)]
	[Order(After = "Directive")]
	[Order(After = "Directive.Desc")]
	[Order(After = "Directive.Pragma.Region")]
	internal sealed class Format_Directive_Pragma_Region_component_Name
	:
		ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region_component_Name()
		{
			DisplayName = "C++ Directive: \"pragma\": \"region\": \"component\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Directive.Pragma.Region.component.Desc")]
	[Name("Directive.Pragma.Region.component.Desc")]
	[BaseDefinition(PredefinedClassificationTypeNames.Identifier)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Identifier)]
	[Order(After = "cppLocalVariable")]
	[Order(After = Priority.High)]
	[Order(After = "Directive")]
	[Order(After = "Directive.Desc")]
	[Order(After = "Directive.Pragma.Region")]
	internal sealed class Format_Directive_Pragma_Region_component_Desc
	:
		ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region_component_Desc()
		{
			DisplayName = "C++ Directive: \"pragma\": \"region\": \"component\": Description";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Import;
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
	:
		ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region_concept_Name()
		{
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
	:
		ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region_concept_Desc()
		{
			DisplayName = "C++ Directive: \"pragma\": \"region\": \"concept\": Description";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Type;
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
	:
		ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region_class_Name()
		{
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
	:
		ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region_class_Desc()
		{
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
	:
		ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region_struct_Name()
		{
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
	:
		ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region_struct_Desc()
		{
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
	:
		ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region_union_Name()
		{
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
	:
		ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region_union_Desc()
		{
			DisplayName = "C++ Directive: \"pragma\": \"region\": \"union\": Description";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Type;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Directive.Pragma.Region.property.Name")]
	[Name("Directive.Pragma.Region.property.Name")]
	[BaseDefinition(PredefinedClassificationTypeNames.Identifier)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Identifier)]
	[Order(After = "cppLocalVariable")]
	[Order(After = Priority.High)]
	[Order(After = "Directive")]
	[Order(After = "Directive.Desc")]
	[Order(After = "Directive.Pragma.Region")]
	internal sealed class Format_Directive_Pragma_Region_property_Name
	:
		ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region_property_Name()
		{
			DisplayName = "C++ Directive: \"pragma\": \"region\": \"property\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Directive.Pragma.Region.property.Desc")]
	[Name("Directive.Pragma.Region.property.Desc")]
	[BaseDefinition(PredefinedClassificationTypeNames.Identifier)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Identifier)]
	[Order(After = "cppLocalVariable")]
	[Order(After = Priority.High)]
	[Order(After = "Directive")]
	[Order(After = "Directive.Desc")]
	[Order(After = "Directive.Pragma.Region")]
	internal sealed class Format_Directive_Pragma_Region_property_Desc
	:
		ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region_property_Desc()
		{
			DisplayName = "C++ Directive: \"pragma\": \"region\": \"property\": Description";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Inherit;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Directive.Pragma.Region.member.Name")]
	[Name("Directive.Pragma.Region.member.Name")]
	[BaseDefinition(PredefinedClassificationTypeNames.Identifier)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Identifier)]
	[Order(After = "cppLocalVariable")]
	[Order(After = Priority.High)]
	[Order(After = "Directive")]
	[Order(After = "Directive.Desc")]
	[Order(After = "Directive.Pragma.Region")]
	internal sealed class Format_Directive_Pragma_Region_member_Name
	:
		ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region_member_Name()
		{
			DisplayName = "C++ Directive: \"pragma\": \"region\": \"member\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Directive.Pragma.Region.member.Desc")]
	[Name("Directive.Pragma.Region.member.Desc")]
	[BaseDefinition(PredefinedClassificationTypeNames.Identifier)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Identifier)]
	[Order(After = "cppLocalVariable")]
	[Order(After = Priority.High)]
	[Order(After = "Directive")]
	[Order(After = "Directive.Desc")]
	[Order(After = "Directive.Pragma.Region")]
	internal sealed class Format_Directive_Pragma_Region_member_Desc
	:
		ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region_member_Desc()
		{
			DisplayName = "C++ Directive: \"pragma\": \"region\": \"member\": Description";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Member;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Directive.Pragma.Region.field.Name")]
	[Name("Directive.Pragma.Region.field.Name")]
	[BaseDefinition(PredefinedClassificationTypeNames.Identifier)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Identifier)]
	[Order(After = "cppLocalVariable")]
	[Order(After = Priority.High)]
	[Order(After = "Directive")]
	[Order(After = "Directive.Desc")]
	[Order(After = "Directive.Pragma.Region")]
	internal sealed class Format_Directive_Pragma_Region_field_Name
	:
		ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region_field_Name()
		{
			DisplayName = "C++ Directive: \"pragma\": \"region\": \"field\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Directive.Pragma.Region.field.Desc")]
	[Name("Directive.Pragma.Region.field.Desc")]
	[BaseDefinition(PredefinedClassificationTypeNames.Identifier)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Identifier)]
	[Order(After = "cppLocalVariable")]
	[Order(After = Priority.High)]
	[Order(After = "Directive")]
	[Order(After = "Directive.Desc")]
	[Order(After = "Directive.Pragma.Region")]
	internal sealed class Format_Directive_Pragma_Region_field_Desc
	:
		ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region_field_Desc()
		{
			DisplayName = "C++ Directive: \"pragma\": \"region\": \"field\": Description";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Static;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Directive.Pragma.Region.enum.Name")]
	[Name("Directive.Pragma.Region.enum.Name")]
	[BaseDefinition(PredefinedClassificationTypeNames.Identifier)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Identifier)]
	[Order(After = "cppLocalVariable")]
	[Order(After = Priority.High)]
	[Order(After = "Directive")]
	[Order(After = "Directive.Desc")]
	[Order(After = "Directive.Pragma.Region")]
	internal sealed class Format_Directive_Pragma_Region_enum_Name
	:
		ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region_enum_Name()
		{
			DisplayName = "C++ Directive: \"pragma\": \"region\": \"enum\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Directive.Pragma.Region.enum.Desc")]
	[Name("Directive.Pragma.Region.enum.Desc")]
	[BaseDefinition(PredefinedClassificationTypeNames.Identifier)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Identifier)]
	[Order(After = "cppLocalVariable")]
	[Order(After = Priority.High)]
	[Order(After = "Directive")]
	[Order(After = "Directive.Desc")]
	[Order(After = "Directive.Pragma.Region")]
	internal sealed class Format_Directive_Pragma_Region_enum_Desc
	:
		ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region_enum_Desc()
		{
			DisplayName = "C++ Directive: \"pragma\": \"region\": \"enum\": Description";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Enum;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Directive.Pragma.Region.delegate.Name")]
	[Name("Directive.Pragma.Region.delegate.Name")]
	[BaseDefinition(PredefinedClassificationTypeNames.Identifier)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Identifier)]
	[Order(After = "cppLocalVariable")]
	[Order(After = Priority.High)]
	[Order(After = "Directive")]
	[Order(After = "Directive.Desc")]
	[Order(After = "Directive.Pragma.Region")]
	internal sealed class Format_Directive_Pragma_Region_delegate_Name
	:
		ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region_delegate_Name()
		{
			DisplayName = "C++ Directive: \"pragma\": \"region\": \"delegate\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Directive.Pragma.Region.delegate.Desc")]
	[Name("Directive.Pragma.Region.delegate.Desc")]
	[BaseDefinition(PredefinedClassificationTypeNames.Identifier)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Identifier)]
	[Order(After = "cppLocalVariable")]
	[Order(After = Priority.High)]
	[Order(After = "Directive")]
	[Order(After = "Directive.Desc")]
	[Order(After = "Directive.Pragma.Region")]
	internal sealed class Format_Directive_Pragma_Region_delegate_Desc
	:
		ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region_delegate_Desc()
		{
			DisplayName = "C++ Directive: \"pragma\": \"region\": \"delegate\": Description";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Export;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Directive.Pragma.Region.special.Name")]
	[Name("Directive.Pragma.Region.special.Name")]
	[BaseDefinition(PredefinedClassificationTypeNames.Identifier)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Identifier)]
	[Order(After = "cppLocalVariable")]
	[Order(After = Priority.High)]
	[Order(After = "Directive")]
	[Order(After = "Directive.Desc")]
	[Order(After = "Directive.Pragma.Region")]
	internal sealed class Format_Directive_Pragma_Region_special_Name
	:
		ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region_special_Name()
		{
			DisplayName = "C++ Directive: \"pragma\": \"region\": \"special\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Directive.Pragma.Region.special.Desc")]
	[Name("Directive.Pragma.Region.special.Desc")]
	[BaseDefinition(PredefinedClassificationTypeNames.Identifier)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Identifier)]
	[Order(After = "cppLocalVariable")]
	[Order(After = Priority.High)]
	[Order(After = "Directive")]
	[Order(After = "Directive.Desc")]
	[Order(After = "Directive.Pragma.Region")]
	internal sealed class Format_Directive_Pragma_Region_special_Desc
	:
		ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region_special_Desc()
		{
			DisplayName = "C++ Directive: \"pragma\": \"region\": \"special\": Description";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Type;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Directive.Pragma.Region.constructor.Name")]
	[Name("Directive.Pragma.Region.constructor.Name")]
	[BaseDefinition(PredefinedClassificationTypeNames.Identifier)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Identifier)]
	[Order(After = "cppLocalVariable")]
	[Order(After = Priority.High)]
	[Order(After = "Directive")]
	[Order(After = "Directive.Desc")]
	[Order(After = "Directive.Pragma.Region")]
	internal sealed class Format_Directive_Pragma_Region_constructor_Name
	:
		ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region_constructor_Name()
		{
			DisplayName = "C++ Directive: \"pragma\": \"region\": \"constructor\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Directive.Pragma.Region.constructor.Desc")]
	[Name("Directive.Pragma.Region.constructor.Desc")]
	[BaseDefinition(PredefinedClassificationTypeNames.Identifier)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Identifier)]
	[Order(After = "cppLocalVariable")]
	[Order(After = Priority.High)]
	[Order(After = "Directive")]
	[Order(After = "Directive.Desc")]
	[Order(After = "Directive.Pragma.Region")]
	internal sealed class Format_Directive_Pragma_Region_constructor_Desc
	:
		ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region_constructor_Desc()
		{
			DisplayName = "C++ Directive: \"pragma\": \"region\": \"constructor\": Description";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Type;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Directive.Pragma.Region.override.Name")]
	[Name("Directive.Pragma.Region.override.Name")]
	[BaseDefinition(PredefinedClassificationTypeNames.Identifier)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Identifier)]
	[Order(After = "cppLocalVariable")]
	[Order(After = Priority.High)]
	[Order(After = "Directive")]
	[Order(After = "Directive.Desc")]
	[Order(After = "Directive.Pragma.Region")]
	internal sealed class Format_Directive_Pragma_Region_override_Name
	:
		ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region_override_Name()
		{
			DisplayName = "C++ Directive: \"pragma\": \"region\": \"override\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Directive.Pragma.Region.override.Desc")]
	[Name("Directive.Pragma.Region.override.Desc")]
	[BaseDefinition(PredefinedClassificationTypeNames.Identifier)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Identifier)]
	[Order(After = "cppLocalVariable")]
	[Order(After = Priority.High)]
	[Order(After = "Directive")]
	[Order(After = "Directive.Desc")]
	[Order(After = "Directive.Pragma.Region")]
	internal sealed class Format_Directive_Pragma_Region_override_Desc
	:
		ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region_override_Desc()
		{
			DisplayName = "C++ Directive: \"pragma\": \"region\": \"override\": Description";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Inherit;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Directive.Pragma.Region.method.Name")]
	[Name("Directive.Pragma.Region.method.Name")]
	[BaseDefinition(PredefinedClassificationTypeNames.Identifier)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Identifier)]
	[Order(After = "cppLocalVariable")]
	[Order(After = Priority.High)]
	[Order(After = "Directive")]
	[Order(After = "Directive.Desc")]
	[Order(After = "Directive.Pragma.Region")]
	internal sealed class Format_Directive_Pragma_Region_method_Name
	:
		ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region_method_Name()
		{
			DisplayName = "C++ Directive: \"pragma\": \"region\": \"method\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Directive.Pragma.Region.method.Desc")]
	[Name("Directive.Pragma.Region.method.Desc")]
	[BaseDefinition(PredefinedClassificationTypeNames.Identifier)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Identifier)]
	[Order(After = "cppLocalVariable")]
	[Order(After = Priority.High)]
	[Order(After = "Directive")]
	[Order(After = "Directive.Desc")]
	[Order(After = "Directive.Pragma.Region")]
	internal sealed class Format_Directive_Pragma_Region_method_Desc
	:
		ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region_method_Desc()
		{
			DisplayName = "C++ Directive: \"pragma\": \"region\": \"method\": Description";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Member;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Directive.Pragma.Region.getter.Name")]
	[Name("Directive.Pragma.Region.getter.Name")]
	[BaseDefinition(PredefinedClassificationTypeNames.Identifier)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Identifier)]
	[Order(After = "cppLocalVariable")]
	[Order(After = Priority.High)]
	[Order(After = "Directive")]
	[Order(After = "Directive.Desc")]
	[Order(After = "Directive.Pragma.Region")]
	internal sealed class Format_Directive_Pragma_Region_getter_Name
	:
		ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region_getter_Name()
		{
			DisplayName = "C++ Directive: \"pragma\": \"region\": \"getter\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Directive.Pragma.Region.getter.Desc")]
	[Name("Directive.Pragma.Region.getter.Desc")]
	[BaseDefinition(PredefinedClassificationTypeNames.Identifier)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Identifier)]
	[Order(After = "cppLocalVariable")]
	[Order(After = Priority.High)]
	[Order(After = "Directive")]
	[Order(After = "Directive.Desc")]
	[Order(After = "Directive.Pragma.Region")]
	internal sealed class Format_Directive_Pragma_Region_getter_Desc
	:
		ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region_getter_Desc()
		{
			DisplayName = "C++ Directive: \"pragma\": \"region\": \"getter\": Description";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Member;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Directive.Pragma.Region.setter.Name")]
	[Name("Directive.Pragma.Region.setter.Name")]
	[BaseDefinition(PredefinedClassificationTypeNames.Identifier)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Identifier)]
	[Order(After = "cppLocalVariable")]
	[Order(After = Priority.High)]
	[Order(After = "Directive")]
	[Order(After = "Directive.Desc")]
	[Order(After = "Directive.Pragma.Region")]
	internal sealed class Format_Directive_Pragma_Region_setter_Name
	:
		ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region_setter_Name()
		{
			DisplayName = "C++ Directive: \"pragma\": \"region\": \"setter\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Directive.Pragma.Region.setter.Desc")]
	[Name("Directive.Pragma.Region.setter.Desc")]
	[BaseDefinition(PredefinedClassificationTypeNames.Identifier)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Identifier)]
	[Order(After = "cppLocalVariable")]
	[Order(After = Priority.High)]
	[Order(After = "Directive")]
	[Order(After = "Directive.Desc")]
	[Order(After = "Directive.Pragma.Region")]
	internal sealed class Format_Directive_Pragma_Region_setter_Desc
	:
		ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region_setter_Desc()
		{
			DisplayName = "C++ Directive: \"pragma\": \"region\": \"setter\": Description";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Member;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Directive.Pragma.Region.operator.Name")]
	[Name("Directive.Pragma.Region.operator.Name")]
	[BaseDefinition(PredefinedClassificationTypeNames.Identifier)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Identifier)]
	[Order(After = "cppLocalVariable")]
	[Order(After = Priority.High)]
	[Order(After = "Directive")]
	[Order(After = "Directive.Desc")]
	[Order(After = "Directive.Pragma.Region")]
	internal sealed class Format_Directive_Pragma_Region_operator_Name
	:
		ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region_operator_Name()
		{
			DisplayName = "C++ Directive: \"pragma\": \"region\": \"operator\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Directive.Pragma.Region.operator.Desc")]
	[Name("Directive.Pragma.Region.operator.Desc")]
	[BaseDefinition(PredefinedClassificationTypeNames.Identifier)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Identifier)]
	[Order(After = "cppLocalVariable")]
	[Order(After = Priority.High)]
	[Order(After = "Directive")]
	[Order(After = "Directive.Desc")]
	[Order(After = "Directive.Pragma.Region")]
	internal sealed class Format_Directive_Pragma_Region_operator_Desc
	:
		ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region_operator_Desc()
		{
			DisplayName = "C++ Directive: \"pragma\": \"region\": \"operator\": Description";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Object;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Directive.Pragma.Region.conversion.Name")]
	[Name("Directive.Pragma.Region.conversion.Name")]
	[BaseDefinition(PredefinedClassificationTypeNames.Identifier)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Identifier)]
	[Order(After = "cppLocalVariable")]
	[Order(After = Priority.High)]
	[Order(After = "Directive")]
	[Order(After = "Directive.Desc")]
	[Order(After = "Directive.Pragma.Region")]
	internal sealed class Format_Directive_Pragma_Region_conversion_Name
	:
		ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region_conversion_Name()
		{
			DisplayName = "C++ Directive: \"pragma\": \"region\": \"conversion\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Directive.Pragma.Region.conversion.Desc")]
	[Name("Directive.Pragma.Region.conversion.Desc")]
	[BaseDefinition(PredefinedClassificationTypeNames.Identifier)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Identifier)]
	[Order(After = "cppLocalVariable")]
	[Order(After = Priority.High)]
	[Order(After = "Directive")]
	[Order(After = "Directive.Desc")]
	[Order(After = "Directive.Pragma.Region")]
	internal sealed class Format_Directive_Pragma_Region_conversion_Desc
	:
		ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region_conversion_Desc()
		{
			DisplayName = "C++ Directive: \"pragma\": \"region\": \"conversion\": Description";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Object;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Directive.Pragma.Region.function.Name")]
	[Name("Directive.Pragma.Region.function.Name")]
	[BaseDefinition(PredefinedClassificationTypeNames.Identifier)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Identifier)]
	[Order(After = "cppLocalVariable")]
	[Order(After = Priority.High)]
	[Order(After = "Directive")]
	[Order(After = "Directive.Desc")]
	[Order(After = "Directive.Pragma.Region")]
	internal sealed class Format_Directive_Pragma_Region_function_Name
	:
		ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region_function_Name()
		{
			DisplayName = "C++ Directive: \"pragma\": \"region\": \"function\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Directive.Pragma.Region.function.Desc")]
	[Name("Directive.Pragma.Region.function.Desc")]
	[BaseDefinition(PredefinedClassificationTypeNames.Identifier)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Identifier)]
	[Order(After = "cppLocalVariable")]
	[Order(After = Priority.High)]
	[Order(After = "Directive")]
	[Order(After = "Directive.Desc")]
	[Order(After = "Directive.Pragma.Region")]
	internal sealed class Format_Directive_Pragma_Region_function_Desc
	:
		ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region_function_Desc()
		{
			DisplayName = "C++ Directive: \"pragma\": \"region\": \"function\": Description";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Static;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Directive.Pragma.Region.event.Name")]
	[Name("Directive.Pragma.Region.event.Name")]
	[BaseDefinition(PredefinedClassificationTypeNames.Identifier)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Identifier)]
	[Order(After = "cppLocalVariable")]
	[Order(After = Priority.High)]
	[Order(After = "Directive")]
	[Order(After = "Directive.Desc")]
	[Order(After = "Directive.Pragma.Region")]
	internal sealed class Format_Directive_Pragma_Region_event_Name
	:
		ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region_event_Name()
		{
			DisplayName = "C++ Directive: \"pragma\": \"region\": \"event\"";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Directive.Pragma.Region.event.Desc")]
	[Name("Directive.Pragma.Region.event.Desc")]
	[BaseDefinition(PredefinedClassificationTypeNames.Identifier)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Identifier)]
	[Order(After = "cppLocalVariable")]
	[Order(After = Priority.High)]
	[Order(After = "Directive")]
	[Order(After = "Directive.Desc")]
	[Order(After = "Directive.Pragma.Region")]
	internal sealed class Format_Directive_Pragma_Region_event_Desc
	:
		ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region_event_Desc()
		{
			DisplayName = "C++ Directive: \"pragma\": \"region\": \"event\": Description";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Export;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Directive.Pragma.Region.Headers")]
	[Name("Directive.Pragma.Region.Headers")]
	[BaseDefinition(PredefinedClassificationTypeNames.Identifier)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Identifier)]
	[Order(After = "cppLocalVariable")]
	[Order(After = Priority.High)]
	[Order(After = "Directive")]
	[Order(After = "Directive.Desc")]
	[Order(After = "Directive.Pragma.Region")]
	internal sealed class Format_Directive_Pragma_Region_Headers
	:
		ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region_Headers()
		{
			DisplayName = "C++ Directive: \"pragma\": Headers";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Header;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Directive.Pragma.Region.Meta")]
	[Name("Directive.Pragma.Region.Meta")]
	[BaseDefinition(PredefinedClassificationTypeNames.Identifier)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Identifier)]
	[Order(After = "cppLocalVariable")]
	[Order(After = Priority.High)]
	[Order(After = "Directive")]
	[Order(After = "Directive.Desc")]
	[Order(After = "Directive.Pragma.Region")]
	internal sealed class Format_Directive_Pragma_Region_Meta
	:
		ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region_Meta()
		{
			DisplayName = "C++ Directive: \"pragma\": Meta";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Meta;
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
	:
		ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region_Usings()
		{
			DisplayName = "C++ Directive: \"pragma\": Usings";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Using;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Directive.Pragma.Region.Macros")]
	[Name("Directive.Pragma.Region.Macros")]
	[BaseDefinition(PredefinedClassificationTypeNames.Identifier)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Identifier)]
	[Order(After = "cppLocalVariable")]
	[Order(After = Priority.High)]
	[Order(After = "Directive")]
	[Order(After = "Directive.Desc")]
	[Order(After = "Directive.Pragma.Region")]
	internal sealed class Format_Directive_Pragma_Region_Macros
	:
		ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region_Macros()
		{
			DisplayName = "C++ Directive: \"pragma\": Macros";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Macro;
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
	:
		ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region_Friends()
		{
			DisplayName = "C++ Directive: \"pragma\": Friends";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Keyword;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Directive.Pragma.Region.Components")]
	[Name("Directive.Pragma.Region.Components")]
	[BaseDefinition(PredefinedClassificationTypeNames.Identifier)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Identifier)]
	[Order(After = "cppLocalVariable")]
	[Order(After = Priority.High)]
	[Order(After = "Directive")]
	[Order(After = "Directive.Desc")]
	[Order(After = "Directive.Pragma.Region")]
	internal sealed class Format_Directive_Pragma_Region_Components
	:
		ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region_Components()
		{
			DisplayName = "C++ Directive: \"pragma\": Components";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Import;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Directive.Pragma.Region.Concepts")]
	[Name("Directive.Pragma.Region.Concepts")]
	[BaseDefinition(PredefinedClassificationTypeNames.Identifier)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Identifier)]
	[Order(After = "cppLocalVariable")]
	[Order(After = Priority.High)]
	[Order(After = "Directive")]
	[Order(After = "Directive.Desc")]
	[Order(After = "Directive.Pragma.Region")]
	internal sealed class Format_Directive_Pragma_Region_Concepts
	:
		ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region_Concepts()
		{
			DisplayName = "C++ Directive: \"pragma\": Concepts";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Type;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Directive.Pragma.Region.Classes")]
	[Name("Directive.Pragma.Region.Classes")]
	[BaseDefinition(PredefinedClassificationTypeNames.Identifier)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Identifier)]
	[Order(After = "cppLocalVariable")]
	[Order(After = Priority.High)]
	[Order(After = "Directive")]
	[Order(After = "Directive.Desc")]
	[Order(After = "Directive.Pragma.Region")]
	internal sealed class Format_Directive_Pragma_Region_Classes
	:
		ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region_Classes()
		{
			DisplayName = "C++ Directive: \"pragma\": Classes";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Type;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Directive.Pragma.Region.Structs")]
	[Name("Directive.Pragma.Region.Structs")]
	[BaseDefinition(PredefinedClassificationTypeNames.Identifier)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Identifier)]
	[Order(After = "cppLocalVariable")]
	[Order(After = Priority.High)]
	[Order(After = "Directive")]
	[Order(After = "Directive.Desc")]
	[Order(After = "Directive.Pragma.Region")]
	internal sealed class Format_Directive_Pragma_Region_Structs
	:
		ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region_Structs()
		{
			DisplayName = "C++ Directive: \"pragma\": Structs";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Type;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Directive.Pragma.Region.Unions")]
	[Name("Directive.Pragma.Region.Unions")]
	[BaseDefinition(PredefinedClassificationTypeNames.Identifier)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Identifier)]
	[Order(After = "cppLocalVariable")]
	[Order(After = Priority.High)]
	[Order(After = "Directive")]
	[Order(After = "Directive.Desc")]
	[Order(After = "Directive.Pragma.Region")]
	internal sealed class Format_Directive_Pragma_Region_Unions
	:
		ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region_Unions()
		{
			DisplayName = "C++ Directive: \"pragma\": Unions";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Type;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Directive.Pragma.Region.Properties")]
	[Name("Directive.Pragma.Region.Properties")]
	[BaseDefinition(PredefinedClassificationTypeNames.Identifier)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Identifier)]
	[Order(After = "cppLocalVariable")]
	[Order(After = Priority.High)]
	[Order(After = "Directive")]
	[Order(After = "Directive.Desc")]
	[Order(After = "Directive.Pragma.Region")]
	internal sealed class Format_Directive_Pragma_Region_Properties
	:
		ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region_Properties()
		{
			DisplayName = "C++ Directive: \"pragma\": Properties";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Inherit;
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
	:
		ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region_Members()
		{
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
	:
		ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region_Fields()
		{
			DisplayName = "C++ Directive: \"pragma\": Fields";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Static;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Directive.Pragma.Region.Enums")]
	[Name("Directive.Pragma.Region.Enums")]
	[BaseDefinition(PredefinedClassificationTypeNames.Identifier)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Identifier)]
	[Order(After = "cppLocalVariable")]
	[Order(After = Priority.High)]
	[Order(After = "Directive")]
	[Order(After = "Directive.Desc")]
	[Order(After = "Directive.Pragma.Region")]
	internal sealed class Format_Directive_Pragma_Region_Enums
	:
		ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region_Enums()
		{
			DisplayName = "C++ Directive: \"pragma\": Enums";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Enum;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Directive.Pragma.Region.Delegates")]
	[Name("Directive.Pragma.Region.Delegates")]
	[BaseDefinition(PredefinedClassificationTypeNames.Identifier)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Identifier)]
	[Order(After = "cppLocalVariable")]
	[Order(After = Priority.High)]
	[Order(After = "Directive")]
	[Order(After = "Directive.Desc")]
	[Order(After = "Directive.Pragma.Region")]
	internal sealed class Format_Directive_Pragma_Region_Delegates
	:
		ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region_Delegates()
		{
			DisplayName = "C++ Directive: \"pragma\": Delegates";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Export;
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
	:
		ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region_Specials()
		{
			DisplayName = "C++ Directive: \"pragma\": Specials";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Type;
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
	:
		ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region_Constructors()
		{
			DisplayName = "C++ Directive: \"pragma\": Constructors";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Type;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Directive.Pragma.Region.Overrides")]
	[Name("Directive.Pragma.Region.Overrides")]
	[BaseDefinition(PredefinedClassificationTypeNames.Identifier)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Identifier)]
	[Order(After = "cppLocalVariable")]
	[Order(After = Priority.High)]
	[Order(After = "Directive")]
	[Order(After = "Directive.Desc")]
	[Order(After = "Directive.Pragma.Region")]
	internal sealed class Format_Directive_Pragma_Region_Overrides
	:
		ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region_Overrides()
		{
			DisplayName = "C++ Directive: \"pragma\": Overrides";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Inherit;
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
	:
		ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region_Methods()
		{
			DisplayName = "C++ Directive: \"pragma\": Methods";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Member;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Directive.Pragma.Region.Getters")]
	[Name("Directive.Pragma.Region.Getters")]
	[BaseDefinition(PredefinedClassificationTypeNames.Identifier)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Identifier)]
	[Order(After = "cppLocalVariable")]
	[Order(After = Priority.High)]
	[Order(After = "Directive")]
	[Order(After = "Directive.Desc")]
	[Order(After = "Directive.Pragma.Region")]
	internal sealed class Format_Directive_Pragma_Region_Getters
	:
		ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region_Getters()
		{
			DisplayName = "C++ Directive: \"pragma\": Getters";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Member;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Directive.Pragma.Region.Setters")]
	[Name("Directive.Pragma.Region.Setters")]
	[BaseDefinition(PredefinedClassificationTypeNames.Identifier)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Identifier)]
	[Order(After = "cppLocalVariable")]
	[Order(After = Priority.High)]
	[Order(After = "Directive")]
	[Order(After = "Directive.Desc")]
	[Order(After = "Directive.Pragma.Region")]
	internal sealed class Format_Directive_Pragma_Region_Setters
	:
		ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region_Setters()
		{
			DisplayName = "C++ Directive: \"pragma\": Setters";

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
	:
		ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region_Operators()
		{
			DisplayName = "C++ Directive: \"pragma\": Operators";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Object;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Directive.Pragma.Region.Conversions")]
	[Name("Directive.Pragma.Region.Conversions")]
	[BaseDefinition(PredefinedClassificationTypeNames.Identifier)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Identifier)]
	[Order(After = "cppLocalVariable")]
	[Order(After = Priority.High)]
	[Order(After = "Directive")]
	[Order(After = "Directive.Desc")]
	[Order(After = "Directive.Pragma.Region")]
	internal sealed class Format_Directive_Pragma_Region_Conversions
	:
		ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region_Conversions()
		{
			DisplayName = "C++ Directive: \"pragma\": Conversions";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Object;
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
	:
		ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region_Functions()
		{
			DisplayName = "C++ Directive: \"pragma\": Functions";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Static;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Directive.Pragma.Region.Events")]
	[Name("Directive.Pragma.Region.Events")]
	[BaseDefinition(PredefinedClassificationTypeNames.Identifier)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Identifier)]
	[Order(After = "cppLocalVariable")]
	[Order(After = Priority.High)]
	[Order(After = "Directive")]
	[Order(After = "Directive.Desc")]
	[Order(After = "Directive.Pragma.Region")]
	internal sealed class Format_Directive_Pragma_Region_Events
	:
		ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region_Events()
		{
			DisplayName = "C++ Directive: \"pragma\": Events";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Export;
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
	:
		ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region_public()
		{
			DisplayName = "C++ Directive: \"pragma\": Public";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Public;
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
	:
		ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region_protected()
		{
			DisplayName = "C++ Directive: \"pragma\": protected";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Protected;
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
	:
		ClassificationFormatDefinition
	{
		public Format_Directive_Pragma_Region_private()
		{
			DisplayName = "C++ Directive: \"pragma\": private";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Private;
		}
	}
}
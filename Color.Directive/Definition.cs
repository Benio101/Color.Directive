using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Utilities;
using System.ComponentModel.Composition;

namespace Color.Directive
{
	internal static class Definitions
	{
		#pragma warning disable 169
		#pragma warning disable IDE0051

		// > The field is never used
		// Reason: The field is used by MEF.

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
		[Name("Directive.Pragma.EndRegion")]
		private static readonly ClassificationTypeDefinition
		Definition_Directive_Pragma_EndRegion;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Directive.Pragma.Region.namespace.Name")]
		private static readonly ClassificationTypeDefinition
		Definition_Directive_Pragma_Region_namespace_Name;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Directive.Pragma.Region.namespace.Desc")]
		private static readonly ClassificationTypeDefinition
		Definition_Directive_Pragma_Region_namespace_Desc;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Directive.Pragma.Region.using.Name")]
		private static readonly ClassificationTypeDefinition
		Definition_Directive_Pragma_Region_using_Name;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Directive.Pragma.Region.using.Desc")]
		private static readonly ClassificationTypeDefinition
		Definition_Directive_Pragma_Region_using_Desc;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Directive.Pragma.Region.macro.Name")]
		private static readonly ClassificationTypeDefinition
		Definition_Directive_Pragma_Region_macro_Name;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Directive.Pragma.Region.macro.Desc")]
		private static readonly ClassificationTypeDefinition
		Definition_Directive_Pragma_Region_macro_Desc;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Directive.Pragma.Region.friend.Name")]
		private static readonly ClassificationTypeDefinition
		Definition_Directive_Pragma_Region_friend_Name;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Directive.Pragma.Region.friend.Desc")]
		private static readonly ClassificationTypeDefinition
		Definition_Directive_Pragma_Region_friend_Desc;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Directive.Pragma.Region.component.Name")]
		private static readonly ClassificationTypeDefinition
		Definition_Directive_Pragma_Region_component_Name;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Directive.Pragma.Region.component.Desc")]
		private static readonly ClassificationTypeDefinition
		Definition_Directive_Pragma_Region_component_Desc;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Directive.Pragma.Region.concept.Name")]
		private static readonly ClassificationTypeDefinition
		Definition_Directive_Pragma_Region_concept_Name;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Directive.Pragma.Region.concept.Desc")]
		private static readonly ClassificationTypeDefinition
		Definition_Directive_Pragma_Region_concept_Desc;

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
		[Name("Directive.Pragma.Region.property.Name")]
		private static readonly ClassificationTypeDefinition
		Definition_Directive_Pragma_Region_property_Name;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Directive.Pragma.Region.property.Desc")]
		private static readonly ClassificationTypeDefinition
		Definition_Directive_Pragma_Region_property_Desc;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Directive.Pragma.Region.member.Name")]
		private static readonly ClassificationTypeDefinition
		Definition_Directive_Pragma_Region_member_Name;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Directive.Pragma.Region.member.Desc")]
		private static readonly ClassificationTypeDefinition
		Definition_Directive_Pragma_Region_member_Desc;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Directive.Pragma.Region.field.Name")]
		private static readonly ClassificationTypeDefinition
		Definition_Directive_Pragma_Region_field_Name;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Directive.Pragma.Region.field.Desc")]
		private static readonly ClassificationTypeDefinition
		Definition_Directive_Pragma_Region_field_Desc;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Directive.Pragma.Region.enum.Name")]
		private static readonly ClassificationTypeDefinition
		Definition_Directive_Pragma_Region_enum_Name;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Directive.Pragma.Region.enum.Desc")]
		private static readonly ClassificationTypeDefinition
		Definition_Directive_Pragma_Region_enum_Desc;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Directive.Pragma.Region.delegate.Name")]
		private static readonly ClassificationTypeDefinition
		Definition_Directive_Pragma_Region_delegate_Name;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Directive.Pragma.Region.delegate.Desc")]
		private static readonly ClassificationTypeDefinition
		Definition_Directive_Pragma_Region_delegate_Desc;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Directive.Pragma.Region.special.Name")]
		private static readonly ClassificationTypeDefinition
		Definition_Directive_Pragma_Region_special_Name;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Directive.Pragma.Region.special.Desc")]
		private static readonly ClassificationTypeDefinition
		Definition_Directive_Pragma_Region_special_Desc;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Directive.Pragma.Region.constructor.Name")]
		private static readonly ClassificationTypeDefinition
		Definition_Directive_Pragma_Region_constructor_Name;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Directive.Pragma.Region.constructor.Desc")]
		private static readonly ClassificationTypeDefinition
		Definition_Directive_Pragma_Region_constructor_Desc;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Directive.Pragma.Region.override.Name")]
		private static readonly ClassificationTypeDefinition
		Definition_Directive_Pragma_Region_override_Name;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Directive.Pragma.Region.override.Desc")]
		private static readonly ClassificationTypeDefinition
		Definition_Directive_Pragma_Region_override_Desc;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Directive.Pragma.Region.method.Name")]
		private static readonly ClassificationTypeDefinition
		Definition_Directive_Pragma_Region_method_Name;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Directive.Pragma.Region.method.Desc")]
		private static readonly ClassificationTypeDefinition
		Definition_Directive_Pragma_Region_method_Desc;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Directive.Pragma.Region.getter.Name")]
		private static readonly ClassificationTypeDefinition
		Definition_Directive_Pragma_Region_getter_Name;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Directive.Pragma.Region.getter.Desc")]
		private static readonly ClassificationTypeDefinition
		Definition_Directive_Pragma_Region_getter_Desc;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Directive.Pragma.Region.setter.Name")]
		private static readonly ClassificationTypeDefinition
		Definition_Directive_Pragma_Region_setter_Name;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Directive.Pragma.Region.setter.Desc")]
		private static readonly ClassificationTypeDefinition
		Definition_Directive_Pragma_Region_setter_Desc;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Directive.Pragma.Region.operator.Name")]
		private static readonly ClassificationTypeDefinition
		Definition_Directive_Pragma_Region_operator_Name;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Directive.Pragma.Region.operator.Desc")]
		private static readonly ClassificationTypeDefinition
		Definition_Directive_Pragma_Region_operator_Desc;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Directive.Pragma.Region.conversion.Name")]
		private static readonly ClassificationTypeDefinition
		Definition_Directive_Pragma_Region_conversion_Name;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Directive.Pragma.Region.conversion.Desc")]
		private static readonly ClassificationTypeDefinition
		Definition_Directive_Pragma_Region_conversion_Desc;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Directive.Pragma.Region.function.Name")]
		private static readonly ClassificationTypeDefinition
		Definition_Directive_Pragma_Region_function_Name;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Directive.Pragma.Region.function.Desc")]
		private static readonly ClassificationTypeDefinition
		Definition_Directive_Pragma_Region_function_Desc;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Directive.Pragma.Region.event.Name")]
		private static readonly ClassificationTypeDefinition
		Definition_Directive_Pragma_Region_event_Name;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Directive.Pragma.Region.event.Desc")]
		private static readonly ClassificationTypeDefinition
		Definition_Directive_Pragma_Region_event_Desc;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Directive.Pragma.Region.Headers")]
		private static readonly ClassificationTypeDefinition
		Definition_Directive_Pragma_Region_Headers;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Directive.Pragma.Region.Meta")]
		private static readonly ClassificationTypeDefinition
		Definition_Directive_Pragma_Region_Meta;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Directive.Pragma.Region.Usings")]
		private static readonly ClassificationTypeDefinition
		Definition_Directive_Pragma_Region_Usings;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Directive.Pragma.Region.Macros")]
		private static readonly ClassificationTypeDefinition
		Definition_Directive_Pragma_Region_Macros;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Directive.Pragma.Region.Friends")]
		private static readonly ClassificationTypeDefinition
		Definition_Directive_Pragma_Region_Friends;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Directive.Pragma.Region.Components")]
		private static readonly ClassificationTypeDefinition
		Definition_Directive_Pragma_Region_Components;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Directive.Pragma.Region.Concepts")]
		private static readonly ClassificationTypeDefinition
		Definition_Directive_Pragma_Region_Concepts;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Directive.Pragma.Region.Classes")]
		private static readonly ClassificationTypeDefinition
		Definition_Directive_Pragma_Region_Classes;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Directive.Pragma.Region.Structs")]
		private static readonly ClassificationTypeDefinition
		Definition_Directive_Pragma_Region_Structs;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Directive.Pragma.Region.Unions")]
		private static readonly ClassificationTypeDefinition
		Definition_Directive_Pragma_Region_Unions;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Directive.Pragma.Region.Properties")]
		private static readonly ClassificationTypeDefinition
		Definition_Directive_Pragma_Region_Properties;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Directive.Pragma.Region.Members")]
		private static readonly ClassificationTypeDefinition
		Definition_Directive_Pragma_Region_Members;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Directive.Pragma.Region.Fields")]
		private static readonly ClassificationTypeDefinition
		Definition_Directive_Pragma_Region_Fields;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Directive.Pragma.Region.Enums")]
		private static readonly ClassificationTypeDefinition
		Definition_Directive_Pragma_Region_Enums;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Directive.Pragma.Region.Delegates")]
		private static readonly ClassificationTypeDefinition
		Definition_Directive_Pragma_Region_Delegates;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Directive.Pragma.Region.Specials")]
		private static readonly ClassificationTypeDefinition
		Definition_Directive_Pragma_Region_Specials;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Directive.Pragma.Region.Constructors")]
		private static readonly ClassificationTypeDefinition
		Definition_Directive_Pragma_Region_Constructors;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Directive.Pragma.Region.Overrides")]
		private static readonly ClassificationTypeDefinition
		Definition_Directive_Pragma_Region_Overrides;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Directive.Pragma.Region.Methods")]
		private static readonly ClassificationTypeDefinition
		Definition_Directive_Pragma_Region_Methods;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Directive.Pragma.Region.Getters")]
		private static readonly ClassificationTypeDefinition
		Definition_Directive_Pragma_Region_Getters;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Directive.Pragma.Region.Setters")]
		private static readonly ClassificationTypeDefinition
		Definition_Directive_Pragma_Region_Setters;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Directive.Pragma.Region.Operators")]
		private static readonly ClassificationTypeDefinition
		Definition_Directive_Pragma_Region_Operators;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Directive.Pragma.Region.Conversions")]
		private static readonly ClassificationTypeDefinition
		Definition_Directive_Pragma_Region_Conversions;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Directive.Pragma.Region.Functions")]
		private static readonly ClassificationTypeDefinition
		Definition_Directive_Pragma_Region_Functions;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Directive.Pragma.Region.Events")]
		private static readonly ClassificationTypeDefinition
		Definition_Directive_Pragma_Region_Events;

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

		#pragma warning restore IDE0051
		#pragma warning restore 169
	}
}
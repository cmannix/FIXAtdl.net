﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Atdl4net.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class ErrorMessages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ErrorMessages() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Atdl4net.Resources.ErrorMessages", typeof(ErrorMessages).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to It was not possible to add the item &apos;{0}&apos; to the collection {1} as an item with the same key had already been added..
        /// </summary>
        internal static string AttemptToAddDuplicateKey {
            get {
                return ResourceManager.GetString("AttemptToAddDuplicateKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to It is not possible to change this field as it is set to a constant value ({0})..
        /// </summary>
        internal static string AttemptToSetConstValueParameter {
            get {
                return ResourceManager.GetString("AttemptToSetConstValueParameter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Both Edit and EditRef were supplied for this {0}; only one may be supplied..
        /// </summary>
        internal static string BothEditAndEditRefSetOnObject {
            get {
                return ResourceManager.GetString("BothEditAndEditRefSetOnObject", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Comparison of &apos;{0}&apos; and &apos;{1}&apos; was not possible as no valid conversion between the two types was found..
        /// </summary>
        internal static string CompareValueFailure {
            get {
                return ResourceManager.GetString("CompareValueFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value &apos;{0}&apos; could not be converted to a valid value of type {1}..
        /// </summary>
        internal static string DataConversionError1 {
            get {
                return ResourceManager.GetString("DataConversionError1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value &apos;{0}&apos; could not be converted to a valid value of type {1} as is required for the field {2}..
        /// </summary>
        internal static string DataConversionError2 {
            get {
                return ResourceManager.GetString("DataConversionError2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This value cannot be converted into a valid {0}..
        /// </summary>
        internal static string DataConversionFailure {
            get {
                return ResourceManager.GetString("DataConversionFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No parameter with name or control with Id &apos;{0}&apos; was found for EditRef {1} value..
        /// </summary>
        internal static string EditRefFieldControlNotFound {
            get {
                return ResourceManager.GetString("EditRefFieldControlNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The EditRef with Id &apos;{0}&apos; could not be found..
        /// </summary>
        internal static string EditRefResolutionFailure {
            get {
                return ResourceManager.GetString("EditRefResolutionFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred setting the value of an enumerated field; &apos;{0}&apos; is not a valid enumeration value for this field..
        /// </summary>
        internal static string EnumerationNotFound {
            get {
                return ResourceManager.GetString("EnumerationNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Both checkedEnumRef and uncheckedEnumRef must be set on CheckBox_t and RadioButton_t when populating non-Boolean parameter..
        /// </summary>
        internal static string EnumRefNotSetOnBooleanControl {
            get {
                return ResourceManager.GetString("EnumRefNotSetOnBooleanControl", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred processing the element: {0}
        ///{1}.
        /// </summary>
        internal static string GeneralElementProcessingError {
            get {
                return ResourceManager.GetString("GeneralElementProcessingError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A null reference was passed to this method in error; a valid reference is required..
        /// </summary>
        internal static string IllegalUseOfNullError {
            get {
                return ResourceManager.GetString("IllegalUseOfNullError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An inconsistency was found setting or retrieving an enumerated value, most likely caused by a mismatch between the ListItems for a control and the EnumPairs for the control&apos;s parameter..
        /// </summary>
        internal static string InconsistentEnumPairsListItemsError {
            get {
                return ResourceManager.GetString("InconsistentEnumPairsListItemsError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to It was not possible to initialise the value of the control with ID &apos;{0}&apos; due to the following error:
        ///	{1}.
        /// </summary>
        internal static string InitControlValueError {
            get {
                return ResourceManager.GetString("InitControlValueError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to It was not possible to add the Country &apos;{0}&apos; to the Region &apos;{1}&apos; as the supplied country is not a part of this region..
        /// </summary>
        internal static string InvalidAttemptToAddCountryToRegion {
            get {
                return ResourceManager.GetString("InvalidAttemptToAddCountryToRegion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value supplied, &apos;{0}&apos; for this boolean field is invalid; valid values are &apos;{1}&apos; and &apos;{2}&apos;..
        /// </summary>
        internal static string InvalidBooleanValue {
            get {
                return ResourceManager.GetString("InvalidBooleanValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value supplied, &apos;{0}&apos; for this char field is invalid; it must be exactly one character in length..
        /// </summary>
        internal static string InvalidCharValue {
            get {
                return ResourceManager.GetString("InvalidCharValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value supplied for this field is not a valid value..
        /// </summary>
        internal static string InvalidControlValueError {
            get {
                return ResourceManager.GetString("InvalidControlValueError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value supplied, &apos;{0}&apos;, for this date or time field could not be interpreted as a valid date or time..
        /// </summary>
        internal static string InvalidDateOrTimeValue {
            get {
                return ResourceManager.GetString("InvalidDateOrTimeValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value supplied for this date or time field could not be interpreted as a valid date or time..
        /// </summary>
        internal static string InvalidDateOrTimeValueUnknown {
            get {
                return ResourceManager.GetString("InvalidDateOrTimeValueUnknown", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Exchange codes must conform to the ISO 10383 standard, i.e., be 4 characters in length.
        /// </summary>
        internal static string InvalidExchangeCode {
            get {
                return ResourceManager.GetString("InvalidExchangeCode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The timestamp supplied, &apos;{0}&apos;, was not in a valid format..
        /// </summary>
        internal static string InvalidFIXTimeFormat {
            get {
                return ResourceManager.GetString("InvalidFIXTimeFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Parameter {0} may not be set to value {1}; reason: {2}.
        /// </summary>
        internal static string InvalidGetParameterValue {
            get {
                return ResourceManager.GetString("InvalidGetParameterValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value supplied, &apos;{0}&apos;, for this month-year field is invalid; valid formats are YYYYMM, YYYYMMDD and YYYYMMWW..
        /// </summary>
        internal static string InvalidMonthYearValue {
            get {
                return ResourceManager.GetString("InvalidMonthYearValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An empty string or null value is not a valid value for this field..
        /// </summary>
        internal static string InvalidNullOrEmptyStringValue {
            get {
                return ResourceManager.GetString("InvalidNullOrEmptyStringValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value supplied, &apos;{0}&apos;, for this numeric field could not be converted into a number..
        /// </summary>
        internal static string InvalidNumericValue {
            get {
                return ResourceManager.GetString("InvalidNumericValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to set parameter {0} to value {1} failed with error: {2}.
        /// </summary>
        internal static string InvalidParameterSetValue {
            get {
                return ResourceManager.GetString("InvalidParameterSetValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value supplied, &apos;{0}&apos;, for this tenor field is invalid; valid formats are Dn, Wn, Mn and Yn, where n is any non-zero positive integer..
        /// </summary>
        internal static string InvalidTenorValue {
            get {
                return ResourceManager.GetString("InvalidTenorValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value &apos;{0}&apos; cannot be converted to a value of the enumerated type {1} as it is not a valid value for this type..
        /// </summary>
        internal static string InvalidValueEnumParseFailure {
            get {
                return ResourceManager.GetString("InvalidValueEnumParseFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value supplied for this field, &apos;{0}&apos;, is longer than the maximum length allowed ({1})..
        /// </summary>
        internal static string MaxLengthExceeded {
            get {
                return ResourceManager.GetString("MaxLengthExceeded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value supplied for this field, {0}, is greater than the maximum value allowed ({1})..
        /// </summary>
        internal static string MaxValueExceeded {
            get {
                return ResourceManager.GetString("MaxValueExceeded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value supplied for this field, &apos;{0}&apos;, is shorter than the minimum length allowed ({1})..
        /// </summary>
        internal static string MinLengthExceeded {
            get {
                return ResourceManager.GetString("MinLengthExceeded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value supplied for this field, {0}, is less than the minimum value allowed ({1})..
        /// </summary>
        internal static string MinValueExceeded {
            get {
                return ResourceManager.GetString("MinValueExceeded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to It is not possible to evaluate the supplied set of Edits as the LogicalOperator is missing..
        /// </summary>
        internal static string MissingLogicalOperatorOnSetOfEdits {
            get {
                return ResourceManager.GetString("MissingLogicalOperatorOnSetOfEdits", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The mandatory attribute {0} was not supplied for the element type  {1}..
        /// </summary>
        internal static string MissingMandatoryAttribute {
            get {
                return ResourceManager.GetString("MissingMandatoryAttribute", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Either an Operator or a LogicalOperator must be supplied in order to evaluate an Edit..
        /// </summary>
        internal static string MissingOperatorsOnEdit {
            get {
                return ResourceManager.GetString("MissingOperatorsOnEdit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No valid Edit or EditRef was supplied for this {0}..
        /// </summary>
        internal static string NeitherEditNorEditRefSetOnObject {
            get {
                return ResourceManager.GetString("NeitherEditNorEditRefSetOnObject", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value supplied for this field, {0}, is invalid as this field can only contain integer values of greater than or equal to zero..
        /// </summary>
        internal static string NonNegativeIntRequired {
            get {
                return ResourceManager.GetString("NonNegativeIntRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A valid value must be supplied for the parameter &apos;{0}&apos;; this parameter is not optional..
        /// </summary>
        internal static string NonOptionalParameterNotSupplied {
            get {
                return ResourceManager.GetString("NonOptionalParameterNotSupplied", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This field is not optional; a valid value must be supplied..
        /// </summary>
        internal static string NonOptionalParameterNotSupplied2 {
            get {
                return ResourceManager.GetString("NonOptionalParameterNotSupplied2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value supplied for this field, {0}, is invalid as this field can only contain integer values greater than zero..
        /// </summary>
        internal static string NonZeroPositiveIntRequired {
            get {
                return ResourceManager.GetString("NonZeroPositiveIntRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to It is not possible to render this strategy as no StrategyLayout information has been supplied for this strategy..
        /// </summary>
        internal static string NoStrategyLayoutSupplied {
            get {
                return ResourceManager.GetString("NoStrategyLayoutSupplied", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to It is not possible to render this strategy as no StrategyPanels are present in this strategy..
        /// </summary>
        internal static string NoStrategyPanelsInStrategy {
            get {
                return ResourceManager.GetString("NoStrategyPanelsInStrategy", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The current operation cannot be completed as no strategy has been selected..
        /// </summary>
        internal static string NoStrategySelectedError {
            get {
                return ResourceManager.GetString("NoStrategySelectedError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An empty string or null value cannot be converted to a value of the enumerated type {0}..
        /// </summary>
        internal static string NullOrEmptyStringEnumParseFailure {
            get {
                return ResourceManager.GetString("NullOrEmptyStringEnumParseFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to One or more controls have invalid values..
        /// </summary>
        internal static string OneOrMoreInvalidControlValues {
            get {
                return ResourceManager.GetString("OneOrMoreInvalidControlValues", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to It was not possible to add the Parameter &apos;{0}&apos; due to the following error:
        ///	{1}.
        /// </summary>
        internal static string ParameterAddFailure {
            get {
                return ResourceManager.GetString("ParameterAddFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The property {0} is not a valid property for objects of type {1}..
        /// </summary>
        internal static string PropertyNotFoundOnObject {
            get {
                return ResourceManager.GetString("PropertyNotFoundOnObject", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to It was not possible to load the supplied FIXatdl content as &apos;Strategies&apos; is not the root element..
        /// </summary>
        internal static string StrategiesLoadFailure {
            get {
                return ResourceManager.GetString("StrategiesLoadFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to It was not possible to load the Strategy &apos;{0}&apos; due to the following error:
        ///	{1}.
        /// </summary>
        internal static string StrategyLoadFailure {
            get {
                return ResourceManager.GetString("StrategyLoadFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to It was not possible to invoke {0} due to the following error:
        ///	{1}.
        /// </summary>
        internal static string UnableToInvokeMethodError {
            get {
                return ResourceManager.GetString("UnableToInvokeMethodError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to It was not possible to parse the supplied FIX message as it was empty..
        /// </summary>
        internal static string UnableToParseFixMessageEmpty {
            get {
                return ResourceManager.GetString("UnableToParseFixMessageEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to It was not possible to parse the supplied message due to unexpected token in message &apos;{0}&apos;..
        /// </summary>
        internal static string UnableToParseFixMessageInvalidContent {
            get {
                return ResourceManager.GetString("UnableToParseFixMessageInvalidContent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to It was not possible to parse the supplied FIX message tag ({0}={1}); reason: {2}.
        /// </summary>
        internal static string UnableToParseFixMessageInvalidFormat {
            get {
                return ResourceManager.GetString("UnableToParseFixMessageInvalidFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No match was found for the value &apos;{0}&apos; in the EnumPairs/ListItems for this parameter..
        /// </summary>
        internal static string UnrecognisedEnumIdValue {
            get {
                return ResourceManager.GetString("UnrecognisedEnumIdValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The type &apos;{0}&apos; specified in the attribute {1} for the element {2} was not recognised as a valid FIXatdl type..
        /// </summary>
        internal static string UnrecognisedTypeError {
            get {
                return ResourceManager.GetString("UnrecognisedTypeError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The parameter &apos;{0}&apos; was not found in the parameters for this strategy..
        /// </summary>
        internal static string UnresolvedParameterRefError {
            get {
                return ResourceManager.GetString("UnresolvedParameterRefError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Attempt to set parameter {0} from control {1} failed with error: {2}.
        /// </summary>
        internal static string UnsuccessfulSetParameterOperation {
            get {
                return ResourceManager.GetString("UnsuccessfulSetParameterOperation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value supplied, &apos;{0}&apos;, cannot be compared with &apos;{1}&apos; because this type of comparison is not supported..
        /// </summary>
        internal static string UnsupportedComparisonOperation {
            get {
                return ResourceManager.GetString("UnsupportedComparisonOperation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The conversion of the value &apos;{0}&apos; to the type {1} is not supported.  This relates to the {2} control..
        /// </summary>
        internal static string UnsupportedControlValueConversion {
            get {
                return ResourceManager.GetString("UnsupportedControlValueConversion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The conversion of the parameter value &apos;{0}&apos; to the type {1} is not supported..
        /// </summary>
        internal static string UnsupportedParameterValueConversion {
            get {
                return ResourceManager.GetString("UnsupportedParameterValueConversion", resourceCulture);
            }
        }
    }
}

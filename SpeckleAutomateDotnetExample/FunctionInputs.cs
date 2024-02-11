using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

/// <summary>
/// This class describes the user specified variables that the function wants to work with.
/// </summary>
/// This class is used to generate a JSON Schema to ensure that the user provided values
/// are valid and match the required schema.
struct FunctionInputs
{
    [Required]
    public string SpeckleTypeToCount {get; set;}

    [Secret]
    [Required(AllowEmptyStrings = true)]
    public string WhisperMessage;

    [Editable(allowEdit:false)] // Example of how to make a property read-only.
    public string ReadOnly { get; set; } 

    [DisplayName("Specific Input Title")]
    [Description("This is a description for the example input.")]
    public string DecoratedInput { get; set; } // Attributes applied here are valid since this is a property.
}


[AttributeUsage(AttributeTargets.Field)]
public class SecretAttribute : Attribute
{
    // This is a marker attribute and doesn't need any additional logic
}
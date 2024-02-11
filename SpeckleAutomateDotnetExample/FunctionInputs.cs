using System.ComponentModel.DataAnnotations;
using System.ComponentModel

/// <summary>
/// This class describes the user specified variables that the function wants to work with.
/// </summary>
/// This class is used to generate a JSON Schema to ensure that the user provided values
/// are valid and match the required schema.
struct FunctionInputs
{
  [Required]
  public string SpeckleTypeToCount;

  [Secret]
  public string WhisperMessage;

  [Editable(false)]
	public string ReadOnly; // A disabled text input field

	[DisplayName("Specific Input Title")]
	[Description("This is a description for the example input.")]
	public string DecoratedInput {get; set;} // A range of Attributes applied.

}


[AttributeUsage(AttributeTargets.Field)]
public class SecretAttribute : Attribute
{
    // This is a marker attribute and doesn't need any additional logic
}
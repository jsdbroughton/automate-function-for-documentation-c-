using System.ComponentModel.DataAnnotations;

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

}


[AttributeUsage(AttributeTargets.Field)]
public class SecretAttribute : Attribute
{
    // This is a marker attribute and doesn't need any additional logic
}
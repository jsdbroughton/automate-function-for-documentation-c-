using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

/// <summary>
/// This class describes the user specified variables that the function wants to work with.
/// </summary>
/// This class is used to generate a JSON Schema to ensure that the user provided values
/// are valid and match the required schema.
struct FunctionInputs
{
    public string SpeckleTypeToCount;
    public string? OptionalText; // A non required field

    public int? ExpectedMinimumValue {get; set;}

    [Range(0.0, 100.0)]
  	public double ScalarValue; // A float variable between 0 and 100

    public FunctionInputs()
    {
        ScalarValue = 3.5;
        SpeckleTypeToCount = "";
        OptionalText = null; // Explicitly setting the default, though this is optional since it's already the default for nullable reference types
        ExpectedMinimumValue = 10;
    }

}


[AttributeUsage(AttributeTargets.Field)]
public class SecretAttribute : Attribute
{
    // This is a marker attribute and doesn't need any additional logic
}
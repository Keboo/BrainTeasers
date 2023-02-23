namespace BrainTeasers;

public class GetValuesTests
{
    [Fact]
    public void When_parameter_is_null_it_does_not_throw()
    {
        Numbers.GetValues(null!);
        // Test Passes!
    }
}

public static class Numbers
{
    public static IEnumerable<int> GetValues(int? startingValue)
    {
        _ = startingValue ?? throw new ArgumentNullException(nameof(startingValue));
        // Implement this method me to make the test pass
        //Do NOT edit anything above this line.

        //The invocation of an iterator method does not occur immediately.
        //By using the yield statement, this method becomes an iterator method.
        //https://learn.microsoft.com/dotnet/csharp/language-reference/statements/yield#execution-of-an-iterator
        yield break;
    }

    //NB: A properly implemented iterator method, with pre-condition checks should be implemented in two parts.
    // The outer method to do the pre-condition checks that occur immediately when the method is invoked.
    // An inner (or second) method that is the actual iterator method for providing the values
    public static IEnumerable<int> CorrectGetValues(int? startingValue)
    {
        //Pre-condition check
        _ = startingValue ?? throw new ArgumentNullException(nameof(startingValue));

        //Invoke iterator method
        return CorrectGetValuesImplementation(startingValue.Value);

        //Iterator method
        static IEnumerable<int> CorrectGetValuesImplementation(int startingValue)
        {
            //TODO: Some implementation here
            yield break;
        }
    }
}

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
        return Enumerable.Empty<int>();
    }
}

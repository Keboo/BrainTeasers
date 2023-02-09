namespace BrainTeasers;

//Spot the bug: The following code throws an exception
//What exception is thrown and why?
public class ValueHolder
{
    private Dictionary<string, object> Values { get; } = new();
    
    public ValueHolder()
    {
        Values["1"] = "default";
        Values["2"] = -1;
        Values["3"] = DateTime.MinValue;
    }

    public string GetString() => (string)Values["1"];
    /// <summary>
    /// When this method was casting to decimal it was throwing and InvalidCastException.
    /// Because the dictionary is storing values as object, the integer value is boxed when it is stored in the dictionary.
    /// When unboxing, the exception is thrown because the stored value type (int) is not the same as the requested type (decimal).
    /// More on boxing: https://docs.microsoft.com/dotnet/csharp/programming-guide/types/boxing-and-unboxing
    /// </summary>
    public int GetNumber() => (int)Values["2"];
    public DateTime GetDateTime() => (DateTime)Values["3"];
}

public class Tests
{
    [Fact]
    public void GetString_ReturnsValue()
    {
        ValueHolder valueHolder = new();

        Assert.Equal("default", valueHolder.GetString());
    }

    [Fact]
    public void GetNumber_ReturnsValue()
    {
        ValueHolder valueHolder = new();

        Assert.Equal(-1, valueHolder.GetNumber());
    }

    [Fact]
    public void GetDateTime_ReturnsValue()
    {
        ValueHolder valueHolder = new();

        Assert.Equal(DateTime.MinValue, valueHolder.GetDateTime());
    }
}

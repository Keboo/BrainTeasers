# Hint 1

The following unit tests will demonstate the failure case with `ValueHolder`.
Two of these tests will pass, but one will fail.

```C#
namespace BrainTeasers;

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
```
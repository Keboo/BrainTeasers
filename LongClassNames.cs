namespace BrainTeasers;

public class LongClassNames
{
    [Fact]
    public void Type_had_a_really_long_name()
    {
        //Declare class Foo such that the this test passes
        Assert.True(typeof(Foo).Name.Length > 42);
    }
}
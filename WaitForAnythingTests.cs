namespace BrainTeasers;

public class WaitForAnythingTests
{
    [Fact]
    public async Task MakeMeWork()
    {
        //Make this test compile pass
        //without modifying this test in any way
        var @object = new object();
        string name = await @object;
        Assert.Equal("OhNoNoNo", name);
    }
}
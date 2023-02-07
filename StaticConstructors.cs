namespace BrainTeasers;

public class StaticConstructors
{
    private static int _refCount;

    [Fact]
    public void CallsStaticConstructorTwice()
    {
        //TODO: Write code that makes the following assertion pass
        Assert.Equal(2, _refCount);
    }

    private class InstanceCounter
    {
        static InstanceCounter()
        {
            _refCount++;
        }
    }
}
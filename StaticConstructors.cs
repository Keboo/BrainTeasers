namespace BrainTeasers;

public class StaticConstructors
{
    private static int _refCount;

    [Fact]
    public void CallsStaticConstructorTwice()
    {
        _ = new First();
        _ = new Second();
        
        Assert.Equal(2, _refCount);
    }

    private class InstanceCounter<T>
    {
        static InstanceCounter()
        {
            _refCount++;
        }
    }

    private class First : InstanceCounter<int> { }
    private class Second : InstanceCounter<string> { }
}
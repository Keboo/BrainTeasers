using System.Runtime.CompilerServices;

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



static class AsyncObjectExtensions
{
    //Any type can be awaited if it implements a GetAwaiter method whose return type meets some criteria
    // - It must implement INotifyCompletion, which means it must have an OnCompleted(Action) method
    // - It must have a property IsCompleted of type bool
    // - It must have a method GetResult() that returns the result of the async operation
    //
    //For an amazing writing of all of the details of async/await, I highly recommend Stephen Toub's blog
    //https://devblogs.microsoft.com/dotnet/how-async-await-really-works/
    public static TaskAwaiter GetAwaiter(this object _) => new();

    public class TaskAwaiter : INotifyCompletion
    {
        public bool IsCompleted { get; set; } = true;

        public void OnCompleted(Action continuation)
            => throw new NotImplementedException();

        public string GetResult() => "OhNoNoNo";
    }
}
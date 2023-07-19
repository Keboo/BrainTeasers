using System.Runtime.CompilerServices;

namespace BrainTeasers;

public static class LazyExtensions
{
    public static TaskAwaiter<T> GetAwaiter<T>(this Lazy<Task<T>> lazy)
    {
        return lazy.Value.GetAwaiter();
    }
}
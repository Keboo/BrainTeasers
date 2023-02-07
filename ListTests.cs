namespace BrainTeasers;

public class ListTests
{
    [Fact]
    public void GetNextItem_ThrowsException()
    {
        List<string> list = new(0);
        int currentIndex = 0;
        Assert.Throws<DivideByZeroException>(() => GetNextItem(list, currentIndex));
    }
    
    public static string? GetNextItem(List<string>? list, int currentIndex)
    {
        if (list is { } l && currentIndex >= 0)
        {
            //Bug: modulus operator will throw if the second operand is zero (which occurs when the list is empty).
            return l[(currentIndex + 1) % l.Count];
        }
        return null;
    }

    [Fact]
    public void GetNextItemFixed_WithEmptyList_ReturnsNull()
    {
        List<string> list = new(0);
        int currentIndex = 0;
        Assert.Null(GetNextItemFixed(list, currentIndex));
    }

    public static string? GetNextItemFixed(List<string>? list, int currentIndex)
    {
        //Fix: rather than using an empty property pattern match,
        //also check that there is at least one item in the list by pattern matching
        //on the Count property as well.
        //https://learn.microsoft.com/dotnet/csharp/language-reference/operators/patterns#property-pattern
        if (list is { Count: > 0 } l && currentIndex >= 0)
        {
            return l[(currentIndex + 1) % l.Count];
        }
        return null;
    }
}
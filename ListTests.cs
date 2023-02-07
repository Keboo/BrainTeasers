namespace BrainTeasers;

public class ListTests
{
    [Fact]
    public void GetNextItem_ThrowsException()
    {
        /*
        List<string> list = ...;
        int currentIndex = ...;
        Assert.Throws<Exception>(() => GetNextItem(list, currentIndex))
        */
    }

    //Spot the bug: under what conditions will this method throw an exception?
    public static string? GetNextItem(List<string>? list, int currentIndex)
    {
        if (list is { } l && currentIndex >= 0)
        {
            return l[(currentIndex + 1) % l.Count];
        }
        return null;
    }
}
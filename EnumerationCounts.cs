namespace BrainTeasers;

public class EnumerationCounts
{
    [Fact]
    public void WhatIsTheValueOfCount()
    {
        IEnumerable<int> numbers = GetNumbers();

        //Increments _count by 1. .Any() returns after a single call to the enumerator MoveNext method.
        //Effectively after a single item is returned.
        Assert.True(numbers.Any());

        //Increments _count by 2. .First() will stop iterating after it finds a matching item.
        //So it stops at the yield return 2; statement.
        int firstEvenNumber = numbers.First(x => x % 2 == 0);
        Assert.Equal(2, firstEvenNumber);

        //Increments _count by 3. .Skip(1) simply ignores the first item, but still causes the enumerator to move forward past it.
        //Unlike .First(), Single() must keep iterating to know if there is more than one matching item. So it iterates to the end.
        int two = numbers.Skip(1).Single(x => x == 2);
        Assert.Equal(2, two);

        //Increments _count by 3. .TakeLast(2) must iterate to the end to know what the last two items are.
        IEnumerable<int> lastTwoNumbers = numbers.TakeLast(2);
        Assert.Equal(new[] { 2, 3 }, lastTwoNumbers);

        //What is the value of _count at this point?
        //1 + 2 + 3 + 3 = 9
        Assert.Equal(9, _count);
    }

    private int _count;

    public IEnumerable<int> GetNumbers()
    {
        _count++;
        yield return 1;
        _count++;
        yield return 2;
        _count++;
        yield return 3;
    }
}
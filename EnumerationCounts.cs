namespace BrainTeasers;

public class EnumerationCounts
{
    [Fact]
    public void WhatIsTheValueOfCount()
    {
        IEnumerable<int> numbers = GetNumbers();

        Assert.True(numbers.Any());

        int firstEvenNumber = numbers.First(x => x % 2 == 0);
        Assert.Equal(2, firstEvenNumber);

        int two = numbers.Skip(1).Single(x => x == 2);
        Assert.Equal(2, two);

        IEnumerable<int> lastTwoNumbers = numbers.TakeLast(2);
        Assert.Equal(new[] { 2, 3 }, lastTwoNumbers);

        //What is the value of _count at this point?
        //Assert.Equal(??, _count);
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
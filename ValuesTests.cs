namespace BrainTeasers;

public class ValuesTests
{
    [Fact]
    public void What_does_this_add_up_to()
    {
        int sum = 0;
        sum += GetValue(Values.Fizz);
        sum += GetValue(Values.Fizz | Values.Buzz);
        sum += GetValue(Values.FizzBuzz);
        sum += GetValue(Values.Unknown);
        sum += GetValue(Values.Buzz);

        //What is the value of 'sum'?
        //Why is that the correct value?
        //Assert.Equal(???, sum);
    }

    [Flags]
    public enum Values
    {
        Unknown = -1,
        None = 0,
        Fizz = 1,
        Buzz = 2,
        FizzBuzz = 4
    }

    public static int GetValue(Values values)
    {
        if (values.HasFlag(Values.Buzz)) return 2;
        if (values.HasFlag(Values.Fizz)) return 1;
        return 0;
    }
}
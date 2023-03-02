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

        //We add 1 from the call GetValue(Values.Fizz)
        //We add 2 from the call GetValue(Values.Fizz | Values.Buzz)
        //We add 0 from the call GetValue(Values.FizzBuzz)
        //We add 2 from the call GetValue(Values.Unknown)
        //We add 2 from the call GetValue(Values.Buzz)
        //1 + 2 + 0 + 2 + 2 = 7
        Assert.Equal(7, sum);

        /*
         * The FizzBuzz value returns 0 because, despite being [inappropriately] named FizzBuzz, it does not have the Fizz or Buzz flags enabled.
         * So the HasFlag method returns false when checking for both the Fizz and Buzz flags.
         * 
         * To understand why Unknown returns 2, we need to look at the binary representation of the enum values.
         * The binary representation of the enum values are:
         * Unknown  = 1111
         * None     = 0000
         * Fizz     = 0001
         * Buzz     = 0010
         * FizzBuzz = 0100
         * 
         * The values above only show the lower four bits (since these are all that are relevant for the Fizz and Buzz flags),
         * but the enum values each have 32 bits since the backing type of the enum is Int32.
         * 
         * The reason that Unknown has its lower 4 bits set to 1 (and in fact all 32 bits set to 1) is because of how negative numbers are stored in binary.
         * It uses the two's complement representation. The two's complement representation is a way of representing negative numbers in binary.
         * You can read more about that here: https://wikipedia.org/wiki/Two%27s_complement.
         * Because those bits are set to 1, the HasFlag method will return true when checking if the Buzz flag (the second bit) is enabled.
         * 
         * More guidance on properly designing these flagged enums can be found here: https://learn.microsoft.com/dotnet/standard/design-guidelines/
         */
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
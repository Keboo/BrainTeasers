namespace BrainTeasers;

public class ByteTests
{
    public static IEnumerable<byte> GetBytes()
    {
        for(byte b = 0; b <= byte.MaxValue; b++)
        {
            yield return b;
        }
    }

    [Fact]
    public void XorTheBytesTogether()
    {
        var allTheBits = GetBytes().Aggregate(255, (a, b) => a ^ b);
        //What is the behavior of this test?
    }
}
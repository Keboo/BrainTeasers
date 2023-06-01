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

    public static IEnumerable<byte> GetBytesFixed()
    {
        for (byte b = 0; b < byte.MaxValue; b++)
        {
            yield return b;
        }
    }

    [Fact]
    public void XorTheBytesTogether()
    {
        //This version of the code never finishes because adding one to byte.MaxValue overflows the byte
        //and results in b going back to zero. The fixed version properly stops at byte.MaxValue
        //var allTheBits = GetBytes().Aggregate(255, (a, b) => a ^ b);

        var allTheBits = GetBytesFixed().Aggregate(255, (a, b) => a ^ b);
        
        //We can figure out the behavior of xor-ing all of the bit by simply looking at an example with just 3 bits
        //000 ^ 001 = 001
        //001 ^ 010 = 011
        //011 ^ 011 = 000
        //000 ^ 100 = 100
        //100 ^ 101 = 001
        //001 ^ 110 = 111
        //111 ^ 111 = 000
        //For the pattern we can see that every multiple of 3 will result in 0.
        //Since 255 is a multiple of 3, the value will be zero.
        
        Assert.Equal(0, allTheBits);
    }
}
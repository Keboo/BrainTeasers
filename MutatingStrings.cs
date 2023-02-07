namespace BrainTeasers;

public class MutatingStrings
{
    [Fact]
    public void MutateTheImmutable()
    {
        const string WhoAmI = "Kevin";
        Assert.Equal("Kevin", WhoAmI);

        CauseIdentityCrisis(WhoAmI);

        Assert.Equal("Grant", WhoAmI);
    }

    private static void CauseIdentityCrisis(string whoAmI)
    {
        string target = "Grant";

        // obtain pointer and iterate with replacing
        unsafe
        {
            fixed (char* ptr = whoAmI)
            {
                for (int i = 0; i < whoAmI.Length; i++)
                {
                    ptr[i] = target[i];
                }
            }
        }
    }
}
namespace BrainTeasers;

public class MutatingStrings
{
    [Fact]
    public void MutateTheImmutable()
    {
        const string WhoAmI = "Kevin";
        Assert.Equal("Kevin", WhoAmI);

        CauseIdentityCrisis();

        Assert.Equal("Kelly", WhoAmI);
    }

    private static void CauseIdentityCrisis()
    {
        // Rely on string interning: "Kelly" here will be the same object as "Kelly" in MutateTheUnnamed().
        // CLR of .NET 4.5+ will intern string literals when assembly is loaded into AppDomain.
        // In previous versions we should use string.Intern("Kelly") to be sure of valid reference.

        //string whoAmI = string.Intern("Kelly");
        const string target = "Kelly";
        const string whoAmI = "Kevin";

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
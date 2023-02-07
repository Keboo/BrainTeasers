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
        //TODO: Implement method
    }
}
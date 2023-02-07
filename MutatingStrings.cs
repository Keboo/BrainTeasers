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
        //TODO: Implement method
    }
}
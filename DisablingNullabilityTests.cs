using System.Runtime.CompilerServices;

namespace BrainTeasers;

public class DisablingNullabilityTests
{
    [Fact]
    public async Task ForcingNullIntoTheNonNullable()
    {
        Lazy<Task<string?>> getValue = new(() => Task.FromResult<string?>(null));
        string? value = await getValue;
        Assert.Throws<ArgumentNullException>(() => TestForNull(value));

        void TestForNull(string notNull)
        {
            ArgumentNullException.ThrowIfNull(notNull);
        }
    }
}
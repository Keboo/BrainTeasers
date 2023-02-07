# Mutating Strings - Part 2

[YouTube](https://youtu.be/M7MaSFB-5zk)

# Required setup
.NET 7

# Instructions
Within C# [strings are immutable](https://learn.microsoft.com/dotnet/csharp/programming-guide/strings/#immutability-of-strings). This brain teaser explores way to mutate these, typically immutable, objects.

There is a single `MutatingStrings` class that contains a `CauseIdentityCrisis` method as well as a single unit test.
Implement the `CauseIdentityCrisis` such that the unit test passes. Though you can certainly add additional methods, the solution does not require any changes outside of the `CauseIdentityCrisis` method.

In part 1, we simply mutated the string that was passed to this `CauseIdentityCrisis` method. Do not change the signature of this method. Do not add any additional fields, properties, or types. The only changes should be within the `CauseIdentityCrisis` method.

# Solution
`git switch mutating-strings-part2-solution`

## Addendums
- *None*
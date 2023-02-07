# Multiple invocations of static constructors

[YouTube](https://youtu.be/9nFOVvn5cQU)

# Required setup
.NET 7

# Instructions
[Static constructors](https://learn.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/static-constructors) in C# are designed to initialize static data. It is typically only invoked once.

This brain teaser aims to explore cases where a static constructor is invoked multiple times.
In this project there is a single `StaticConstructors` unit test class. It contains a private [nested class](https://learn.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/nested-types) (`InstanceCounter`) with a static constructor. This static constructor increments a static field `_refCount`.
You can make whatever changes are necessary to the `InstanceCounter` class. Do not manipulate the `_refCount` field. It should only be incremented from within the `InstanceCounter`'s static constructor.
The goal is to make the `CallsStaticConstructorTwice` unit test pass.

# Solution
`git switch multiple-static-constructors-solution`

## Addendums
- *None*
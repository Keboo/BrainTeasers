namespace BrainTeasers;

//This is part of Solution 2
//using Foo = Foo1234567890123456789012345678901234567890;

public class LongClassNames
{
    [Fact]
    public void Type_had_a_really_long_name()
    {
        //Declare class Foo such that the this test passes
        Assert.True(typeof(Foo).Name.Length > 42);
    }
}
//Solution 1: Requires C# 11 or later
//File-scope types have a long compiler generated name that includes a hash of the type
// https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/file
file class Foo { }


//Solution 2
//Declare a really long type name then use a using directive to alias it to Foo.
//You also need to uncomment the using directive at the top of the file.
//https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/using-directive
//public class Foo1234567890123456789012345678901234567890 { }

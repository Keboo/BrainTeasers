# Hint 2

`Enum.HasFlag` ([docs](https://learn.microsoft.com/dotnet/api/system.enum.hasflag)) uses bitwise-operators to check if a flag is set. If you don't know what bitwise-operators are, you can read about them [here](https://learn.microsoft.com/dotnet/csharp/language-reference/operators/bitwise-and-shift-operators). The value of on `Unknown` is a bit unique because of [how negative numbers](https://wikipedia.org/wiki/Two%27s_complement) are represented in binary.
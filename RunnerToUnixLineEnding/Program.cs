// variables names: ok
using SunamoToUnixLineEnding.Tests;

namespace RunnerToUnixLineEnding;

internal class Program
{
    static void Main()
    {
        LoadingFromFileTests t = new();
        t.DoTest();
    }
}

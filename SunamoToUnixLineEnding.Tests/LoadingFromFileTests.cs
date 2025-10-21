// EN: Variable names have been checked and replaced with self-descriptive names
// CZ: Názvy proměnných byly zkontrolovány a nahrazeny samopopisnými názvy

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunamoToUnixLineEnding.Tests;
public class LoadingFromFileTests
{
    public void DoTest()
    {
        var bp = @"D:\_Test\PlatformIndependentNuGetPackages\SunamoToUnixLineEnding\";
        var name = bp + @"name.txt";
        var rn = bp + @"rn.txt";

        List<string> list = ["a", "c"];
        File.WriteAllText(name, string.Join("\n", list));
        File.WriteAllText(rn, string.Join("\r\n", list));

        var n2 = File.ReadAllLines(name);
        var rn2 = File.ReadAllLines(rn);

        var n3 = File.ReadAllText(name);
        var rn3 = File.ReadAllText(rn);
    }
}

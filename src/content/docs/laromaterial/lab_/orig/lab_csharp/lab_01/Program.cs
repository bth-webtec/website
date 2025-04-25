using static Lab;
using static Module;

Console.WriteLine(Lab.Assert(Module.Hello, [], "Hello World!"));
Console.WriteLine(Lab.Assert(Module.Integer, [], 42));
Console.WriteLine(Lab.Assert(Module.Double, [], 3.1416));
Console.WriteLine(Lab.Assert(Module.Bool, [], true));

Console.WriteLine(Lab.Assert(Module.CelsiusToFahrenheit, [0.0], 32.0));
Console.WriteLine(Lab.Assert(Module.CelsiusToFahrenheit, [20.0], 68.0));
Console.WriteLine(Lab.Assert(Module.CelsiusToFahrenheit, [-20.0], -4.0));

Console.WriteLine(Lab.Assert(Module.Compare, [42], 0));
Console.WriteLine(Lab.Assert(Module.Compare, [43], 1));
Console.WriteLine(Lab.Assert(Module.Compare, [41], -1));

Console.WriteLine(Lab.Assert(Module.AgeToString, [7], "Youngster"));
Console.WriteLine(Lab.Assert(Module.AgeToString, [16], "Teenager"));
Console.WriteLine(Lab.Assert(Module.AgeToString, [42], "Adult"));
Console.WriteLine(Lab.Assert(Module.AgeToString, [65], "Retired"));

Console.WriteLine(Lab.Assert(Module.SumToN, [0], 0));
Console.WriteLine(Lab.Assert(Module.SumToN, [1], 1));
Console.WriteLine(Lab.Assert(Module.SumToN, [2], 3));
Console.WriteLine(Lab.Assert(Module.SumToN, [4], 10));

Console.WriteLine(Lab.Assert(Module.IsEven, [0], true));
Console.WriteLine(Lab.Assert(Module.IsEven, [1], false));
Console.WriteLine(Lab.Assert(Module.IsEven, [2], true));
Console.WriteLine(Lab.Assert(Module.IsEven, [9], false));

Console.WriteLine(Lab.Assert(Module.SumOddToN, [0], 0));
Console.WriteLine(Lab.Assert(Module.SumOddToN, [1], 1));
Console.WriteLine(Lab.Assert(Module.SumOddToN, [4], 4));
Console.WriteLine(Lab.Assert(Module.SumOddToN, [5], 9));

Console.WriteLine(Lab.Assert(Module.StringOfValues, [1, 3], "1, 2, 3"));
Console.WriteLine(Lab.Assert(Module.StringOfValues, [2, 4], "2, 3, 4"));
Console.WriteLine(Lab.Assert(Module.StringOfValues, [2, 1], ""));

Console.WriteLine(Lab.Assert(Module.CountWords, ["Mumintrollet bor i skogen."], 4));
Console.WriteLine(Lab.Assert(Module.CountWords, [" Hej jag heter Mikael "], 4));

Console.WriteLine(Lab.Assert(Module.ReverseString, ["abc"], "cba"));
Console.WriteLine(Lab.Assert(Module.ReverseString, ["Mikael"], "leakiM"));

Console.WriteLine(Lab.Assert(Module.IsPalindrom, ["AbccbA"], true));
Console.WriteLine(Lab.Assert(Module.IsPalindrom, ["AbcbA"], true));
Console.WriteLine(Lab.Assert(Module.IsPalindrom, ["Mumintroll"], false));

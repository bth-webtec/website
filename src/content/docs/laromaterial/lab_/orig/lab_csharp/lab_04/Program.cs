using static Lab;
using static Module;

string a = $"{Math.PI:F5}";

Console.WriteLine(Lab.Assert(Module.Hello, [], "Hello World!"));

Console.WriteLine(Lab.Assert(Module.SquareOfTwo, [], 1.4142));

Console.WriteLine(Lab.Assert(Module.Addition, [3.1415, 1.4142], 4.56));
Console.WriteLine(Lab.Assert(Module.Addition, [40.0001, 1.9998], 42.00));

Console.WriteLine(Lab.Assert(Module.IntValString, ["42"], 42));
Console.WriteLine(Lab.Assert(Module.IntValString, ["7"], 7));

Console.WriteLine(Lab.Assert(Module.FormatPiAsString, [], a));

Console.WriteLine(Lab.Assert(Module.RoundUp, [3.14], 4));

Console.WriteLine(Lab.Assert(Module.RoundDown, [3.14], 3));

int[] arr1 = [1, 2, 3, 4, 5, 6, 7];
int[] arr2 = [3, 4, 5, 6, 7, 8];
Console.WriteLine(Lab.Assert(Module.LengthOfArray, [arr1], 7));

Console.WriteLine(Lab.Assert(Module.FirstItemInArray, [arr1], 1));
Console.WriteLine(Lab.Assert(Module.FirstItemInArray, [arr2], 3));

Console.WriteLine(Lab.Assert(Module.LastItemInArray, [arr1], 7));
Console.WriteLine(Lab.Assert(Module.LastItemInArray, [arr2], 8));

Console.WriteLine(Lab.Assert(Module.MidItemInArray, [arr1], 4));
Console.WriteLine(Lab.Assert(Module.MidItemInArray, [arr2], 5));

Console.WriteLine(Lab.Assert(Module.SumArray, [arr1], 28));
Console.WriteLine(Lab.Assert(Module.SumArray, [arr2], 33));

int[] arr3 = [3, 9, 1, 42, 9, 13];
int[] arr4 = [42, 7, 0, 13, 8, 5];
Console.WriteLine(Lab.Assert(Module.Max, [arr3], 42));
Console.WriteLine(Lab.Assert(Module.Max, [arr4], 42));

Console.WriteLine(Lab.Assert(Module.IsSorted, [arr1], true));
Console.WriteLine(Lab.Assert(Module.IsSorted, [arr3], false));

Console.WriteLine(Lab.Assert(Module.Average, [arr3], 13));
Console.WriteLine(Lab.Assert(Module.Average, [arr2], 6));

Console.WriteLine(Lab.Done());

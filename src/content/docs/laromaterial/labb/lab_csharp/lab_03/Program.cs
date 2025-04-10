using static Lab;
using static Module;

string a = $"{Math.PI:F2}";
string b = $"{Math.Sqrt(2):F2}";

Console.WriteLine(Lab.Assert(Module.Hello, [], "Hello World!"));

Console.WriteLine(Lab.Assert(Module.StringLength, ["Mumintrollet"], 12));
Console.WriteLine(Lab.Assert(Module.StringLength, [" This is a string "], 18));

Console.WriteLine(Lab.Assert(Module.FirstChar, ["Mumin"], "M"));
Console.WriteLine(Lab.Assert(Module.FirstChar, ["Mu"], "M"));
Console.WriteLine(Lab.Assert(Module.FirstChar, [""], ""));

Console.WriteLine(Lab.Assert(Module.LastChar, ["Mumin"], "n"));
Console.WriteLine(Lab.Assert(Module.LastChar, ["Mu"], "u"));
Console.WriteLine(Lab.Assert(Module.LastChar, [""], ""));

Console.WriteLine(Lab.Assert(Module.MidChar, ["Mumins"], "mi"));
Console.WriteLine(Lab.Assert(Module.MidChar, ["Mumin"], "m"));
Console.WriteLine(Lab.Assert(Module.MidChar, ["Mu"], "Mu"));
Console.WriteLine(Lab.Assert(Module.MidChar, ["M"], "M"));
Console.WriteLine(Lab.Assert(Module.MidChar, [""], ""));

Console.WriteLine(Lab.Assert(Module.FormatString, ["Hi", 'Y', 42, Math.PI], $"Hi Y 042 {a}"));
Console.WriteLine(Lab.Assert(Module.FormatString, ["Yooou", 'I', 7, Math.Sqrt(2)], $"Yooou I 007 {b}"));

Console.WriteLine(Lab.Assert(Module.SwapCase, ["MuminTROLL"], "mUMINtroll"));
Console.WriteLine(Lab.Assert(Module.SwapCase, ["I like #cake"], "i LIKE #CAKE"));

Console.WriteLine(Lab.Assert(Module.ReplaceSpace, [" I like #cake "], "I-like-#cake"));
Console.WriteLine(Lab.Assert(Module.ReplaceSpace, ["mumin troll"], "mumin-troll"));

Console.WriteLine(Lab.Assert(Module.Substring, ["Mumintrollet", 5, 5], "troll"));
Console.WriteLine(Lab.Assert(Module.Substring, ["Mumintrollet", 0, 5], "Mumin"));

Console.WriteLine(Lab.Assert(Module.CountVowels, ["Maskimask"], 3));
Console.WriteLine(Lab.Assert(Module.CountVowels, ["Mumintrollet"], 4));
Console.WriteLine(Lab.Assert(Module.CountVowels, ["Åke, Göte och Åse är på promenad."], 12));

Console.WriteLine(Lab.Assert(Module.ReplaceConsonants, ["Maskimask"], "*a**i*a**"));
Console.WriteLine(Lab.Assert(Module.ReplaceConsonants, ["Mumintrollet"], "*u*i***o**e*"));
Console.WriteLine(Lab.Assert(Module.ReplaceConsonants, ["Åke, Göte och Åse är på promenad."], "Å*e, *ö*e o** Å*e ä* *å **o*e*a*."));

Console.WriteLine(Lab.Assert(Module.ReplaceSpaceMultiple, [" I  like  #cake "], "I-like-#cake", 2));
Console.WriteLine(Lab.Assert(Module.ReplaceSpaceMultiple, ["Mumin \t troll   et"], "Mumin-troll-et"));

Console.WriteLine(Lab.Assert(Module.CheckPasswordConstraints, ["Hemligt7"], false, 2));
Console.WriteLine(Lab.Assert(Module.CheckPasswordConstraints, ["He#ligt7"], true));
Console.WriteLine(Lab.Assert(Module.CheckPasswordConstraints, ["he#ligt"], false));
Console.WriteLine(Lab.Assert(Module.CheckPasswordConstraints, ["!#HEMligt777"], true));

Console.WriteLine(Lab.Done());

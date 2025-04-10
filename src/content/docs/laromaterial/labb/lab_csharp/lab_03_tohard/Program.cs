using static Lab;
using static Module;

Console.WriteLine(Lab.Assert(Module.Hello, [], "Hello World!"));

Console.WriteLine(Lab.Assert(Module.StringLength, ["Mumintrollet"], 12));
Console.WriteLine(Lab.Assert(Module.StringLength, [" This is a string "], 18));

Console.WriteLine(Lab.Assert(Module.FirstLastChar, ["Mumin"], "Mn"));
Console.WriteLine(Lab.Assert(Module.FirstLastChar, ["Mu"], "Mu"));
Console.WriteLine(Lab.Assert(Module.FirstLastChar, [""], ""));

Console.WriteLine(Lab.Assert(Module.IntValChar, ["Cow say muu"], 32));
Console.WriteLine(Lab.Assert(Module.IntValChar, ["Mumin"], 105));

Console.WriteLine(Lab.Assert(Module.CreateStringFromChar, ['a', 5], "abcde"));
Console.WriteLine(Lab.Assert(Module.CreateStringFromChar, ['z', 1], "z"));
Console.WriteLine(Lab.Assert(Module.CreateStringFromChar, ['M', 7], "MNOPQRS"));

Console.WriteLine(Lab.Assert(Module.FormatString, ["Hi", 'Y', 42, Math.PI], "Hi Y 042 3.14"));
Console.WriteLine(Lab.Assert(Module.FormatString, ["Yooou", 'I', 7, Math.Sqrt(2)], "Yooou I 007 1.41"));

Console.WriteLine(Lab.Assert(Module.SwapCase, ["MuminTROLL"], "mUMINtroll"));
Console.WriteLine(Lab.Assert(Module.SwapCase, ["I like #cake"], "i LIKE #CAKE"));

Console.WriteLine(Lab.Assert(Module.ReplaceSpace, [" I like #cake "], "I-like-#cake"));
Console.WriteLine(Lab.Assert(Module.ReplaceSpace, ["mumin troll"], "mumin-troll"));

Console.WriteLine(Lab.Assert(Module.ReplaceSpaceMultiple, [" I  like  #cake "], "I-like-#cake"));
Console.WriteLine(Lab.Assert(Module.ReplaceSpaceMultiple, [" Mumin \t troll   et"], "Mumin-troll-et"));

Console.WriteLine(Lab.Assert(Module.Substring, ["Mumintrollet", 5, 5], "troll"));
Console.WriteLine(Lab.Assert(Module.Substring, ["Mumintrollet", 0, 5], "Mumin"));

Console.WriteLine(Lab.Assert(Module.SubstringInString, ["Mumintrollet", "troll"], true));
Console.WriteLine(Lab.Assert(Module.SubstringInString, ["Mumintrollet", "Moomin"], false));

Console.WriteLine(Lab.Assert(Module.FirstLastSubstring, ["Mumin bor i skogen."], "Mumin skogen."));
Console.WriteLine(Lab.Assert(Module.FirstLastSubstring, ["I like cake"], "I cake"));

Console.WriteLine(Lab.Assert(Module.CheckPasswordConstraints, ["Hemligt7"], false, 3));
Console.WriteLine(Lab.Assert(Module.CheckPasswordConstraints, ["He#ligt7"], true));
Console.WriteLine(Lab.Assert(Module.CheckPasswordConstraints, ["he#ligt"], false));
Console.WriteLine(Lab.Assert(Module.CheckPasswordConstraints, ["!#HEMligt777"], true));

Console.WriteLine(Lab.Done());

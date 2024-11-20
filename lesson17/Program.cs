using System.Text.RegularExpressions;

string str = "роза, розочка, тюльпан";
Regex regex = new Regex(@"роз(\w*)");
MatchCollection mathes  = regex.Matches(str);
if (mathes.Count > 0 )
{
    foreach (Match m in mathes) Console.WriteLine(m.Value);
}
else
{
    Console.WriteLine("Совпадений нет");
}
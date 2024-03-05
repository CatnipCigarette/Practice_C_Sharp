using System.Text.RegularExpressions;


var text = "День сон вкусное луг восток грустное";
var result = Regex.Matches(text, @"\w+[аоиеёыуиэюя]+\b", RegexOptions.IgnoreCase);
foreach (var item in result)
{
    Console.WriteLine(item);
}
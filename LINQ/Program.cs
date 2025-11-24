using LINQ;

string[] wordsWithNoUpperCase = new string[]
{
    "the",
    "quick",
    "brown"
};
Console.WriteLine(UpperCaseChecker.IsAnyWordUpperCase(wordsWithNoUpperCase));

string[] wordsWithUpperCase = new string[]
{
    "THE",
    "quick",
    "brown"
};
Console.WriteLine(UpperCaseChecker.IsAnyWordUpperCase(wordsWithUpperCase));

var words = new List<string> { "a", "bb", "ccc", "dddd" };
var wordsLongerThanTwoLetters = words.Where(word => word.Length > 2);

Console.WriteLine("\n");
foreach (var word in wordsLongerThanTwoLetters)
{
    Console.WriteLine(word);
}
words.Add("e");

var numbers = new int[] { 1, 2, 3, 4, 5, 6 };
var oddNumbers = numbers.Where(number => number % 2 == 1);

var any = new Any();
any.TestAny();

var all = new All();
all.TestAll();

var count = new Count();
count.TestCount();

var orderBy = new OrderBy();
orderBy.TestOrderBy();
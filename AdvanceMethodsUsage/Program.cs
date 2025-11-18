using AdvanceMethodsUsage;

var funcAndActions = new FuncAndActions();
var numbers = new[] { 1, 4, 7, 19, 2 };
Func<int, bool> predicate1 = IsLargerThan10;
Console.WriteLine($"IsAnyLargerThan10? {funcAndActions.IsAny(numbers, predicate1)}");
Func<int, bool> predicate2 = IsEven;
Console.WriteLine($"IsAnyEven? {funcAndActions.IsAny(numbers, predicate2)}");
bool IsLargerThan10(int number)
{
    return number > 10;
}
bool IsEven(int number)
{
    return number % 2 == 0;
}

Console.WriteLine("\n");
Func<string, string> processString1 = TrimTo5Letters;
Func<string, string> processString2 = ToUpper;
string TrimTo5Letters(string input)
{
    return input.Substring(0, 5);
}
string ToUpper(string input)
{
    return input.ToUpper();
}
Console.WriteLine(processString1("Helloooooooooooo"));
Console.WriteLine(processString2("Helloooooooooooo"));

Console.WriteLine("\n");
Print print1 = text => Console.WriteLine(text.ToUpper());
Print print2 = text => Console.WriteLine(text.ToLower());
Print multicast = print1 + print2;
Print print4 = text => Console.WriteLine(text.Substring(0, 3));
multicast += print4;
multicast("Crocodile");

Func<string, string, int> sumLengths = SumLengths;

int SumLengths(string text1, string text2)
{
    return text1.Length + text2.Length;
}

delegate void Print(string input);
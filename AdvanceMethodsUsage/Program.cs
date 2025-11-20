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

Console.WriteLine("\n");
var employees = new List<Employee>
{
    new Employee("Jake Smith", "Space Navigation", 25000),
    new Employee("Anna Blake", "Space Navigation", 29000),
    new Employee("Barbara Oak", "Xenobiology", 21500),
    new Employee("Damien Parker", "Xenobiology", 22000),
    new Employee("Nisha Patel", "Mechanics", 21000),
    new Employee("Gustavo Sanchez", "Mechanics", 20000),
};
var dictionaryPractice = new DictionaryPractice();
foreach (var employee in dictionaryPractice.CalculateAverageSalaryPerDepartment(employees))
{
    Console.WriteLine($"Department: {employee.Key}, Average Salary: {employee.Value}");
}

Console.WriteLine("\n");
var pet = new List<Pet>
{
    new Pet(PetType.Dog, 10),
    new Pet(PetType.Cat, 5),
    new Pet(PetType.Fish, 0.9),
    new Pet(PetType.Dog, 45),
    new Pet(PetType.Cat, 2),
    new Pet(PetType.Fish, 0.02),
};
foreach (var item in DictionaryPractice.FindMaxWeights(pet))
{
    Console.WriteLine($"Pet Type: {item.Key}, Weight: {item.Value}");
}

Console.WriteLine("\n");
var listOfNumbers = new List<int> { 10, 12, -100, 55, 17, 22 };
var filteringStrategySelector = new FilteringStrategySelector();
Console.WriteLine("Select filter:");
Console.WriteLine(string.Join(Environment.NewLine, filteringStrategySelector.FilteringStrategiesNames));
var userInput = Console.ReadLine() ?? string.Empty;
var filteringStrategy = new FilteringStrategySelector().Select(userInput);
IEnumerable<int> result = new Filter().FilterBy(filteringStrategy, listOfNumbers);
Print(result);
void Print(IEnumerable<int> numbers)
{
    Console.WriteLine(string.Join(", ", numbers));
}

delegate void Print(string input);

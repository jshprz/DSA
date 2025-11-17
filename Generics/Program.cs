using Generics;
using System.Diagnostics;

var listOfInt = new ListGeneric<int>();
var listOfString = new ListGeneric<string>();
var listOfDateTime = new ListGeneric<DateTime>();

listOfInt.Add(1);
listOfInt.Add(2);
listOfInt.Add(3);
listOfInt.Add(4);
listOfInt.Add(5);


listOfString.Add("One");
listOfString.Add("Two");
listOfString.Add("Three");
listOfString.Add("Four");
listOfString.Add("Five");

listOfDateTime.Add(new DateTime(2023, 10, 1));
listOfDateTime.Add(new DateTime(2024, 11, 2));
listOfDateTime.Add(new DateTime(2025, 12, 3));


// Print all items in listOfInt
int indexToGet = 4;
var element = listOfInt.GetAtIndex(indexToGet);
Console.WriteLine($"Get element at index [{indexToGet}]: {element} \n");

Console.WriteLine("All items in the list of int:");
foreach (var item in listOfInt.GetAllItems())
{
    Console.WriteLine(item);
}


// Print all items in listOfString
Console.WriteLine("\nAll items in the list of string:");
foreach (var item in listOfString.GetAllItems())
{
    Console.WriteLine(item);
}

// Print all items in listOfDateTime
Console.WriteLine("\nAll items in the list of DateTime:");
foreach (var item in listOfDateTime.GetAllItems())
{
    Console.WriteLine(item);
}

var numbers = new List<int> { 1, 2, 3, 4, 5 };
var minMax = GetMinMax(numbers);
Console.WriteLine($"\n\nMin: {minMax.Item1}\nMax: {minMax.Item2}");

SimpleTupleGeneric<int, int> GetMinMax(IEnumerable<int> input)
{
    if (!input.Any())
    {
        throw new InvalidOperationException("Input collection cannot be empty.");
    }

    int min = input.First();
    int max = input.First();

    foreach (var number in input)
    {
        if (number < min)
        {
            min = number;
        }
        if (number > max)
        {
            max = number;
        }
    }

    return new SimpleTupleGeneric<int, int>(min, max);
}

Console.WriteLine("\n");
var decimals = new List<bool> { false, true };
var ints = decimals.ConverTo<bool, int>();
Console.WriteLine("Test list extension: ");
foreach (var item in ints)
{
    Console.WriteLine(item);
}

Console.WriteLine("\n");
Tuple<List<int>, bool> tuple = new Tuple<List<int>, bool>(new List<int> { 1, 2, 3}, true);
var (item1, item2) = TupleSwapExercise.SwapSwapTupleItems(tuple);
Console.WriteLine($"Before swap: Item1 = {tuple.Item1}, Item2 = {tuple.Item2}");
Console.WriteLine($"Swapped items: Item1 = {item1}, Item2 = {item2}");

Console.WriteLine("\n");
Stopwatch stopwatch = Stopwatch.StartNew();
var typeConstraints = new TypeConstraints();
var dates = typeConstraints.CreateCollectionOfRandomLength<DateTime>(0);
stopwatch.Stop();
Console.WriteLine($"Execution took for the CreateCollectionOfRandomLength(): {stopwatch.ElapsedMilliseconds} ms.");


Console.WriteLine("\n");
var people = new List<Person>
{
    new Person { Name = "John", YearOfBirth = 1980 },
    new Person { Name = "Anna", YearOfBirth = 1815 },
    new Person { Name = "Bill", YearOfBirth = 2150 }
};
var employee = new List<Employee>
{
    new Employee { Name = "John", YearOfBirth = 1980 },
    new Employee { Name = "Anna", YearOfBirth = 1815 },
    new Employee { Name = "Bill", YearOfBirth = 2150 }
};
var validPeople = typeConstraints.GetOnlyValid(people);
var validEmployees = typeConstraints.GetOnlyValid(employee);
foreach (var validEmployee in validEmployees)
{
    validEmployee.GoToWork();
}


Console.WriteLine("\n");
var person = new Person();
var john = new Person { Name = "John", YearOfBirth = 1980 };
var anna = new Person { Name = "Anna", YearOfBirth = 1915 };
person.PrintInOrder(10, 5);
person.PrintInOrder("aaa", "bbb");
person.PrintInOrder(anna, john);


Console.WriteLine("\n");
Console.WriteLine($"Square of 2 is: {Calculator.Square(2)}");
Console.WriteLine($"Square of 4m is: {Calculator.Square(4m)}");
Console.WriteLine($"Square of 6d is: {Calculator.Square(6d)}");


Console.WriteLine("\n");
var pet = new Pet();
var owner = new PetOwner();
typeConstraints.SomeMethod(pet, owner);
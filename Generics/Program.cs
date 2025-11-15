using Generics;

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
using System.Linq;

namespace LINQ
{
    public class FirstAndLast
    {
        public void TestFirstAndLast()
        {
            IEnumerable<int> numbers = new[] { 16, 8, 9, -1, 2 };
            var firstNumber = numbers.First();
            Console.WriteLine("\n");
            Console.WriteLine(firstNumber);

            var firstOdd = numbers.First(number => number % 2 == 1);
            Console.WriteLine(firstOdd);

            var pets =
                new[]
                {
                    new Pet(1, "Hannibal", PetType.Fish, 1.1f),
                    new Pet(2, "Anthony", PetType.Cat, 2f),
                    new Pet(3, "Ed", PetType.Cat, 0.7f),
                    new Pet(4, "Taiga", PetType.Dog, 35f),
                    new Pet(5, "Rex", PetType.Dog, 40f),
                    new Pet(6, "Lucky", PetType.Dog, 5f),
                    new Pet(7, "Storm", PetType.Cat, 0.9f),
                    new Pet(8, "Nyan", PetType.Cat, 2.2f)
                };

            var lastDog = pets.Last(pet => pet.PetType == PetType.Dog);
            Console.WriteLine(lastDog);

            var lastPetHeavierThan100 = pets.LastOrDefault(pet => pet.Weight > 100);
            Console.WriteLine(lastPetHeavierThan100);

            var heaviestPet = pets.OrderBy(pet => pet.Weight).Last();
            Console.WriteLine(heaviestPet);

            List<string> words = new List<string>
            {
                "aaa", "bb", "c", "d"
            };
            var findTheFirstShortestWord = words.OrderBy(word => word.Count()).FirstOrDefault();
            Console.WriteLine(findTheFirstShortestWord);
        }
    }
}

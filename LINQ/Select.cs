using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ
{
    public class Select
    {
        public void TestSelect()
        {
            var numbers = new[] { 10, 1, 4, 17, 122 };
            var doubledNumbers = numbers.Select(number => number * 2);
            Console.WriteLine("\n");
            foreach (var number in doubledNumbers)
            {
                Console.WriteLine(number);
            }

            var words = new[] { "little", "brown", "fox" };
            var toUppercase = words.Select(word => word.ToUpper());
            Console.WriteLine("\n");
            foreach (var word in toUppercase)
            {
                Console.WriteLine(word);
            }

            IEnumerable<string> numbersAsStrings = numbers.Select(number => number.ToString());
            Console.WriteLine("\n");
            foreach (var numberAsString in numbersAsStrings)
            {
                Console.WriteLine(numberAsString);
            }

            var numberedWords = words.Select((word, index) => $"{index + 1}. {word}");
            Console.WriteLine("\n");
            foreach (var word in numberedWords)
            {
                Console.WriteLine(word);
            }

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
            var weights = pets.Select(pet => pet.Weight);
            Console.WriteLine("\n");
            foreach(var weight in weights)
            {
                Console.WriteLine(weight); 
            }

            var heavyPetTypes = pets.Where(pet => pet.Weight > 4).Select(pet => pet.PetType).Distinct();
            Console.WriteLine("\n");
            foreach (var heavyPetType in heavyPetTypes)
            {
                Console.WriteLine(heavyPetType);
            }

            var petsInitials = pets.OrderBy(pet => pet.Name).Select(pet => $"{pet.Name.First()}.");
            Console.WriteLine("\n");
            foreach (var petsInitial in petsInitials)
            {
                Console.WriteLine(petsInitial);
            }

            var petsData = pets.Select(pet =>
                $"Pet named {pet.Name}, of type {pet.PetType} " +
                $"and weight {pet.Weight}");
            Console.WriteLine("\n");
            foreach (var petData in petsData)
            {
                Console.WriteLine(petData);
            }
        }
    }
}

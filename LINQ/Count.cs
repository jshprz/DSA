using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQ
{
    public class Count
    {
        public void TestCount()
        {
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
            Console.WriteLine("\n");
            var countOfDogs = pets.Count(pet => pet.PetType == PetType.Dog);
            Console.WriteLine(countOfDogs);

            var countOfPetsNamedBruce = pets.LongCount(pet => pet.Name == "Bruce");
            Console.WriteLine($"Bruce: " + countOfPetsNamedBruce);

            var countOfAllSmallDogs = pets.Count(pet =>
                pet.PetType == PetType.Dog &&
                pet.Weight < 10
            );
            Console.WriteLine($"Small dogs count: {countOfAllSmallDogs}");

            var allPetsCount = pets.Count();
            Console.WriteLine($"All pets count: {allPetsCount}");
        }
    }
}

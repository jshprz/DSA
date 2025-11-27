namespace LINQ
{
    public class Where
    {
        public void TestWhere()
        {
            IEnumerable<int> numbers = new[] { 10, 1, 4, 17, 122 };
            var evenNumbers = numbers.Where(number => number % 2 == 0);
            Console.WriteLine("\n");
            foreach (var number in evenNumbers)
            {
                Console.WriteLine(number);
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
            var heavierThan10Kilos = pets.Where(pet => pet.Weight > 10);
            Console.WriteLine("\n");
            foreach (var pet in heavierThan10Kilos)
            {
                Console.WriteLine(pet);
            }

            var heavierThan100Kilos = pets.Where(pet => pet.Weight > 100);
            Console.WriteLine("\n");
            foreach (var pet in heavierThan100Kilos)
            {
                Console.WriteLine(pet);
            }

            var verySpecificPets = pets.Where(pet =>
                (pet.PetType == PetType.Cat ||
                pet.PetType == PetType.Dog) &&
                pet.Weight > 10 &&
                pet.Id % 2 == 0);
            Console.WriteLine("\n");
            foreach (var pet in verySpecificPets)
            {
                Console.WriteLine(pet);
            }

            var indexesSelectedByUser = new[] { 1, 6, 7 };
            var petsSelectedByUserAndLighterThan5Kilos = pets
                .Where((pet, index) =>

                    pet.Weight < 5 &&
                    indexesSelectedByUser.Contains(index));
            Console.WriteLine("\n");
            foreach(var pet in petsSelectedByUserAndLighterThan5Kilos)
            {
                Console.WriteLine(pet); 
            }

            int countOfHeavyPets1 = pets.Count(pet => pet.Weight > 30);
            int countOfHeavyPets2 = pets.Where(pet => pet.Weight > 30).Count();
            Console.WriteLine("\n");
            Console.WriteLine(countOfHeavyPets1);
            Console.WriteLine(countOfHeavyPets2);
        }
    }
}

namespace LINQ
{
    public class OrderBy
    {
        public void TestOrderBy()
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
            var petsOrderedByName = pets.OrderBy(pet => pet.Name);
            foreach (var pet in petsOrderedByName)
            {
                Console.WriteLine(pet);
            }
            Console.WriteLine("\n | \n");
            foreach (var pet in pets)
            {
                Console.WriteLine(pet);
            }

            var petsOrderedByIdDesc = pets.OrderByDescending(pet => pet.Id);
            Console.WriteLine("\n");
            foreach (var pet in petsOrderedByIdDesc)
            {
                Console.WriteLine(pet); 
            }
        }
    }
}

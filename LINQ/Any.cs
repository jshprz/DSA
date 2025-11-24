namespace LINQ
{
    public class Any
    {
        public void TestAny()
        {
            Console.WriteLine("\n");
            var theNumbers = new[] { 5, 9, 2, 12, 6 };
            bool isAnyLargerThan10 = theNumbers.Any(number => number > 10);
            Console.WriteLine(isAnyLargerThan10);

            Console.WriteLine("\n");
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
            var isAnyPetNamedBruce = pets.Any(pet => pet.Name == "Bruce");
            Console.WriteLine(isAnyPetNamedBruce);
            var isAnyFish = pets.Any(pet => pet.PetType == PetType.Fish);
            Console.WriteLine($"{isAnyFish}", nameof(isAnyFish));
            var isThereAVerySpecificPet = pets.Any(pet =>
                pet.Name.Length > 6 && pet.Id % 2 == 0);
            Console.WriteLine($"{isThereAVerySpecificPet}", nameof(isThereAVerySpecificPet));

            Console.WriteLine("\n");
            var isNotEmpty = pets.Any();
            Console.WriteLine(isNotEmpty);
        }
    }

    public class Pet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public PetType PetType { get; }
        public double Weight { get; }

        public Pet(int id, string name, PetType petType, double weight)
        {
            Id = id;
            Name = name;
            PetType = petType;
            Weight = weight;
        }

        public override string ToString() => $"{PetType}, {Weight} kilos";
    }
    public enum PetType { Dog, Cat, Fish }
}

using System.Numerics;

namespace Generics
{
    public class TypeConstraints
    {
        public IEnumerable<T> CreateCollectionOfRandomLength<T>(int maxLength) where T : new()
        {
            var length = 100000000; // new Random().Next(maxLength + 1);

            var result = new List<T>(length);

            for (int i = 0; i < length; ++i)
            {
                result.Add(new T());
            }

            return result;
        }

        public IEnumerable<TPerson> GetOnlyValid<TPerson>(IEnumerable<TPerson> persons) where TPerson : Person
        {
            var result = new List<TPerson>();

            foreach (var person in persons)
            {
                if (person.YearOfBirth > 1900 &&
                    person.YearOfBirth < DateTime.Now.Year)
                {
                    result.Add(person);
                }
            }

            return result;
        }

        public void SomeMethod<TPet, TOwner>(TPet pet, TOwner owner)
            where TPet: Pet, IComparable<TPet>
            where TOwner: new()
        {
            Console.WriteLine("Test SomeMethod()!!!");
        }
    }

    public class Person : IComparable<Person>
    {
        public string Name { get; init; }
        public int YearOfBirth { get; init; }

        public override string ToString()
        {
            return $"{Name} born in {YearOfBirth}";
        }

        public int CompareTo(Person other)
        {
            if (YearOfBirth < other.YearOfBirth)
            {
                return 1;
            }
            else if(YearOfBirth > other.YearOfBirth)
            {
                return -1; 
            }

            return 0;
        }

        public void PrintInOrder<T>(T first, T second) where T : IComparable<T>
        {
            if (first.CompareTo(second) > 0)
            {
                Console.WriteLine($"{second} {first}");
            }
            else
            {
                Console.WriteLine($"{first} {second}");
            }
        }
    }

    public class Employee : Person
    {
        public void GoToWork()
        {
            Console.WriteLine("Going to work");
        }
    }

    public static class Calculator
    {
        public static T Square<T>(T input) where T : INumber<T> // Generic Math
        {
            return input * input;
        }
    }

    public class Pet : IComparable<Pet>
    {
        public int CompareTo(Pet? other)
        {
            throw new NotImplementedException();
        }
    }

    public class PetOwner { }
}

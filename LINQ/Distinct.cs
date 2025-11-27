namespace LINQ
{
    public class Distinct
    {
        public void TestDistinct()
        {
            var numbers = new[] { 10, 1, 10, 4, 17, 17, 122 };
            var numbersNoDuplicates = numbers.Distinct();

            Console.WriteLine("\n");
            foreach (var number in numbersNoDuplicates)
            {
                Console.WriteLine(number);
            }

            var pets = new[]
            {
                new Pet(1, "Hannibal", PetType.Fish, 1.1f),
                new Pet(1, "Hannibal", PetType.Fish, 1.1f)
            };

            List<DateTime> dateTimes = new List<DateTime>
            {
                new DateTime(2025, 11, 27, 23, 32, 0),
                new DateTime(2025, 11, 28, 10, 15, 0),
                new DateTime(2025, 11, 29, 8, 45, 0)
            };

            int year = 2025;

            var result = dateTimes.Where((date) =>
                date.Year == year &&
                (int)date.DayOfWeek == 5
            );

            Console.WriteLine("\n");
            foreach (var date in result)
            {
                Console.WriteLine(date);
            }
        }
    }
}

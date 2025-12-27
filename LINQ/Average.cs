namespace LINQ
{
    public class Average
    {
        public void TestAverage()
        {
            var lsitOfNumbers = new List<List<int>>
            {
                new List<int> { 15, 68, 20, 12, 19, 8, 55 },
                new List<int> { 12, 1, 3, 4, -19, 8, 7, 6 },
                new List<int> { 5, -6, -2, -12, -10, 7 }
            };

            var result = lsitOfNumbers
                .Select(listOfNumber => new
                {
                    Count = listOfNumber.Count(),
                    Average = listOfNumber.Average()
                })
                .OrderByDescending(countAndAverage => countAndAverage.Average)
                .Select(countAndAverage =>
                    $"Count is: {countAndAverage.Count}, " +
                    $"Average is: {countAndAverage.Average}");

            Console.WriteLine("\n");
            Console.WriteLine(string.Join(Environment.NewLine, result));
        }
    }

}

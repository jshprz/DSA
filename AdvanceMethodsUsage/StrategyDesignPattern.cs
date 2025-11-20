namespace AdvanceMethodsUsage
{
    public class FilteringStrategySelector
    {
        private readonly Dictionary<string, Func<int, bool>> _filteringStrategies =
            new Dictionary<string, Func<int, bool>>
            {
                ["even"] = (number) => number % 2 == 0,
                ["odd"] = (number) => number % 2 == 1,
                ["positive"] = (number) => number > 0,
                ["negative"] = (number) => number < 0
            };

        public IEnumerable<string> FilteringStrategiesNames =>
            _filteringStrategies.Keys;


        public Func<int, bool> Select(string filteringType)
        {
            if (!_filteringStrategies.ContainsKey(filteringType))
            {
                throw new NotSupportedException($"{filteringType} is not a valid filter");
            }

            return _filteringStrategies[filteringType];
        }
    }

    public class Filter
    {
        public IEnumerable<T> FilterBy<T>(Func<T, bool> predicate, IEnumerable<T> numbers)
        {
            var result = new List<T>();

            foreach (var number in numbers)
            {
                if (predicate(number))
                {
                    result.Add(number);
                }
            }

            return result;
        }
    }
}

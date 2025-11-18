namespace AdvanceMethodsUsage
{
    public class FuncAndActions
    {
        public bool IsAny(
            IEnumerable<int> numbers,
            Func<int, bool> predicate
            )
        {
            foreach (var number in numbers)
            {
                if (predicate(number))
                {
                    return true;
                }
            }

            return false;
        }
    }
}

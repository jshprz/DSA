namespace Generics
{
    public class SortedList<T> where T : IComparable<T>
    {
        public IEnumerable<T> Items { get; }

        public SortedList(IEnumerable<T> items)
        {
            var asList = items.ToList();
            asList.Sort();
            Items = asList;
        }
    }

    public class FullName : IComparable<FullName>
    {
        public string FirstName { get; init; }
        public string LastName { get; init; }

        public override string ToString() => $"{FirstName} {LastName}";

        public int CompareTo(FullName other)
        {
            int lastNameResult = string.Compare(LastName, other.LastName);
            if (lastNameResult != 0)
            {
                return lastNameResult;
            }

            return string.Compare(FirstName, other.FirstName);
        }
    }
}
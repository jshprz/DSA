namespace LINQ
{
    public static class UpperCaseChecker
    {
        public static bool IsAnyWordUpperCase(IEnumerable<string> strings)
        {
            return strings.Any(word => 
                word.All(letter => char.IsUpper(letter)));
        }
    }
}

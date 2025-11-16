namespace Generics
{
    public static class ListExtensionGeneric
    {
        public static void AddToFront<T>(this List<T> list, T item)
        {
            list.Insert(0, item);
        }

        public static List<TTarget> ConverTo<TSource, TTarget>(this List<TSource> source)
        {
            var target = new List<TTarget>();

            foreach (var item in source)
            {
                TTarget itemAfterCasting = (TTarget)Convert.ChangeType(item, typeof(TTarget));
                target.Add(itemAfterCasting);
            }

            return target;
        }
    }
}

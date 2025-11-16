namespace Generics
{
    public class SimpleTupleNonGeneric
    {
        public int FirstInt { get; set; }
        public int SecondInt { get; set; }

        public SimpleTupleNonGeneric(int firstInt, int secondInt)
        {
            FirstInt = firstInt;
            SecondInt = secondInt;
        }
    }

    public class SimpleTupleGeneric<T1, T2>
    {
        public T1 Item1 { get; set; }
        public T2 Item2 { get; set; }

        public SimpleTupleGeneric(T1 item1, T2 item2)
        {
            Item1 = item1;
            Item2 = item2;
        }
    }
}



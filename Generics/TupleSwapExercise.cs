namespace Generics
{
    public static class TupleSwapExercise
    {
        public static Tuple<T2, T1> SwapSwapTupleItems<T1, T2>(Tuple<T1, T2> tuple)
        {
            return new Tuple<T2, T1>(tuple.Item2, tuple.Item1);
        }
    }
}

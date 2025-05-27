namespace SortingAlgorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BubbleSort bubbleSort = new BubbleSort();

            IList<int> inputBubbleSortAsc = new List<int>() { 4, 1, 5, 3, 2 };
            IList<int> outputBubbleSortAscending = bubbleSort.Ascending(inputBubbleSortAsc);

            IList<int> inputBubbleSortDesc = new List<int>() { 2, 5, 1, 3, 4 };
            IList<int> outputBubbleSortDescending = bubbleSort.Descending(inputBubbleSortDesc);

            Console.WriteLine("Bubble Sort Ascending: ");
            foreach (int i in outputBubbleSortAscending)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\nBubble Sort Descending: ");
            foreach (int i in outputBubbleSortDescending)
            {
                Console.WriteLine(i);
            }

            MergeSort mergeSort = new MergeSort();

            IList<int> inputMergeSortAsc = new List<int>() { 3, 4, 6, 2, 7, 9, 1, 8 };
            IList<int> outputMergeSortAscending = mergeSort.Ascending(inputMergeSortAsc);

            Console.WriteLine("\nMerge Sort Ascending: ");
            foreach (int i  in outputMergeSortAscending)
            {
                Console.WriteLine(i);
            }

            IList<int> inputMergeSortDesc = new List<int>() { 3, 4, 6, 2, 7, 9, 1, 8 };
            IList<int> outputMergeSortDescending = mergeSort.Descending(inputMergeSortDesc);

            Console.WriteLine("\nMerge Sort Descending: ");
            foreach (int i in outputMergeSortDescending)
            {
                Console.WriteLine(i);
            }
        }
    }
}

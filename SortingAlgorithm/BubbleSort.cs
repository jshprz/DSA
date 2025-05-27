using SortingAlgorithm.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithm
{
    internal class BubbleSort : Sort
    {
        public override IList<int> Ascending(IList<int> inputBubbleSortAsc)
        {
            int n = inputBubbleSortAsc.Count;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (inputBubbleSortAsc[j] > inputBubbleSortAsc[j + 1])
                    {
                        int temp = inputBubbleSortAsc[j];
                        inputBubbleSortAsc[j] = inputBubbleSortAsc[j + 1];
                        inputBubbleSortAsc[j + 1] = temp;
                    }
                }
            }

            return inputBubbleSortAsc;
        }

        public override IList<int> Descending(IList<int> inputBubbleSortDesc)
        {
            int n = inputBubbleSortDesc.Count;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (inputBubbleSortDesc[j] < inputBubbleSortDesc[j + 1])
                    {
                        int temp = inputBubbleSortDesc[j];
                        inputBubbleSortDesc[j] = inputBubbleSortDesc[j + 1];
                        inputBubbleSortDesc[j + 1] = temp;
                    }
                }
            }
            return inputBubbleSortDesc;
        }
    }
}

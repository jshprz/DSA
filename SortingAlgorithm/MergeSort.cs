using SortingAlgorithm.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithm
{
    internal class MergeSort : Sort
    {
        public override IList<int> Ascending(IList<int> inputMergeSortAsc)
        {
            MergeSortAscending(inputMergeSortAsc, 0, inputMergeSortAsc.Count - 1);
            return inputMergeSortAsc;
        }

        public override IList<int> Descending(IList<int> inputMergeSortDesc)
        {
            MergeSortDescending(inputMergeSortDesc, 0, inputMergeSortDesc.Count - 1);
            return inputMergeSortDesc;
        }

        private void MergeSortAscending(IList<int> inputMergeSortAsc, int lowElement, int highElement)
        {
            if (lowElement < highElement)
            {
                int midElement = (lowElement + highElement) / 2;
                MergeSortAscending(inputMergeSortAsc, lowElement, midElement);
                MergeSortAscending(inputMergeSortAsc, midElement + 1, highElement);
                MergeAscending(inputMergeSortAsc, lowElement, midElement, highElement);
            }
        }

        private void MergeAscending(IList<int> inputMergeSortAsc, int lowElement, int midElement, int highElement)
        {
            IList<int> left = new List<int>();
            IList<int> right = new List<int>();

            for (int m = lowElement; m <= midElement; m++)
            {
                left.Add(inputMergeSortAsc[m]);
            }

            for (int n = midElement + 1; n <= highElement; n++)
            {
                right.Add(inputMergeSortAsc[n]);
            }

            int i = 0;
            int j = 0;
            int k = lowElement;

            while (i < left.Count && j < right.Count)
            {
                if (left[i] <= right[j])
                {
                    inputMergeSortAsc[k++] = left[i++];
                }
                else
                {
                    inputMergeSortAsc[k++] = right[j++];
                }
            }

            for (; i < left.Count; i++)
            {
                inputMergeSortAsc[k++] = left[i];
            }
            for (; j < right.Count; j++)
            {
                inputMergeSortAsc[k++] = right[j];
            }
        }

        private void MergeSortDescending(IList<int> inputMergeSortDesc, int lowElement, int highElement)
        {
            if (lowElement < highElement)
            {
                int midElement = (lowElement + highElement) / 2;
                MergeSortDescending(inputMergeSortDesc, lowElement, midElement);
                MergeSortDescending(inputMergeSortDesc, midElement + 1, highElement);
                MergeDescending(inputMergeSortDesc, lowElement, midElement, highElement);
            }
        }

        private void MergeDescending(IList<int> inputMergeSortDesc, int lowElement, int midElement, int highElement)
        {
            IList<int> left = new List<int>();
            IList<int> right = new List<int>();

            for (int m = lowElement; m <= midElement; m++)
            {
                left.Add(inputMergeSortDesc[m]);
            }
            for (int n = midElement + 1; n <= highElement; n++)
            {
                right.Add(inputMergeSortDesc[n]);
            }

            int i = 0;
            int j = 0;
            int k = lowElement;

            while (i < left.Count && j < right.Count)
            {
                if (left[i] >= right[j])
                {
                    inputMergeSortDesc[k++] = left[i++];
                }
                else
                {
                    inputMergeSortDesc[k++] = right[j++];
                }
            }

            for(; i < left.Count; i++)
            {
                inputMergeSortDesc[k++] = left[i];
            }
            for(; j < right.Count; j++)
            {
                inputMergeSortDesc[k++] = right[j];
            }
        }
    }
}

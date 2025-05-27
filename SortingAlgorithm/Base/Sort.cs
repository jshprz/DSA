using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithm.Base
{
    internal class Sort
    {
        public virtual IList<int> Ascending(IList<int> intputBubbleSortAsc)
        {
            return new List<int>();
        }

        public virtual IList<int> Descending(IList<int> inputBubbleSortDesc)
        {
            return new List<int>();
        }
    }
}

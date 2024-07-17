using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum9._6._1
{
    internal class Sort
    {
        public event Action<List<string>, bool> SortNames;

        public static void SortName(List<string> names, bool ascending)
        {
            names.Sort();
            if (!ascending)
            {
                names.Reverse();
            }
        }
        public virtual void OnSortNames(List<string> names, bool ascending)
        {
            SortNames?.Invoke(names, ascending);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClassLibrary.Helpers
{
    public class Sorter
    {
        public static string[] InsertionSort(string[] names)
        {
            int n = names.Length;
            for (int i = 1; i <= n - 1; i++)
            {
                string currentElm = names[i];
                int j = i - 1;

                while (j >= 0 && string.Compare(names[j], currentElm, StringComparison.CurrentCultureIgnoreCase) > 0)
                {
                    names[j + 1] = names[j];
                    j = j - 1;
                }
                names[j + 1] = currentElm;
            }
            return names;
        }

    }
}

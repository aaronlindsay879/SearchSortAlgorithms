using System;
using System.Collections.Generic;
using System.Linq;

namespace SearchSortAlgorithms.Searching
{
    public static partial class Algorithm
    {
        /// <summary>
        /// Finds an element in an array by searching sequentially
        /// </summary>
        /// <typeparam name="T">Type of data</typeparam>
        /// <param name="arr">Array to search</param>
        /// <param name="elem">Elem to search for</param>
        /// <returns>Index of <paramref name="elem"/> (-1 if not in array)</returns>
        public static int LinearSearch<T>(this T[] arr, T elem)
        {
            for (int i = 0; i < arr.Length; i++)
                if (arr[i].Equals(elem))
                    return i;

            return -1;
        }
    }
}

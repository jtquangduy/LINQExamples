using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethods.Extensions
{
    public static class MyLINQ
    {
        public static int Count<T>(this IEnumerable<T> sequence)
        {
            int count = 0;
            foreach (var item in sequence)
            {
                count++;
            }
            return count;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace Improvibar
{
    public static class MoreLinq
    {
        public static bool IsEmpty<T>(this IEnumerable<T> sequence) => !sequence.Any();

        public static void MapTo<T1, T2>(this T1[] from, T2[] to, Func<T1, T2> selector)
        {
            if (from.Length != to.Length)
                throw new ArgumentException("Both arrays must have same length");

            for (int i = 0; i < from.Length; i++)
                to[i] = selector(from[i]);
        }

        private static Random rng = new Random();
        public static T RandomElementOrDefault<T>(this T[] array)
        {
            if (array.IsEmpty())
                return default;
            else
            {
                int index = rng.Next(0, array.Length);
                return array[index];
            }
        }
    }
}
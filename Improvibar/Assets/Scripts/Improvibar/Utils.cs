using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Improvibar
{
    public static class Utils
    {
        public static void AddRange<T>(this ICollection<T> collection, params T[] elts)
        {
            foreach (T elt in elts)
                collection.Add(elt);
        }

        public static string ToHex(this Color c) => ToHex((Color32)c);
        public static string ToHex(this Color32 c) => $"#{c.a:X}{c.r:X}{c.g:X}{c.b:X}";
    }
}
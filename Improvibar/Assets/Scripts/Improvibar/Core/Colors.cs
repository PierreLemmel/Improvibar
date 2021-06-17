using System;
using System.Linq;
using UnityEngine;

namespace Improvibar
{
    public static class Colors
    {
        public static Color MinByChannel(params Color[] colors)
        {
            float r = colors.Select(c => c.r).Min();
            float g = colors.Select(c => c.g).Min();
            float b = colors.Select(c => c.b).Min();
            float a = colors.Select(c => c.a).Min();

            return new Color(r, g, b, a);
        }

        public static Color MaxByChannel(params Color[] colors)
        {
            float r = colors.Select(c => c.r).Max();
            float g = colors.Select(c => c.g).Max();
            float b = colors.Select(c => c.b).Max();
            float a = colors.Select(c => c.a).Max();

            return new Color(r, g, b, a);
        }
    }
}
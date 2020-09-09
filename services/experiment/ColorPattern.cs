using System;
using System.Drawing;

namespace experiment
{
    public class ColorPattern
    {
        public static Color PickRandom()
        {
            var random = new Random();
            var bytes = new byte[3];
            random.NextBytes(bytes);
            return Color.FromArgb(bytes[0], bytes[1], bytes[2]);
        }
    }
}
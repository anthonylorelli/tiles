using System;
using System.Drawing;

namespace experiment
{
    public class ColorPattern
    {
        public Color North { get; set; }
        public Color East { get; set; }
        public Color South { get; set; }
        public Color West { get; set; }

        public static Color PickRandom()
        {
            var random = new Random();
            var bytes = new byte[3];
            random.NextBytes(bytes);
            return Color.FromArgb(bytes[0], bytes[1], bytes[2]);
        }
    }
}
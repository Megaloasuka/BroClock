namespace Broddsulan_Clock
{
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.Drawing;

    [StandardModule]
    internal sealed class Config
    {
        private static bool bolIsFixed = false;
        public static Color ColorBase_D = Color.FromArgb(0x19, 0x47, 0x8a);
        public static Color ColorBase_L = Color.FromArgb(0x3e, 0x6d, 0xb5);
        public static Color ColorBase_N = Color.FromArgb(0x2b, 0x57, 0x9a);
        public static Color ColorGray_D = Color.FromArgb(80, 80, 80);
        public static Color ColorGray_N = Color.FromArgb(180, 180, 180);
        public static Color ColorGray_XL = Color.FromArgb(240, 240, 240);
        public static Font FontDisplay_L = new Font("Segoe UI Light", 16f);
        public static Font FontDisplay_M = new Font("Segoe UI Light", 14f);
        public static Font FontDisplay_S = new Font("Segoe UI Light", 12f);
        public static Font FontPublish_L = new Font("Segoe UI Light", 12f);
        public static Font FontPublish_M = new Font("Segoe UI Light", 10f);
        public static Font FontPublish_S = new Font("Segoe UI Light", 9f);
        public static Font FontSlide_L = new Font("Segoe UI Light", 28f);
        public static Font FontSlide_M = new Font("Segoe UI Light", 24f);
        public static Font FontSlide_S = new Font("Segoe UI Light", 20f);
    }
}


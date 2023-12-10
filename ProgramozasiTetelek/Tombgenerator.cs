using System;

namespace ProgramozasiTetelek
{
    public static class Tombgenerator
    {
        private static readonly Random veletlenszamGenerator = new Random();

        private static readonly int[] statikusAdatok = new int[] { -62, 62, 43, -61, -37, 0, 26, -59 };

        public static OsszegezhetoTomb StatikusOsszegezhetoTomb { get; } = new OsszegezhetoTomb(statikusAdatok);

        public static OsszegezhetoTomb VeletlenOsszegezhetoTombGeneralasa(uint meret)
        {
            var adatok = new int[meret];
            for (int i = 0; i < meret; i++)
            {
                adatok[i] = veletlenszamGenerator.Next(-100, 100);
            }
            return new OsszegezhetoTomb(adatok);
        }
    }
}

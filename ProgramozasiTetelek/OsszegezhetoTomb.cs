using System;

namespace ProgramozasiTetelek
{
    public class OsszegezhetoTomb
    {
        private readonly int[] adatok;

        public OsszegezhetoTomb(int[] adatok) => this.adatok = adatok ?? throw new ArgumentNullException(nameof(adatok));

        public int Osszeg
        {
            get
            {
                int osszeg = 0;
                foreach (int adat in adatok)
                {
                    osszeg += adat;
                }
                return osszeg;
            }
        }
    }
}

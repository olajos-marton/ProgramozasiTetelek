using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ProgramozasiTetelek.Tesztek
{
    [TestClass]
    public class OsszegezhetoTombTesztek
    {
        [TestMethod]
        public void NullTomb()
        {
            int[] adatok = null;
            Assert.ThrowsException<ArgumentNullException>(() => new OsszegezhetoTomb(adatok));
        }

        [TestMethod]
        public void UresTombOsszege0()
        {
            int[] adatok = { };
            var osszegezhetoTomb = new OsszegezhetoTomb(adatok);
            int elvartOsszeg = 0;
            int tenylegesOsszeg = osszegezhetoTomb.Osszeg;
            Assert.AreEqual(elvartOsszeg, tenylegesOsszeg);
        }

        [TestMethod]
        public void EgyelemuTombOsszegeAzElemErteke()
        {
            int[] adatok = { 7 };
            var osszegezhetoTomb = new OsszegezhetoTomb(adatok);
            Assert.AreEqual(7, osszegezhetoTomb.Osszeg);
        }

        [TestMethod]
        public void PozitivElemek()
        {
            int[] adatok = { 1, 2, 3, 4, 5 };
            var osszegezhetoTomb = new OsszegezhetoTomb(adatok);
            Assert.AreEqual(15, osszegezhetoTomb.Osszeg);
        }

        [TestMethod]
        public void NegativElemek()
        {
            int[] adatok = { -1, -2, -3, -4, -5 };
            var osszegezhetoTomb = new OsszegezhetoTomb(adatok);
            Assert.AreEqual(-15, osszegezhetoTomb.Osszeg);
        }

        [TestMethod]
        public void VegyesenPozitivEsNegativElemek()
        {
            int[] adatok = { 1, -2, 3, -4, 5 };
            var osszegezhetoTomb = new OsszegezhetoTomb(adatok);
            Assert.AreEqual(3, osszegezhetoTomb.Osszeg);
        }
    }
}
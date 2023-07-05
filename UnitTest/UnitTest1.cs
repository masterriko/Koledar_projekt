using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Koledar
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Pogledamo, ali datum ustreza dnevu v tednu
        /// </summary>
        [TestMethod]
        public void preveri_nedeljo()
        {
            Datum datum = new Datum(1, "julij", 2023);
            Assert.AreEqual(5, datum.dan_v_tednu());
        }

        /// <summary>
        /// Pogledamo, ali datum ustreza dnevu v tednu
        /// </summary>
        [TestMethod]
        public void preveri_petek()
        {
            Datum datum = new Datum(7, "julij", 2023);
            Assert.AreEqual(4, datum.dan_v_tednu());
        }

        /// <summary>
        /// Pogledamo, ali datum ustreza dnevu v tednu
        /// </summary>
        [TestMethod]
        public void preveri_cetrtek()
        {
            Datum datum = new Datum(6, "julij", 2023);
            Assert.AreEqual(3, datum.dan_v_tednu());
        }

        /// <summary>
        /// Pogledamo, ali datum ustreza dnevu v tednu
        /// </summary>
        [TestMethod]
        public void preveri_ponedeljek()
        {
            Datum datum = new Datum(3, "julij", 2023);
            Assert.AreEqual(0, datum.dan_v_tednu());
        }


        /// <summary>
        /// Test praznika
        /// </summary>
        [TestMethod]
        public void preveri_praznik()
        {
            Praznik praznik = new Praznik(3, "julij", 2023);
            Assert.AreEqual(3, praznik.Dan);
        }
    }
}

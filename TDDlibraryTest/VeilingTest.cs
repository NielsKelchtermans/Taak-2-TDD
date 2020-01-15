using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDlibrary;

namespace TDDlibraryTest
{
    [TestClass]
    public class VeilingTest
    {
        [TestMethod]
        public void AlsErGeenBodIsDanNulHoogsteBod()
        {
            var veiling = new Veiling();
            Assert.AreEqual(decimal.Zero, veiling.HoogsteBod);
        }
        [TestMethod]
        public void AlsErEenBodIsDanIsHoogsteBodDatBod()
        {
            var veiling = new Veiling();
            veiling.DoeBod(1000m);
            var hoogstebod = veiling.HoogsteBod;
            Assert.AreEqual(1000m, hoogstebod);
        }
        [TestMethod]
        public void AlsErMeerdereBiedingenZijnDanHoogstebodIsGelijkBedragHoogsteBod()
        {
            var veiling = new Veiling();
            veiling.DoeBod(1000m);
            
            veiling.DoeBod(2000m);
            var hoogstebod = veiling.HoogsteBod;
            Assert.AreEqual(2000m, hoogstebod);
        }
    }
}

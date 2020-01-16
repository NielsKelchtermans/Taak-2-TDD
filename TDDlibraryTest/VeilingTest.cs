using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDlibrary;

namespace TDDlibraryTest
{
    [TestClass]
    public class VeilingTest
    {
        private Veiling veiling;
        [TestInitialize]
        public void Initialize()
        {
            veiling = new Veiling();
        }
        [TestMethod]
        public void AlsErGeenBodIsDanNulHoogsteBod()
        {
           
            Assert.AreEqual(decimal.Zero, veiling.HoogsteBod);
        }
        [TestMethod]
        public void AlsErEenBodIsDanIsHoogsteBodDatBod()
        {
            
            veiling.DoeBod(1000m);
            var hoogstebod = veiling.HoogsteBod;
            Assert.AreEqual(1000m, hoogstebod);
        }
        [TestMethod]
        public void AlsErMeerdereBiedingenZijnDanHoogstebodIsGelijkBedragHoogsteBod()
        {
            
            veiling.DoeBod(1000m);
            
            veiling.DoeBod(2000m);
            var hoogstebod = veiling.HoogsteBod;
            Assert.AreEqual(2000m, hoogstebod);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using task9;
namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DiapasonCount()
        {
            Diapason diapason = new Diapason(1,4);
            Assert.AreEqual(Diapason.GetCount(), 1);
        }
        [TestMethod]
        public void TestMethod1()
        {
            Diapason d1 = new Diapason(3, 5);
            Diapason d2 = new Diapason(5, 3);
            Assert.AreEqual(d1, d2);
        }
        [TestMethod]
        public void Increment()
        {
            Diapason d1 = new Diapason(3, 5);
            d1++;
            Diapason d2 = new Diapason(4, 6);
            Assert.AreEqual(d1, d2);
        }
        [TestMethod]
        public void DiapasonPlusNumber()
        {
            Diapason d1 = new Diapason(3, 5);
            d1 += 3;
            Diapason d2 = new Diapason(6, 8);
            Assert.AreEqual(d1, d2);
        }
        [TestMethod]
        public void NumberPlusDiapason()
        {
            Diapason d1 = new Diapason(3, 5);
            d1 = 3 + d1;
            Diapason d2 = new Diapason(6, 8);
            Assert.AreEqual(d1, d2);
        }
        [TestMethod]
        public void Range()
        {
            Diapason d1 = new Diapason(3, 5);
            Assert.AreEqual(!d1, 2);
        }
        [TestMethod]
        public void StaticInRange()
        {
            Diapason d1 = new Diapason(3, 5);
            Assert.AreEqual(Diapason.GetInRange(d1, 4), true);
        }
        [TestMethod]
        public void InRange()
        {
            Diapason d1 = new Diapason(3, 5);
            Assert.AreEqual(d1.GetInRange(4), true);
        }
        [TestMethod]
        public void ExplicitDiapapson()
        {
            Diapason d1 = new Diapason(3.64, 5);
            Assert.AreEqual((int)d1, 3);
        }
        [TestMethod]
        public void ImplicitDiapapson()
        {
            Diapason d1 = new Diapason(3.64, 5);
            Assert.AreEqual((double)d1, 5);
        }
        [TestMethod]
        public void NumberInRangeBoolDiapasonMoreNumber()
        {
            Diapason d1 = new Diapason(1, 10);
            Assert.AreEqual(d1 > 5, true);
        }
        [TestMethod]
        public void NumberInRangeBoolNumberMoreDiapason()
        {
            Diapason d1 = new Diapason(1, 10);
            Assert.AreEqual(d1 < 5, false);
        }
        [TestMethod]
        public void DiapasonArrayCount()
        {
            DiapasonArray d1 = new DiapasonArray();
            Assert.AreEqual(DiapasonArray.GetCount(), 1);
        }
        [TestMethod]
        public void DiapasonArraySize()
        {
            DiapasonArray d1 = new DiapasonArray(5, 10);
            Assert.AreEqual(d1.Size, 5);
        }
        [TestMethod]
        public void DiapasonArrayNewDiapason()
        {
            DiapasonArray diapasonArray = new DiapasonArray(5, 10);
            Diapason diapason = new Diapason(1, 10);
            diapasonArray[1] = diapason;
            Assert.AreEqual(diapasonArray[1], diapason);
        }
    }
}

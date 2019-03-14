using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SquareIt;

namespace TestIt
{
    [TestClass]
    public class UnitTest1
    {
        //кое-какие проверки
        [TestMethod]
        public void TestIsRectangled()
        {
            var tri = new Triangle(3, 4, 5);
            Assert.IsTrue(tri.IsRectangled);
        }

        [TestMethod]
        public void TestSquare()
        {
            var rect = new Rectangle(2,2);
            Assert.IsTrue(rect.GetSquare() == 4);

            var tri = new Triangle(3, 4, 5);
            Assert.IsTrue(tri.GetSquare() == 6);
        }

        [TestMethod]
        public void TestUnknown()
        {
            var shape = new Shape(2, 2);
            Assert.IsTrue(shape.GetSquare() == 4);
        }
    }
}

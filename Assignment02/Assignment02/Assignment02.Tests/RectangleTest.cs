using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Assignment02.Tests
{
    [TestClass]
    public class RectangleTest
    {
        //Rec

        [TestMethod]
        public void TestGetCurrentLength1()
        {
            Rectangle rectangle = new Rectangle();

            Assert.AreEqual(rectangle.GetCurrentLength(), 1);
        }

        [TestMethod]
        public void TestGetCurrentLength2()
        {
            Rectangle rectangle = new Rectangle(4, 10);

            Assert.AreEqual(rectangle.GetCurrentLength(), 4);
        }

        [TestMethod]
        public void TestGetCurrentLength3()
        {
            Rectangle rectangle = new Rectangle();
            rectangle.SetNewLength(10);
            Assert.AreEqual(rectangle.GetCurrentLength(), 10);
        }

        [TestMethod]
        public void TestSetNewLength1()
        {
            Rectangle rectangle = new Rectangle();
            rectangle.SetNewLength(3);
            Assert.AreEqual(rectangle.GetCurrentLength(), 3);
        }

        [TestMethod]
        public void TestSetNewLength2()
        {
            Rectangle rectangle = new Rectangle();
            rectangle.SetNewLength(18);
            Assert.AreEqual(rectangle.GetCurrentLength(), 18);
        }

        [TestMethod]
        public void TestSetNewLength3()
        {
            Rectangle rectangle = new Rectangle();
            rectangle.SetNewLength(10000);
            Assert.AreEqual(rectangle.GetCurrentLength(), 10000);
        }



        [TestMethod]
        public void TestGetCurrentWidth1()
        {
            Rectangle rectangle = new Rectangle();

            Assert.AreEqual(rectangle.GetCurrentWidth(), 1);
        }

        [TestMethod]
        public void TestGetCurrentWidth2()
        {
            Rectangle rectangle = new Rectangle(4, 10);

            Assert.AreEqual(rectangle.GetCurrentWidth(), 10);
        }

        [TestMethod]
        public void TestGetCurrentWidth3()
        {
            Rectangle rectangle = new Rectangle();
            rectangle.SetNewWidth(10);
            Assert.AreEqual(rectangle.GetCurrentWidth(), 10);
        }

        [TestMethod]
        public void TestSetNewWidth1()
        {
            Rectangle rectangle = new Rectangle();
            rectangle.SetNewWidth(3);
            Assert.AreEqual(rectangle.GetCurrentWidth(), 3);
        }

        [TestMethod]
        public void TestSetNewWidth2()
        {
            Rectangle rectangle = new Rectangle();
            rectangle.SetNewWidth(18);
            Assert.AreEqual(rectangle.GetCurrentWidth(), 18);
        }

        [TestMethod]
        public void TestSetNewWidth3()
        {
            Rectangle rectangle = new Rectangle();
            rectangle.SetNewWidth(10000);
            Assert.AreEqual(rectangle.GetCurrentWidth(), 10000);
        }


        [TestMethod]
        public void TestGetPerimeter1()
        {
            Rectangle rectangle = new Rectangle();

            Assert.AreEqual(rectangle.GetPerimeter(), 4);
        }

        [TestMethod]
        public void TestGetPerimeter2()
        {
            Rectangle rectangle = new Rectangle(3, 5);

            Assert.AreEqual(rectangle.GetPerimeter(), 16);
        }

        [TestMethod]
        public void TestGetPerimeter3()
        {
            Rectangle rectangle = new Rectangle();
            rectangle.SetNewLength(20);
            rectangle.SetNewWidth(10);
            Assert.AreEqual(rectangle.GetPerimeter(), 60);
        }


        [TestMethod]
        public void TestGetArea1()
        {
            Rectangle rectangle = new Rectangle();

            Assert.AreEqual(rectangle.GetArea(), 1);
        }

        [TestMethod]
        public void TestGetArea2()
        {
            Rectangle rectangle = new Rectangle(3, 5);

            Assert.AreEqual(rectangle.GetArea(), 15);
        }

        [TestMethod]
        public void TestGetArea3()
        {
            Rectangle rectangle = new Rectangle();
            rectangle.SetNewLength(20);
            rectangle.SetNewWidth(10);
            Assert.AreEqual(rectangle.GetArea(), 200);
        }

    }
}

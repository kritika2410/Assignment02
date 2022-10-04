using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Assignment02.Tests
{
    [TestClass]
    public class RectangleTest
    {


        [TestMethod]
        public void TestGetCurrentLength_Returns1()
        {
            //Arrange
            int ans;
            Rectangle rectangle = new Rectangle();

            //Act
            ans = rectangle.GetCurrentLength();

            //Assert
            Assert.AreEqual(ans, 1);
        }

        [TestMethod]
        public void TestGetCurrentLength_Input4and10_OutputLength()
        {
            int length = 4;
            int width = 10;

            Rectangle rectangle = new Rectangle(length, width);

            Assert.AreEqual(rectangle.GetCurrentLength(), 4);
        }

        [TestMethod]
        public void TestGetCurrentLength_Input10_OutputNewLength()
        {
            Rectangle rectangle = new Rectangle();
            rectangle.SetNewLength(10);
            Assert.AreEqual(rectangle.GetCurrentLength(), 10);
        }

        [TestMethod]
        public void TestSetNewLength_Input3_OutputSetNewLegth()
        {
            Rectangle rectangle = new Rectangle();
            rectangle.SetNewLength(3);
            Assert.AreEqual(rectangle.GetCurrentLength(), 3);
        }

        [TestMethod]
        public void TestSetNewLength_Input18_OutputSetNewLength()
        {
            Rectangle rectangle = new Rectangle();
            rectangle.SetNewLength(18);
            Assert.AreEqual(rectangle.GetCurrentLength(), 18);
        }

        [TestMethod]
        public void TestSetNewLength_InputNegativeNumbers_OutputInvalidLength()
        {
            Rectangle rectangle = new Rectangle();
            rectangle.SetNewLength(-1);
            Assert.AreEqual(rectangle.GetCurrentLength(), -1);
        }



        [TestMethod]
        public void TestGetCurrentWidth_Returns1()
        {
            Rectangle rectangle = new Rectangle();

            Assert.AreEqual(rectangle.GetCurrentWidth(), 1);
        }

        [TestMethod]
        public void TestGetCurrentWidth_Input4And10_OutputLength4()
        {
            Rectangle rectangle = new Rectangle(4, 10);

            Assert.AreEqual(rectangle.GetCurrentWidth(), 10);
        }

        [TestMethod]
        public void TestGetCurrentWidth_Input10_OutputSetNewWidth()
        {
            Rectangle rectangle = new Rectangle();
            rectangle.SetNewWidth(10);
            Assert.AreEqual(rectangle.GetCurrentWidth(), 10);
        }

        [TestMethod]
        public void TestSetNewWidth_Input3_OutputSetNewWidth()
        {
            Rectangle rectangle = new Rectangle();
            rectangle.SetNewWidth(3);
            Assert.AreEqual(rectangle.GetCurrentWidth(), 3);
        }

        [TestMethod]
        public void TestSetNewWidth_Input18_OutputSetsNewWidth()
        {
            Rectangle rectangle = new Rectangle();
            rectangle.SetNewWidth(18);
            Assert.AreEqual(rectangle.GetCurrentWidth(), 18);
        }

        [TestMethod]
        public void TestSetNewWidth_InputNegativeNumber_OutputInvalidWidth()
        {
            Rectangle rectangle = new Rectangle();
            rectangle.SetNewWidth(-1);
            Assert.AreEqual(rectangle.GetCurrentWidth(), -1);
        }


        [TestMethod]
        public void TestGetPerimeter_InputDefaultLengthAndWidth_OutputCalculatesPerimeter()
        {
            Rectangle rectangle = new Rectangle();

            Assert.AreEqual(rectangle.GetPerimeter(), 4);
        }

        [TestMethod]
        public void TestGetPerimeter_InputLengthAndWidth_OutputPerimeter16()
        {
            Rectangle rectangle = new Rectangle(3, 5);

            Assert.AreEqual(rectangle.GetPerimeter(), 16);
        }

        [TestMethod]
        public void TestGetPerimeter_InputSetNewLenghtAndWidth_OuputPerimeter60()
        {
            Rectangle rectangle = new Rectangle();
            rectangle.SetNewLength(20);
            rectangle.SetNewWidth(10);
            Assert.AreEqual(rectangle.GetPerimeter(), 60);
        }


        [TestMethod]
        public void TestGetArea_InputDefaultLengthAndWidth_OutputCalculatesArea()
        {

            Rectangle rectangle = new Rectangle();

            Assert.AreEqual(rectangle.GetArea(), 1);
        }

        [TestMethod]
        public void TestGetArea_InputLengthAndWidth_OutputCalculatesArea15()
        {
            int length = 3;
            int width = 5;

            Rectangle rectangle = new Rectangle(length, width);

            Assert.AreEqual(rectangle.GetArea(), 15);
        }

        [TestMethod]
        public void TestGetArea_InputSetNewLengthAndWidth_OutputCalculatesArea200()
        {
            Rectangle rectangle = new Rectangle();
            rectangle.SetNewLength(20);
            rectangle.SetNewWidth(10);
            Assert.AreEqual(rectangle.GetArea(), 200);
        }

    }
}

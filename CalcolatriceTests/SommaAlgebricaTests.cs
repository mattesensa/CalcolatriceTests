using Calcolatrice;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalcolatriceTests
{
    [TestClass]
    public class SommaAlgebricaTests
    {
        [TestMethod]
        public void TestMethodAdd()
        {
            //arrange
            int add1 = 0;
            int add2 = 2;
            int expected = 2;

            //act
            SommaAlgebrica sum = new SommaAlgebrica();
            int result = sum.Add(add1, add2);

            //assert
            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void TestMethodAddParams()
        {
            //arrange
            int[] addendi = {1, 2, 3 };
            int expected = 6;

            //act
            SommaAlgebrica sum = new SommaAlgebrica();
            int result = sum.Add(addendi);

            //assert
            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        [DataRow(new[] { 2,0,5 }, 7)]
        [DataRow(new[] { 4, 0, 9 }, 13)]
        [DataRow(new[] { 2, -1, 5 }, 6)]
        public void TestMethodAddDataRow(int[] addendi, int expected)
        {
            //arrange
            //int[] addendi = { 1, 2, 3 };
            //int expected = 6;

            //act
            SommaAlgebrica sum = new SommaAlgebrica();
            int result = sum.Add(addendi);

            //assert
            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        [DataRow(new[] { 1.1, 2.2, 3.3 }, 6.6)]
        [DataRow(new[] { 4.1, 0, 9.2 }, 13.3)]
        [DataRow(new[] { 2.4, -1, 5.6 }, 7.0)]
        public void TestMethodAddDataRow2(double[] addendi, double expected)
        {
            //arrange
            //int[] addendi = { 1, 2, 3 };
            //int expected = 6;

            //act
            SommaAlgebrica sum = new SommaAlgebrica();
            double result = sum.AddDouble(addendi);
            

            //assert
            Assert.AreEqual(expected, result);

        }
    }
}

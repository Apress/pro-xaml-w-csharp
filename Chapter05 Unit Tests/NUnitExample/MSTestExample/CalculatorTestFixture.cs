using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestExample
{
    [TestClass]
    public class CalculatorTestFixture
    {
        private ICalculator _Calculator;

        [TestInitialize]
        public void Initialize_Test()
        {
            //Create a new instance of the calculator class for each test.
            _Calculator = new Calculator();
        }

        [TestMethod]
        public void When_Adding_Two_Integers_The_Method_Should_Return_The_Sum()
        {
            var numberOne = 2;
            var numberTwo = 8;

            Assert.AreEqual(10, _Calculator.Add(numberOne, numberTwo));
        }

        [TestMethod]
        public void When_Subtracting_Two_Integers_The_Method_Should_Return_The_Difference()
        {
            var numberOne = 10;
            var numberTwo = 2;

            Assert.AreEqual(8, _Calculator.Subtract(numberOne, numberTwo));
        }

        [TestMethod]
        public void When_Multiplying_Two_Integers_The_Method_Should_Return_The_Product()
        {
            var numberOne = 2;
            var numberTwo = 2;

            Assert.AreEqual(4, _Calculator.Multiply(numberOne, numberTwo));
        }


        [TestMethod]
        [ExpectedException(typeof(System.DivideByZeroException))]
        public void When_Dividing_A_Number_By_Zero_The_Method_Should_Throw_A_DivideByZeroException()
        {
            var numberOne = 0;
            var numberTwo = 0;

            _Calculator.Divide(numberOne, numberTwo);
        }

        [TestCleanup]
        public void TearDown_Test()
        {
            //perform any necessary clean up
            _Calculator.Dispose();
        }
    }
}




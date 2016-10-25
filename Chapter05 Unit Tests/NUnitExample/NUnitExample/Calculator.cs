using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitExample
{
    /// <summary>
    /// Represents a primative calculator for demonstration purposes
    /// </summary>
    public class Calculator : ICalculator, IDisposable
    {
        #region ICalculator Members

        /// <summary>
        /// Add two integers and return the sum to the caller
        /// </summary>
        /// <param name="numberOne">a number to add</param>
        /// <param name="numberTwo">a number to add</param>
        /// <returns>The sum of the two input arguments</returns>
        public int Add(int numberOne, int numberTwo)
        {
            return numberOne + numberTwo;
        }

        /// <summary>
        /// Subtract two integers and return the difference to the caller
        /// </summary>
        /// <param name="numberOne">a number to subtract</param>
        /// <param name="numberTwo">a number to subtract</param>
        /// <returns>The difference between the two input arguments</returns>
        public int Subtract(int numberOne, int numberTwo)
        {
            return numberOne - numberTwo;
        }

        /// <summary>
        /// Divide two numbers
        /// </summary>
        /// <param name="numberOne">A number that should be divided by the seconde argument</param>
        /// <param name="numberTwo">A number to use to divide the first argument</param>
        /// <returns>The result of the division</returns>
        /// <remarks>Generally, you should always check for a DivideByZero exception, however, we are 
        /// leaving this out to demonstrate how to test for expected exceptions in unit tests.</remarks>
        public int Divide(int numberOne, int numberTwo)
        {
            return numberOne / numberTwo;
        }

        /// <summary>
        /// Multiply two integers and return the product to the caller
        /// </summary>
        /// <param name="numberOne">a number to multiply</param>
        /// <param name="numberTwo">a number to multiply</param>
        /// <returns>The product of the multiplication between the two numbers</returns>
        public int Multiply(int numberOne, int numberTwo)
        {
            return numberOne * numberTwo;
        }

        #endregion

        #region IDisposable Members

        /// <summary>
        /// if we had any unmanaged resources, we would free the associated resources here.
        /// </summary>
        public void Dispose()
        {
            Console.WriteLine("Clean as a whistle.");
        }

        #endregion
    }
}

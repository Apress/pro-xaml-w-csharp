using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MSTestExample
{
    public interface ICalculator : IDisposable
    {
        int Add(int numberOne, int numberTwo);
        int Subtract(int numberOne, int numberTwo);
        int Divide(int numberOne, int numberTwo);
        int Multiply(int numberOne, int numberTwo);

    }
}

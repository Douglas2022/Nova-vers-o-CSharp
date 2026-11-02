using Course10.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course10
{
    delegate void BinaryNumericOperation(double n1, double n2);
    internal class Program

    {  
        static void Main(string[] args)
        {
            double a = 10; double b = 12;

            BinaryNumericOperation op = CalculationServices.ShowSum;
            op += CalculationServices.ShowMax;

            op.Invoke(a, b);
            op(a, b);
        }
    }
}

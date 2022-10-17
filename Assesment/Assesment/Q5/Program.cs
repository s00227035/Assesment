using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //50000 € salary
            //10% inflation

            Console.WriteLine(Salary(50000, 0.1));
            Console.ReadLine();
        }

        static private double Salary(double number1, double number2)
        {         

            
            double myResult;
            myResult = number1 * number2;
            return myResult;
        }

        
    }

    
}

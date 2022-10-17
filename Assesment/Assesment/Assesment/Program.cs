using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter you year of birth: ");
            int yearOfBirth = int.Parse(Console.ReadLine());

            if (yearOfBirth >= 18)
            {
                Console.WriteLine("You can vote!");
            }
            else
            {
                Console.WriteLine("You can't vote!");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double rate;


            Console.WriteLine("Enter your residence: ");
            string residence = Console.ReadLine().ToLower();

            switch (residence)
            {
                case "sligo":
                    Console.WriteLine("Your discount rate is 30% ");
                    rate = 0.3
                        ; break;

                case "ireland":
                    Console.WriteLine("Your discount rate is 30% ");
                    rate = 0.3
                        ; break;
                case "europe":
                    Console.WriteLine("Your discount rate is 30% ");
                    rate = 0.3
                        ; break;
                case "other":
                    Console.WriteLine("Your discount rate is 30% ");
                    rate = 0.3
                        ; break;
                default:
                    break;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Worker w1 = new Worker();
            w1.Name = "Tom";
            w1.Type = "Plumber";
            w1.HourlyRate = 15;

            Worker w2 = new Worker();
            w2.Name = "Jo";
            w2.Type = "Electrician";
            w2.HourlyRate = 20;

            Console.WriteLine($"Name of the first worker: {w1.Name}, Type of work: {w1.Type}, Hourly Rate: {w1.HourlyRate}");
            Console.WriteLine($"Name of the first worker: {w2.Name}, Type of work: {w2.Type}, Hourly Rate: {w2.HourlyRate}");

            Console.ReadLine();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\S00227035\OneDrive - Atlantic TU\Documents\GitHub\Assesment\Test.txt";
            string[] fileContents = File.ReadAllLines(filePath);

            int totalRating = CalculateRating(fileContents);

            Console.WriteLine("The total ratings are {0]", totalRating);
            Console.ReadLine();
        }

        private static int CalculateRating(string[] data)
        {
            
            int[] firstMovie = new int[10] { 10, 7, 8, 5, 8, 7, 4, 8, 9, 7 };
            int[] secondMovie = new int[10] { 4, 6, 8, 3, 6, 7, 8, 6, 9, 7};
            int[] thirdMovie = new int[10] { 3, 7, 9, 5, 7, 4, 6, 7, 8, 6};

            //calculate total
            int totalRating = 0, points = 0, result = 0;

            for (int i = 0; i < data.Length; i++)
            {
                result = Convert.ToInt32(data[i]);

                //loop through rating
                for (int j = 0; j < firstMovie.Length; j++)
                {
                    points = (points + firstMovie[j]);
                    break;
                }
            }

            for (int k = 0; k < secondMovie.Length; k++)
            {
                points = (points + secondMovie[k]);
                break;
            }

            for (int l = 0; l < thirdMovie.Length; l++)
            {
                points = (points + secondMovie[l]);
                break;
            }

            totalRating += points;

            return totalRating;
        }
    }
}

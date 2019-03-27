using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonteCarlo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please specify the number of points");
            int numOfPoints = Convert.ToInt32(Console.ReadLine());

            XYcoord[] samplePoints = new XYcoord[numOfPoints];
            Random pointSeed = new Random();

            int insideCounter = 0;

            for(int i = 0; i<numOfPoints; i++)
            {              
                samplePoints[i] = new XYcoord(pointSeed);

                if (samplePoints[i].HypLength(samplePoints[i]) < 1)
                {
                    insideCounter++;
                }

            }

            double piEstmation = 4 * ((1.0 * insideCounter) / (1.0 * numOfPoints));
            double deviation = Math.Abs(piEstmation - Math.PI);
            Console.WriteLine($"{insideCounter} points inside of the circle\n" +
                $"Pi estimation: {piEstmation}\n" +
                $"Deviation: {deviation}");
            

//	Print the value from step #4 along with the absolute value of the difference between your 
//estimate of π and Math.Pi.

        }
    }
}

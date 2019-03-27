using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonteCarlo
{

    public struct XYcoord
    {
        public double x;
        public double y;

        public XYcoord(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        
        public XYcoord(Random item)
        {
            this.x = item.NextDouble();
            this.y = item.NextDouble();
        }

        public double HypLength(XYcoord coords)
            {
            double hypotenuse = Math.Sqrt(Math.Pow(coords.x, 2) + Math.Pow(coords.y, 2));
            return hypotenuse;
            }
    }





}



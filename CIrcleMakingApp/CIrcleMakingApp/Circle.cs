using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIrcleMakingApp
{
    class Circle
    {
        public double radius;


        public double GetDiameter()
        {
            return 2*radius;
        }
        public double GetPerimeter()
        {
            return GetDiameter()*3.1416;
        }

        public double GetArea()
        {
            return   3.1416*radius*radius;
        }
    }
}

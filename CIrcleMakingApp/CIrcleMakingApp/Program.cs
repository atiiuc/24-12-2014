using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIrcleMakingApp
{
    class Program
    {
        static void Main(string[] args){
        Circle aCircle=new Circle();

        //aCircle.radius = 10;

        aCircle.radius= Console.Read(); 
           

            Console.WriteLine(aCircle.GetDiameter()+"\n "+aCircle.GetPerimeter()+"\n "+aCircle.GetArea());
            Console.ReadKey();
        }
    }
}

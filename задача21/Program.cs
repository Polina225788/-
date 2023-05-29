using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x1: ");
            double x1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите y1: ");
            double y1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите z1: ");
            double z1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите x2: ");
            double x2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите y2: ");
            double y2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите z2: ");
            double z2 = double.Parse(Console.ReadLine());

            Console.WriteLine(Math.Sqrt(  (x1 - x2)*(x1 - x2) + (y1 - y2)*(y1 - y2) + (z1 - z2)*(z1 - z2) )  );
        }
    }
}

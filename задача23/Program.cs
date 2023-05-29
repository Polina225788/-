using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int N = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine($"{i} = {Math.Pow(i, 3)}") ;

            }
            
        }
    }
}

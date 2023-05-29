using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДОМАШКААААААААААААААААААААААААААААА
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите пятизначное число: ");
            int a = int.Parse(Console.ReadLine());

            int b = 4;

            string c = a.ToString();

            if (a < 10000 || a > 99999)
            {
                Console.WriteLine("Ошибка! Это число не является пятизначным");
                return;

            }
            for (int i = 0; i < 1; i++,b--)
            {
                if (c[i] != c[b])
                {
                    Console.WriteLine($"Число {a} не является палиндромом");
                    return;
                }    
            }
            Console.WriteLine($"Число {a} является палиндромом");
        }
    }
}

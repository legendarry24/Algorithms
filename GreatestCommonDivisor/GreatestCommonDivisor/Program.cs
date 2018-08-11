// Наибольший общий делитель. Алгоритм Евклида
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatestCommonDivisor
{
    class Program
    {
        static int GCD(int a, int b)
        {
            int temp;
            /* Находим остаток от деления a на b, записываем в а, и меняем числа местами пока b не равно 0,
             * после чего возвращаем а - это и будет наибольший общий делитель
             * Если b > a, то после первой итерации a и b просто свапнутся
            */
            while (b > 0)   
            {
                a %= b;
                temp = a;
                a = b;
                b = temp;
            }

            return a;
        }
        static void Main(string[] args)
        {
            int[] num = Array.ConvertAll((Console.ReadLine().Split(' ')), int.Parse); // ввод двух чисел в одну строку через пробел
            if (num[0] > 0 && num[1] > 0)
                 Console.WriteLine(GCD(num[0], num[1]));
            else 
                Console.WriteLine("Введены некоректные значения!");

            Console.ReadKey();
        }
    }
}
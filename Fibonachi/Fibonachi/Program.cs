/*Дано целое число 1≤ n ≤ 40, необходимо вычислить n-е число Фибоначчи
  (напомним, что F0=0, F1=1 и Fn=Fn−1+Fn−2 при n ≥ 2n ≥ 2).*/
using System;

namespace Fibonachi
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo ck;
            do
            {
                #region Вычисление числа Фибоначчи
                Console.Write("Введите порядковый номер числа Фибоначчи: ");
                int n = Convert.ToInt32(Console.ReadLine());
                int f0 = 0, f1 = 1;
                int fn = (n == 1) ? 1 : 0;
                for (int i = 2; i <= n; i++)
                {
                    fn = f0 + f1;
                    f0 = f1;
                    f1 = fn;
                }
                Console.WriteLine("{0}-е число Фибоначчи = {1}", n, fn);
                #endregion
                #region Фибоначчи через массив
                //Console.Write("Введите порядковый номер числа Фибоначчи: ");
                //int n = Convert.ToInt32(Console.ReadLine());
                //int[] f = new int[n];
                //f[0] = 0; f[1] = 1;
                //for (int i = 2; i <= n; i++)
                //{
                //    f[i] = f[i - 1] + f[i - 2];
                //}
                //Console.WriteLine("{0}-е число Фибоначчи = {1}", n, f[n]);
                #endregion
                #region Последняя цифра большого числа Фибоначчи
                //Console.Write("Введите порядковый номер числа Фибоначчи: ");
                //int n = Convert.ToInt32(Console.ReadLine());
                //int fn = 0, f0 = 0, f1 = 1;
                //fn = (n == 1) ? 1 : 0;
                //for (int i = 2; i <= n; i++)
                //{
                //    fn = f0 + f1;
                //    f0 = f1 % 10;
                //    f1 = fn % 10;
                //}
                //Console.WriteLine("Последняя цифра {0}-го число Фибоначчи = {1}", n, fn % 10);
                #endregion
                #region Hайти остаток от деления n-го числа Фибоначчи на m
                //Console.Write("Введите n: ");
                //int n = Convert.ToInt32(Console.ReadLine());
                //Console.Write("Введите m: ");
                //int m = Convert.ToInt32(Console.ReadLine());
                //int fn = 0, f0 = 0, f1 = 1;
                //fn = (n == 1) ? 1 : 0;
                //for (int i = 2; i <= n; i++)
                //{
                //    fn = f0 + f1;
                //    f0 = f1 % m;
                //    f1 = fn % m;
                //}
                //Console.WriteLine("Остаток от деления {0}-го числа Фибоначчи на {1} = {2}", n, m, fn % m);
                #endregion
                ck = Console.ReadKey(true); // ReadKey с параметром true не будет отображать в консоли нажатый символ (по умолчанию этот параметр false)
            }
            while (ck.Key != ConsoleKey.Escape);                            
        }
    }
}

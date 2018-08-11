// По данному числу n найдите максимальное число k, для которого n можно представить как сумму 
// k различных натуральных слагаемых. Выведите в первой строке число k, во второй — k слагаемых.
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Amount_of_summand
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch myStopwatch = new Stopwatch(); // подсчет времени выполнения программы
            myStopwatch.Start(); // запуск
            int n = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();            
            for (int i = 1; n > 0; i++)
            {
                if (n - i < i + 1 && n - i != 0)
                    continue;
                n -= i;
                list.Add(i);
            }
            Console.WriteLine(list.Count);
            foreach (int i in list)
            {
                Console.Write($"{i} ");
            }
            myStopwatch.Stop(); // остановить
            Console.WriteLine($"\n{myStopwatch.Elapsed}");           
            Console.ReadKey();
        }
    }
}
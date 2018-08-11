//Первая строка содержит количество предметов n и вместимость рюкзака W. 
//Каждая из следующих n строк задаёт стоимость ci и объём wi предмета(n, W, ci, wi — целые числа). 
//Выведите максимальную стоимость частей предметов (от каждого предмета можно отделить любую часть,
//стоимость и объём при этом пропорционально уменьшатся), помещающихся в данный рюкзак,
//с точностью не менее трёх знаков после запятой.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Continuous_backpack
{
    public class Item
    {
        public int Cost { get; set; }   // стоимость
        public int Weight { get; set; } // объём
    }   
    class Program
    {
        public static double MaxBackpackValue(int number, int capacity, List<Item> items)
        {
            double value = 0;
            // take items while there is empty space in backpack
            for (int i = 0; i < number; i++)
            {
                if (items[i].Weight <= capacity) // если предмет влазит полностью - запихиваем его полностью
                {
                    capacity -= items[i].Weight;
                    value += items[i].Cost;
                }
                else                      // если вместимости рюкзака не хватает - запихиваем часть предмета
                {
                    value += items[i].Cost * ((double) capacity / items[i].Weight);
                    break;
                }
            }
            return value;
        }
        static void Main(string[] args)
        {
            string[] buffer = Console.ReadLine().Split(' '); // буфер для ввода значений в одну строку через пробел
            int number = Convert.ToInt32(buffer[0]);         // количество предметов
            int capacity = Convert.ToInt32(buffer[1]);       // вместимость рюкзака
            List<Item> items = new List<Item>(number);
            for (int i = 0; i < number; i++)
            {
                buffer = Console.ReadLine().Split(' ');
                items.Add(new Item());
                items[i].Cost = Convert.ToInt32(buffer[0]);
                items[i].Weight = Convert.ToInt32(buffer[1]);
            }
            // сортировка списка с помощью Linq
            items = new List<Item>(items.OrderByDescending(i => (double)i.Cost / i.Weight));
            // результаты сортировки          
            //foreach (var item in items)
            //{
            //    Console.WriteLine("{0} {1}", item.Cost, item.Weight);
            //}
            // вывод с точностью в 3 знака после запятой 
            Console.WriteLine("{0:0.000}", MaxBackpackValue(number,capacity,items)); 
            Console.ReadKey();
        }
    }
}

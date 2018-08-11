using System;

namespace RearrangeArray
{
    class Program
    {
        //допустим {1,2,3,4,5} у тебя нашло 3 и как итог у нас теперь массив {3,1,2,4,5}
        public static int[] Rearrange(int[] array, int number)
        {
            if (number == array[0]) return array;

            int[] newArray = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == number)
                {
                    newArray[0] = array[i];
                    break;
                }                   
            }

            for (int i = 1, j = 0; i < array.Length; i++, j++)
            {
                if (array[i] != number)
                    newArray[i] = array[j];
                else
                    newArray[i] = array[j++];                                            
            }

            return newArray;
        }

        static void Main(string[] args)
        {
            int[] array = new [] {1, 2, 3, 4, 5};
            int number = int.Parse(args[0]);

            foreach (int item in Rearrange(array, number))
            {
                Console.Write($"{item} ");
            }
        }
    }
}

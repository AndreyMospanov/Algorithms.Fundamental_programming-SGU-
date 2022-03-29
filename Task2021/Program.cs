using System;

namespace Task2021
{
    /*Задан массив из n чисел (a1, a2,..., an).

    С ним два раза повторяют следующую процедуру: одновременно все максимумы в массиве делят на два. 
    Нечетные числа при делении на два следует округлять вниз. Ваша задача — вывести массив после этих действий.
    Входные данные
    В первой строке входного файла дано число n (1 ≤ n ≤ 100) — количество чисел в массиве. Во второй строке 
    через пробел записаны числа a1, a2,..., an (1 ≤ ai ≤ 100).
    Выходные данные
    Выведите массив после всех действий. Числа разделяйте пробелами.
     */
    class Program
    {
        static void Main(string[] args)
        {
            int arrLength, max;
            string[] input;
            int[] arr;

            arrLength = Convert.ToInt32(Console.ReadLine());
            input = Console.ReadLine().Split();
            arr = new int[arrLength];

            for (int i = 0; i < arrLength; i++)
            {
                arr[i] = Convert.ToInt32(input[i]);
                
            }
            
            for(int j = 0; j < 2; j++)
            {
                max = arr[0];
                for (int i = 0; i < arrLength; i++)
                {
                    max = max > arr[i] ? max : arr[i];
                }

                for (int i = 0; i < arrLength; i++)
                {
                    if (arr[i] == max)
                    {
                        arr[i] /= 2;
                    }                   
                }
            }
            for (int i = 0; i < arrLength; i++)
            {
                Console.Write("{0} ", arr[i]);
            }            
        }
    }
}

using System;

namespace Task2025
{
/*Рассмотрим простой вариант задачи RMQ (Range Minimum Query, запрос минимума на подмассиве).
Задан массив из n целых чисел (a1, a2,..., an) и m запросов вида (li, ri) (1 ≤ li ≤ ri ≤ n). 
Ваша задача — на каждый запрос вывести минимальный среди элементов с индексами от li до ri включительно.
Входные данные
В первой строке входного файла дано число n (1 ≤ n ≤ 100) — количество чисел в массиве. Во второй строке 
через пробел записаны целые числа a1, a2,..., an (1 ≤ ai ≤ 100). В третьей строке входного файла дано число m (1 ≤ m ≤ 100)
— количество запросов. Далее в m строках даны запросы по одному на строке в виде двух целых чисел li, ri, 
разделенных пробелом (1 ≤ li ≤ ri ≤ n).
Выходные данные
Выведите m чисел — ответы на запросы. Числа разделяйте пробелом или переводом строки.
На запросы следуюет отвечать в том порядке, в котором они заданы во входных данных.*/
    class Program
    {
        public static void MinArray(int[] arr, int index1, int index2)
        {
            index1--;
            index2--;
            int minimum = arr[index1];
            for(int i = index1; i <= index2; i++)
            {
                minimum = arr[i] < minimum ? arr[i] : minimum;
            }
            Console.WriteLine(minimum);
        }

        public static int[] ReqRead()
        {
            string[] input = Console.ReadLine().Split();
            int[] array = new int[2];
            for(int i = 0; i < 2; i++)
            {
                array[i] = Convert.ToInt32(input[i]);
            }
            return array;
        }
        static void Main(string[] args)
        {
            int arrLength = Convert.ToInt32(Console.ReadLine());
            string[] input = new string[arrLength];
            int[] arr = new int[arrLength];
            int requestCount;
            int[] request;
            

            input = Console.ReadLine().Split();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(input[i]);
            }
            
            requestCount = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < requestCount; i++)
            {
                request = ReqRead();
                MinArray(arr, request[0],request[1]);
            }
            //Console.ReadLine();
        }
    }
}

using System;

namespace Task2022
{
/*Задан массив n целых чисел (a1, a2,..., an). Ваша задача — найти количество пар индексов (i, j), что i ≠ j 
 * и ai делит aj. Обратите внимание, что пары (i, j) и (j, i) считаются различными
Входные данные
В первой строке входного файла дано число n (1 ≤ n ≤ 100) — количество чисел в массиве. 
Во второй строке через пробел записаны числа a1, a2,..., an (1 ≤ ai ≤ 100).
Выходные данные
Выведите единственное число — количество пар, удовлетворяющий условию.*/
    class Program
    {
        static void Main(string[] args)
        {
            int arrLength;
            int count = 0;
            string[] input;
            int[] arr;

            arrLength = Convert.ToInt32(Console.ReadLine());
            input = Console.ReadLine().Split();
            arr = new int[arrLength];

            for (int i = 0; i < arrLength; i++)
            {
                arr[i] = Convert.ToInt32(input[i]);                
            }

            for (int i = 0; i < arrLength; i++)
            {
                for (int j = 0; j < arrLength; j++)
                {
                    //Console.WriteLine($"arr i ={arr[i]} arr j = {arr[j]} count = {count}");
                    if (i != j && arr[i] % arr[j] == 0)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);  
        }
    }
}

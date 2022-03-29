using System;

namespace Task2024
{
    /*Последовательность чисел называется палиндромом, если она читается справа налево и слева направо одинаково. 
    Например, (1, 2, 1) и (12, 14, 14, 12) — палиндромы, а (1, 2, 3) и (4, 5, 5, 6) — нет.
    Дана последовательность из n элементов (a1, a2,..., an). Ваша задача — узнать, какое минимальное количество 
    элементов нужно заменить, чтобы последовательность стала палиндромом.
    Входные данные
    В первой строке входного файла дано число n (1 ≤ n ≤ 100) — количество чисел в массиве. 
    Во второй строке через пробел записаны числа a1, a2,..., an (1 ≤ ai ≤ 100).
    Выходные данные
    Выведите единственное число — минимальное количество элементов, которые нужно заменить, 
    чтобы последовательность стала палиндромом.*/
    class Program
    {
        static void Main(string[] args)
        {
            int arrLength;            
            string[] input;
            int[] arr;
            int count = 0;
            int searchIndex = 0;

            arrLength = Convert.ToInt32(Console.ReadLine());
            input = Console.ReadLine().Split();
            arr = new int[arrLength];

            for (int i = 0; i < arrLength; i++)
            {
                arr[i] = Convert.ToInt32(input[i]);
            }

            if(arrLength < 2)
            {
                count = 0;
            }
            else if (arrLength % 2 == 0)                
            {
                searchIndex = arrLength / 2;//отмечаем индекс середины массива
                for (int i = (arrLength / 2) - 1; i >= 0; i--)
                {
                    if (arr[i] != arr[searchIndex])
                    {
                        count++;
                    }
                    searchIndex++;
                }
            }
            else
            {
                searchIndex = arrLength / 2 + 1;// вторая половина массива начинается на 1 дальше от среднего
                for (int i = (arrLength / 2) - 1; i >= 0; i--)
                {
                    if (arr[i] != arr[searchIndex])
                    {
                        count++;
                    }
                    searchIndex++;
                }
            }            
            
            Console.WriteLine(count);
            
        }
    }
}

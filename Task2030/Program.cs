using System;

namespace Task2030
{
/*Задан массив из n чисел (a1, a2,..., an). Ваша задача — подсчитать количество пар (i, j), 1 ≤ i ≤ j ≤ n, 
что сумма чисел, стоящих на позициях i, i+1,..., j-1, j равна 0.Входные данные
В первой строке задано число n (1 ≤ n ≤ 2000). Во второй строке заданы целые числа 
a1, a2,..., an, которые записаны через пробел (-100 ≤ ai ≤ 100).
Выходные данные
Выведите в выходной файл единственное число — количество искомых пар.
*/
    class Program
    {
        private static int[] ReadArray(int arrLength)
        {
            string[] input = Console.ReadLine().Split();
            int[] array = new int[arrLength];
            for (int i = 0; i < arrLength; i++)
            {
                array[i] = Convert.ToInt32(input[i]);
            }
            return array;
        }

        private static void Calculate(int[] arr, int arrLength)
        {
            int count = 0;            
            int sum;
            
            for(int i = 0; i < arrLength; i++)
            {
                for(int j = i; j < arrLength; j++)
                {
                    sum = 0;
                    for (int num = i; num <= j; num++)
                    {
                        sum += arr[num];
                    }
                    if(sum == 0)
                    {
                        count++;
                    }
                    //Console.WriteLine($"arr[{i}] = {arr[i]}, arr[{j}] = {arr[j]}, sum = {sum}");
                }
            }
            Console.WriteLine(count);
        }
        static void Main(string[] args)
        {
            int arrLength;
            int[] arr;

            arrLength = Convert.ToInt32(Console.ReadLine());
            arr = ReadArray(arrLength);
            Calculate(arr, arrLength);
            //Console.ReadLine();
        }
    }
}

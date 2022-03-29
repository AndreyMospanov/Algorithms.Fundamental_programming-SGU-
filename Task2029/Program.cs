using System;

namespace Task2029
{
/*Задан массив из n чисел (a1, a2,..., an). Ваша задача — найти позицию среднего элемента среди минимальных в массиве.
Обратите внимание, что если минимальных чисел в массиве четное количество, то средних элементов два. 
В этом случае нужно вывести минимальную позицию среди средних элементов.
Входные данные
В первой строке входного файла дано число n (1 ≤ n ≤ 100) — количество чисел в массиве. 
Во второй строке через пробел записаны целые числа a1, a2,..., an (1 ≤ ai ≤ 100).
Выходные данные
Выведите единственное число — позицию среднего элемента среди минимальных в массиве.*/
    class Program
    {
        public static int[] ReadArray(int arrLength)
        {
            string[] input = Console.ReadLine().Split();
            int[] array = new int[arrLength];
            for (int i = 0; i < arrLength; i++)
            {
                array[i] = Convert.ToInt32(input[i]);
            }
            return array;
        }
        public static void Calculate(int[] arr, int arrLength)
        {
            int minimum = arr[0];
            int count = 0;
            int index = 1;
            int answer = 0;
            //вычисляем минимум
            for (int i = 0; i < arrLength; i++)
            {
                if(arr[i] < minimum)
                {
                    minimum = arr[i];
                }
            }
            //вычисляем количество минимумов в массиве
            for (int i = 0; i < arrLength; i++)
            {
                if(arr[i] == minimum)
                {
                    count++;
                }
            }
            //Console.WriteLine($"Debug count = {count}");
            //вычисляем индекс среднего элемента
            if(count % 2 == 0)
            {                
                for (int i = 0; i < arrLength; i++)
                {
                    if (index <= count / 2 && arr[i] == minimum)
                    {                       
                        answer = i + 1;
                        index++;
                    }
                }                
            }
            else if(count % 2 == 1)
            {                
                for (int i = 0; i < arrLength; i++)
                {
                    if (index <= count / 2 + 1 && arr[i] == minimum)
                    {                       
                        answer = i +1 ;
                        index++;
                    }
                }
            }//Console.WriteLine($"Index = {index}");
            Console.WriteLine(answer);
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

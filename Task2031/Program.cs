using System;

namespace Task2031
{
/*Задан массив из n чисел (a1, a2,..., an). Ваша задача — найти все числа, которые встречаются в массиве больше одного раза.
Обратите внимание, что каждое число, удовлетворяющее условию, следует выводить ровно один раз.
Входные данные
В первой строке входного файла дано число n (1 ≤ n ≤ 100) — количество чисел в массиве. 
Во второй строке через пробел записаны числа a1, a2,..., an (1 ≤ ai ≤ 100).
Выходные данные
В первую строку выведите единственное число — количество чисел, которые встречаются больше одного раза. 
Во вторую строку — сами значения. Числа выводите в возрастающем порядве, при выводе разделяйте пробелом. Каждое число выводите ровно один раз.*/
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
        private static void FindNonUnique(int[] arr, int arrLength)
        {
            bool[] unique = new bool[arrLength];
            int count = 0;
            
            //заполняем правдой массив булевых 
            for (int i = 0; i < arrLength; i++)
            {
                unique[i] = true;
            }

            Array.Sort(arr);

            //вычисляем неуникальные члены массива
            for (int i = 0; i < arrLength; i++)
            {
                for(int j = 0; j < arrLength; j++)
                {
                    if(arr[i] == arr[j] && i != j)
                    {
                        unique[i] = false;
                    }
                }
            }
            
            //считаем количество неуникальных элементов
            for (int i = 0; i < arrLength; i++)
            {                
                if (i == 0 && !unique[i])
                {
                    count++;
                }
                else if (!unique[i] && arr[i] != arr[i - 1])
                {
                    count++;
                }  
            }
            Console.WriteLine(count);

            //Выводим неуникальные числа 
            if( count != 0)
            {
                for (int i = 0; i < arrLength; i++)
                {
                    if (i == 0 && !unique[i])
                    {
                        Console.Write("{0} ", arr[i]);
                    }
                    else if (!unique[i] && arr[i] != arr[i - 1])
                    {
                        Console.Write("{0} ", arr[i]);
                    }
                }
            }  
        }
        static void Main(string[] args)
        {
            int arrLength;
            int[] arr;

            arrLength = Convert.ToInt32(Console.ReadLine());
            arr = ReadArray(arrLength);
            FindNonUnique(arr, arrLength);
            //Console.ReadLine();
        }
    }
}

using System;

namespace Task2028
{
    /*Задан массив из n целых чисел (a1, a2,..., an). Каждое число равно или 0, или 1, или 2, или 3, или 4. 
    Ваша задача — подсчитать сколько каких чисел встречается в массиве.
    Входные данные
    В первой строке входного файла дано число n (1 ≤ n ≤ 100) — количество чисел в массиве. 
    Во второй строке через пробел записаны числа a1, a2,..., an (0 ≤ ai ≤ 4).
    Выходные данные
    Выведите в выходной файл все пары вида (x, cntx), где x — значение, cntx — сколько раз оно встречается в массиве. 
    Числа в паре разделяйте пробелом, каждую пару выводите на отдельной строке, причем, пары выводите в порядке возрастания x. 
    Не выводите пару, если cntx равно 0.*/
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
        public static void LogicImplement(int[] arr, int arrLength)
        {
            int[] count = new int[5];
            for(int i = 0; i < 5; i++)
            {
                count[i] = 0;
            }

            for(int num = 0; num < 5; num++)
            {
                for (int i = 0; i < arrLength; i++)
                {
                    if(arr[i] == num)
                    {
                        count[num]++;
                    }
                }
            }
            
            for (int i = 0; i < 5; i++)
            {
                if(count[i] > 0)
                {
                    Console.WriteLine("{0} {1}", i, count[i]);
                }
            }

        }
        static void Main(string[] args)
        {
            int arrLength;
            int[] arr; 

            arrLength = Convert.ToInt32(Console.ReadLine());
            arr = ReadArray(arrLength);
            LogicImplement(arr, arrLength);            

            //Console.ReadKey();
        }
    }
}

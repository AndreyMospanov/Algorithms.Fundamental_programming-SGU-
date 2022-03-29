using System;
using System.Collections.Generic;
using System.Linq;

namespace Task2052
{
/*Дана последовательность из n чисел a1, a2,..., an. C ней последовательно производят k операций: на i-ом шаге из этой последовательности 
одновременно вычеркивают все числа, стоящие на позициях с номерами, кратными bi (позиции нумеруются с 1).
Ваша задача — промоделировать это процесс и вывести массив после выполения всех операций.
Входные данные
Первая строка входного файла содержит числа n и k — количество элементов в последовательности и количество операций 
(1 ≤ n ≤ 10^5, 1 ≤ k ≤ 10). Во второй строке находится последовательность a1, a2,..., an (1 ≤ ai ≤ 109).
В третьей строке находится последовательность b1, b2,..., bk (1 ≤ bi ≤ 10^5).
Выходные данные
Выведите последовательность после применения всех операций.*/
    class Program
    {
        private static int[] ReadArray(int arrLength)
        {
            string[] input;
            int[] array;
            input = Console.ReadLine().Split(' ');
            array = new int[arrLength];
            for (int i = 0; i < arrLength; i++)
            {
                array[i] = Convert.ToInt32(input[i]);
            }
            return array;
        }
        private static void Calculate(int[] array, int[] oper)
        {
            List<int> arr = array.ToList<int>();
            for(int i = 0; i < oper.Length; i++)
            {
                for(int k = arr.Count - 1; k > -1; k--)
                {
                    if((k + 1) % oper[i] == 0)
                    {
                        //Console.WriteLine("debug to remove k = {0}", k);
                        arr.RemoveAt(k);
                    }
                }
            }
            foreach(int i in arr)
            {
                Console.Write("{0} ", i);
            }

        }
        static void Main(string[] args)
        {
            int arrLength;
            int operLength;
            int[] array;
            int[] oper;
            int[] lengths;
            lengths = ReadArray(2);
            arrLength = lengths[0];
            operLength = lengths[1];
            array = ReadArray(arrLength);
            oper = ReadArray(operLength);

            Calculate(array, oper);
            //Console.ReadLine();
        }
    }
}

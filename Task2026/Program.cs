using System;

namespace Task2026
{
/*Задан массив a. Требуется каждый его элемент заменить на ближайший справа больший. 
 * Результаты замен не влияют на другие, то есть считайте, что все замены производятся одновременно. 
 * Если справа нет большего элемента, то замените элемент на число 0.
Входные данные
В первой строке записано целое положительное число n (1 ≤ n ≤ 10000), где n — длина заданного массива. 
Вторая строка содержит последовательность a1, a2,..., an (1 ≤ ai ≤ 10000) — последовательность элементов заданного массива.
Выходные данные
Выведите все элементы массива после замен. Числа разделяйте пробелами.*/
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

        public static void WriteArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }
        }

        public static int[] LogicImplement(int[] array)
        {
            int[] answerArray = new int[array.Length];
            for(int i = 0; i < array.Length; i++)
            {
                for(int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        answerArray[i] = array[j];
                        break;
                    }                   
                }               
            }
            return answerArray;
        }
        static void Main(string[] args)
        {
            int arrLength;
            int[] arr;
            int[] answerArray;

            arrLength = Convert.ToInt32(Console.ReadLine());
            answerArray = new int[arrLength];
            arr = ReadArray(arrLength);
            answerArray = LogicImplement(arr);
            WriteArray(answerArray);
            //Console.ReadKey();
        }
    }
}

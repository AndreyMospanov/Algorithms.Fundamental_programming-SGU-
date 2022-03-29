using System;

namespace Task2027
{
    /*Задан массив из n чисел (a1, a2,..., an). На нем два раза осуществляют операцию переворота 
    подмассива: первый раз с позиции l1 по r1, второй раз с позиции l2 по r2.
    При перевороте подмассива порядок элементов в нем меняется на обратный.
    Ваша задача — найти последовательность после осуществления переворотов.
    Входные данные
    В первой строке входного файла дано число n (1 ≤ n ≤ 100) — количество чисел в массиве. 
    Во второй строке через пробел записаны целые числа a1, a2,..., an (1 ≤ ai ≤ 100). 
    В третьей строке записаны через пробел числа l1 и r1 (1 ≤ l1 ≤ r1 ≤ n), в четвертой — числа l2 и r2 (1 ≤ l2 ≤ r2 ≤ n).
    Выходные данные
    Выведите последовательность (a1, a2,..., an) после осуществления переворотов. Числа разделяйте пробелом.*/
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

        public static int[] LogicImplement(int[] array, int arrLength)
        {            
            string[] inputRequest = new string[2];
            int request1, request2;
            int index;
            int[] answerArray = new int[arrLength];
            for(int i = 0; i < arrLength; i++)
            {
                answerArray[i] = array[i];
            }

            for (int i = 0; i < 2; i++)
            {
                if(i == 1)
                {
                    for (int j = 0; j < arrLength; j++)
                    {
                        array[j] = answerArray[j];                        
                    }
                }
                

                inputRequest = Console.ReadLine().Split();
                request1 = Convert.ToInt32(inputRequest[0]) - 1;
                request2 = Convert.ToInt32(inputRequest[1]) - 1;
                index = request2;

                for (int j = 0; j < arrLength; j++)
                {
                    if(request1 <= index)
                    {
                        answerArray[request1] = array[request2];
                        //Console.WriteLine($"req1 = {request1} req2 = {request2} answer arr[r1] = {answerArray[request1]} array[r2] = {array[request2]}");

                        request1++;
                        request2--;
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
            answerArray = LogicImplement(arr, arrLength);
            WriteArray(answerArray);
            //Console.ReadKey();
        }
    }
}

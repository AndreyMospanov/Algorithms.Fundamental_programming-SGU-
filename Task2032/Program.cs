using System;

namespace Task2032
{
/*Заданы два длинных положительных целых числа в виде массивов своих цифр. Необходимо произвести их сравнение и вывести:
-1, если первое число меньше второго,
0, если первое число равно второму,
1, если первое число больше второго.
Входные данные
В первой строке записано целое число n (1 ≤ n ≤ 1000), n — количество цифр в первом числе в заданном числе. 
Вторая строка содержит описание числа в виде последовательности цифр, которые заданы через пробел. 
ифры заданы слева направо (от старшей к младшей). Заданное число — положительное, первая (старшая) цифра отлична от 0.
Третья и четвертая строки содержат описание целого положительного числа в полностью идентичном формате.
Выходные данные
Выведите -1, 0 или 1.*/
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
        private static long ArrayToNumber(int[] arr, int arrLength)
        {
            int power = 0;
            long num = 0;
            for(int i = arrLength - 1; i >= 0; i--)
            {
                num += arr[i] * Convert.ToInt32(Math.Pow(10, power));
                power++;
            }
            return num;
        }
        private static void ArrayComparison(int[] arr1, int[] arr2, int arrLength)
        {
            for (int i = 0; i < arrLength; i++)
            {
                if (arr1[i] > arr2[i])
                {
                    Console.WriteLine(1);
                    break;
                }
                else if (arr1[i] < arr2[i])
                {
                    Console.WriteLine(-1);
                    break;
                }

                if (i == arrLength - 1 && arr1[arrLength - 1] == arr2[arrLength - 1])
                {
                    Console.WriteLine(0);
                }
            }
        }
        static void Main(string[] args)
        {
            int arr1Length, arr2Length;
            //long num1, num2;
            int[] arr1, arr2;

            arr1Length = Convert.ToInt32(Console.ReadLine());
            arr1 = ReadArray(arr1Length);
            arr2Length = Convert.ToInt32(Console.ReadLine());
            arr2 = ReadArray(arr2Length);
            #region Convert To Number
            /*num1 = ArrayToNumber(arr1, arr1Length);
            num2 = ArrayToNumber(arr2, arr2Length);
            if (num1 < num2)
            {
                Console.WriteLine(-1);
            }
            else if (num2 < num1)
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(0);
            }*/
            #endregion

            if(arr1Length > arr2Length)
            {
                Console.WriteLine(1);
            }
            else if(arr1Length < arr2Length)
            {
                Console.WriteLine(-1);
            }
            else if(arr1Length == arr2Length)
            {
                ArrayComparison(arr1, arr2, arr1Length);
            }
            //Console.ReadLine();
        }
    }
}

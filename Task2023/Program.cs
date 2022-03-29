using System;

namespace Task2023
{
/*Заданы два массива целых положительных чисел: a и b. Ваша задача сформировать такой массив c, содержащий все элементы массива a, которые встречаются в b. 
В массиве c элементы должны идти в том же порядке, что и a, просто пропускайте те элементы, что не присутствуют в b.
Входные данные
В первой строке записано целое положительное число n (1 ≤ n ≤ 10000), n — количество элементов массива a. 
Вторая строка содержит n целых чисел: a1, a2,..., an (1 ≤ ai ≤ 10000). Числа записаны через пробел.
Третья и четвертая строки содержат описание массива b в формате, полностью совпадающем с форматом описания массива a.
Выходные данные
Выведите искомый массив c в формате, повторяющем формат массивов во входных данных. Если искомый массив пустой, то в первую строку выведите 0, а вторую оставьте пустой.*/
    class Program
    {
        static void Main(string[] args)
        {
            int arrLength, arr2Length;
            int index = 0;           
            string[] input;
            string[] input2;
            int[] arr;
            int[] arr2;
            int[] arr3;
            bool[] boolSheet;

            arrLength = Convert.ToInt32(Console.ReadLine());
            input = Console.ReadLine().Split();
            arr = new int[arrLength];

            for (int i = 0; i < arrLength; i++)
            {
                arr[i] = Convert.ToInt32(input[i]);
            }

            arr2Length = Convert.ToInt32(Console.ReadLine());
            input2 = Console.ReadLine().Split();
            arr2 = new int[arr2Length];

            for (int i = 0; i < arr2Length; i++)
            {
                arr2[i] = Convert.ToInt32(input2[i]);
            }

            //logic
            arr3 = new int[arrLength];
            boolSheet = new bool[arrLength];
            
            for (int i = 0; i < arrLength; i++)
            {
                boolSheet[i] = false;
            }

            for (int i = 0; i < arrLength; i++)
            {
               for(int j = 0; j < arr2Length; j++)
                {
                    if(arr[i] == arr2[j])
                    {
                        boolSheet[i] = true;
                        arr3[index] = arr[i];
                        //Console.WriteLine($"Debug: arr3 i = {arr3[i]}");
                        index++;                        
                        break;
                    }
                }
            }
            //Console.WriteLine($"Debug: arr3 length = {arr3.Length}");
            Console.WriteLine(index);
            
            for (int i = 0; i < arrLength; i++)
            {
                if(boolSheet[i])
                {
                    Console.Write("{0} ", arr[i]);
                }
            }

            //Console.ReadLine();
        }
    }
}

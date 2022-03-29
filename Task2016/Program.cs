using System;

namespace Task2016
{
/*Задано уравнение вида Ax2+Bx+C=0. В этом уравнении каждый коэффициент может принимать любое значение от -100 до 100, включительно. 
Такое уравнение может иметь 0, 1, 2 или даже бесконечное количество различных корней.
Напишите программу, которая выведет количество корней этого уравнения.
Входные данные
Единственная строка входных данных содержит целые числа A, B, C (-100 ≤ A,B,C ≤ 100).
Выходные данные
Выведите количество корней или число -1, если уравнение имеет бесконечное количество корней.*/
    class Program
    {
        static void Main(string[] args)
        {
            //Ax2+bx+c=0
            string[] input = new string[3];
            int[] nums = new int[3];
            int a, b, c, D;            
            input = Console.ReadLine().Split();
            for(int i = 0; i < 3; i++)
            {
                nums[i] = Convert.ToInt32(input[i]);
            }
            a = nums[0];
            b = nums[1];
            c = nums[2];

            D = Convert.ToInt32(Math.Pow(b, 2)) - 4 * a * c;

            if (a == 0 && b == 0 && c == 0)
            {
                Console.WriteLine(-1);
            }
            else if(a == 0 && b == 0 && c != 0)
            {
                Console.WriteLine(0);
            }
            //v.2
            else if(a != 0 && b == 0 && c == 0 || a == 0)
            {
                Console.WriteLine(1);
            }
            else if(b == 0 && c != 0 && (-1 * (c / a)) < 0)
            {
                Console.WriteLine(0);
            }
            else if(b == 0 && c != 0 && (-1 * (c / a)) > 0)
            {
                Console.WriteLine(2);
            }
            /*else if(b != 0 && c == 0)
            {
                Console.WriteLine(2);
            }*/
            //v.1
            else if (D > 0)
            {
                Console.WriteLine(2);
            }
            else if (D == 0)
            {
                Console.WriteLine(1);
            }
            else
                Console.WriteLine(0);
        }
    }
}

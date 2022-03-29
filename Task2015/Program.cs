using System;

namespace Task2015
{
/*Простое число — это натуральное число, которое имеет ровно два различных натуральных делителя: единицу и самого себя. 
Последовательность простых чисел начинается так: 2, 3, 5, 7, 11, 13, 17, 19, 23,...
Напишите программу, которая выведет все простые числа на отрезке [1,n] в порядке возрастания.
Входные данные
В единственной строке входных данных записано целое число n (1 ≤ n ≤ 10000).
Выходные данные
Выведите все простые числа на отрезке [1,n] по возрастанию по одному в строке.*/
    class Program
    {
        static void Main(string[] args)
        {
            int max = Convert.ToInt32(Console.ReadLine());
            bool isNatural = false;
            if(max > 1)
            {
                Console.WriteLine(2);
            }            
            for(int i = 3; i < max + 1; i++)
            {
               
                for(int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isNatural = false;
                        break;
                    }
                    else
                    {
                        isNatural = true;                        
                    }                    
                }

                if (isNatural)
                {
                    Console.WriteLine(i);
                }
            }            
        }        
    }
}

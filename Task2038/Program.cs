using System;
using System.Text.RegularExpressions;
using System.Text;

namespace Task2038
{
    /*Определим слово как последовательность латинских букв алфавита. Все остальные символы являются разделителями.
Дан текст, состоящий из символов с номерами от 32 до 127 (см. таблицу символов ASCII).
Ваша задача — найти количество букв в наидлинейшем слове из этого текста.*/
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            string[] words;
            int max;
            
            input = Console.ReadLine();                    
            input = Regex.Replace(input, @"[^a-zA-Z]", " ");
            input = Regex.Replace(input, @"\s+", " ");
            words = input.Split(' ');
            max = words[0].Length;
            Console.WriteLine(input);

            for (int i = 0; i < words.Length; i++)
            {
                if(words[i].Length > max)
                {
                    Console.WriteLine(words[i]);
                    max = words[i].Length;
                }
            }
            Console.WriteLine(max);
            //Console.ReadKey();
        }
    }
}

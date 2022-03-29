using System;
using System.Text.RegularExpressions;
using System.Text;

namespace Task2038
{
    /*Определим слово как последовательность латинских букв алфавита. Все остальные символы являются разделителями.
    Дан текст, состоящий из символов с номерами от 32 до 127 (см. таблицу символов ASCII). 
    Ваша задача — подсчитать количество слов в этом тексте.*/
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            string[] words;
            int minus = 0;
            
            input = Console.ReadLine();
            input = Regex.Replace(input, @"[^a-zA-Z]", " ");
            input = Regex.Replace(input, @"\s+", " ");
            words = input.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {                
                if (words[i] == "")
                {
                    minus++;                   
                }
            }
            
            Console.WriteLine(words.Length - minus);
            //Console.ReadKey();
        }
    }
}

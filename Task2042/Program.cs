using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Task2042
{
/*Дан текст, состоящий из строчных латинских букв, и шаблон, состоящий из строчных латинских букв и знаков вопроса. 
 * Знак вопроса может обозначить любую букву. Например, строки "abaca" и "??ac?" равны, а "aba" и "?c?" — нет.
Ваша задача — вывести все позиции вхождения шаблона в текст.
Входные данные
В первой строке входных данных содержится текст, состоящий только из строчных латинских букв. 
Во второй строке содержится шаблон, состоящий из строчных латинских букв и знаков вопроса. Длины текста и шаблона не менее 1 и не более 1000 символов.
Выходные данные
Выведите все позиции вхождения шаблона в текст в возрастающем порядке. Числа разделяйте пробелами. Позиции в строке нумеруются с 1.*/
    class Program
    {
        static List<int> FindIndexes(List<int> indexes,string input, string substring)
        {
            Regex regex = new Regex(substring);
            MatchCollection matches;
            for (int i = 0; i < input.Length; i++)
            {
                matches = regex.Matches(input, i);
                if (matches.Count > 0)
                {
                    for (int k = 0; k < matches.Count; k++)
                    {
                        indexes.Add(matches[k].Index + 1);
                    }
                }
            }
            indexes.Sort();
            indexes = RemoveDoublers(indexes);
            return indexes;
        }
        static List<int> RemoveDoublers(List<int> indexes)
        {
            for (int i = 0; i < indexes.Count; i++)
            {
                for (int j = i + 1; j < indexes.Count; j++)
                {
                    if (indexes[i] == indexes[j])
                    {
                        indexes[j] = 0;
                    }
                    if(indexes[j] > indexes[i])
                    {
                        break;
                    }
                }
            }   
                
            return indexes;
        }
        static void Main(string[] args)
        {
            string input;
            string substring;            
            List<int> indexes = new List<int>();

            input = Console.ReadLine();
            substring = Console.ReadLine();

            substring = substring.Replace('?', '.');
            
            indexes = FindIndexes(indexes, input, substring);

            for (int k = 0; k < indexes.Count; k++)
            {
                if (indexes[k] != 0)
                    Console.Write("{0} ", indexes[k]);
            }            
            
            //Console.ReadKey();
        }
    }
}

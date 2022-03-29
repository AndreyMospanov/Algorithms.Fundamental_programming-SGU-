using System;
using System.Collections.Generic;
using System.Text;

namespace Task2044
{
/*Рассмотрим алгоритм кодирования по Хаффману.Каждый символ представляется последовательностью символов 0 и 1, причем никакая последовательность не является началом другой.
 * Закодированный текст представляет собой сконкатенированные последовательности букв.Например, если e = 001, t = 01, x = 000, то text=0100100001.
Вам даны коды некоторых букв латинского алфавита, а также текст в закодированном виде.Ваша задача — раскодировать его. Гарантируется, что текст составлен корректно.
Входные данные
Первая строка входного файла содержит единстенное число n — количество букв, используемых в тексте.Далее в n строках находятся пары из символа и последовательности, 
его кодирующей. Все символы — это строчные латинские буквы. Кодирующая последовательность — строка из символов 0 и 1, длиной не более 30 символов.Символ и код разделены одним пробелом. 
Последняя строка входных данных содержит закодированный текст длиной не более 1000 символов.
Выходные данные
Выведите полученный после декодирования текст.*/
    class Program
    {
        static void Main(string[] args)
        {            
            int symbolsCount;
            string[] input = new string[2];
            string word;
            StringBuilder decode = new StringBuilder();
            int index;
            Dictionary<string, string> code = new Dictionary<string, string>();
            symbolsCount = Convert.ToInt32(Console.ReadLine());           
            for(int i = 0; i < symbolsCount; i++)
            {
                input = Console.ReadLine().Split(' ');
                code.Add(input[0], input[1]);
            }

            word = Console.ReadLine();            
            while(word.Length != 0)
            {
                foreach (var symb in code)
                {
                    if (word.Contains(symb.Value))
                    {
                        index = word.IndexOf(symb.Value);
                        if (index == 0)
                        {
                            word = word.Remove(0, symb.Value.Length);
                            decode.Append(symb.Key);
                            //Console.WriteLine($"{decode} {word}");
                        }
                    }
                }
            }
                
            Console.WriteLine(decode);
            //Console.ReadKey();
        }
    }
}

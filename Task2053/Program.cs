using System;
using System.Text;

namespace Task2053//slow code
{
/*Дан текст, который состоит только из латинских букв, пробелов, переводов строк.
Слово — это последовательность подряд идущих латинских букв, регистр не имеет значения.
Ваша задача — зашифровать текст. В процессе шифрования каждому слову присваивается уникальный 
идентификатор — число от 1 до n, где n — количество различных слов в данном тексте.
если текущее слово встречается первый раз, то ему присваивается новый идентификатор, который ранее еще не использовался (т.е. по порядку 1, 2,...).
если текущее слово ранее уже встречалось, то новый идентификатор не присваивается, а используется уже существующий
Ваша задача — вывести зашифрованный текст в виде числовой последовательности.
Входные данные
Входные данные состоят только из латинских букв, пробелов и символов перевода строки. Гарантируется, что хотя бы одно слово в текст присутствует
Выходные данные
Выведите зашифрованный текст в виде числовой последовательности. Числа разделяйте пробелами.*/
    class Program
    {
        private static string[] ReadText()
        {
            string inputLine;
            string[] text;
            char[] space = { ' ' };
            StringBuilder input = new StringBuilder();

            inputLine = Console.ReadLine();
            
            while /*(inputLine.Length != 0)*/(inputLine != null)
            {
                input.Append(inputLine + ' ');
                inputLine = Console.ReadLine();
            }

            inputLine = input.ToString().ToLower();
            
            input.Clear();
            input.Append(inputLine);
            for (int i = 0; i < input.Length; i++)
            {                
                if (input[i] == '\\')
                {
                    input[i] = ' ';
                    i++;
                    input[i] = ' ';                    
                }
            }            
            text = input.ToString().Split(space, StringSplitOptions.RemoveEmptyEntries);
            return text;
        }      
        
        static void Main(string[] args)
        {
            string[] text = ReadText();            
            int[] code = new int[text.Length];
            int indexCode = 1;
            bool match = false;
            code[0] = indexCode;

            for (int i = 1; i < text.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (text[i] == text[j])
                    {
                        code[i] = code[j];
                        match = true;
                        break;
                    }
                }
                if (!match)
                {
                    indexCode++;
                    code[i] = indexCode;
                }
                match = false;
            }
            for (int i = 0; i < code.Length; i++)
            {
                Console.Write("{0} ", code[i]);
            }            
            //Console.ReadKey();
        }
    }
}

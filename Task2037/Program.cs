using System;
using System.Text;
/*Дан текст, состоящий только из маленьких латинских букв и запятых. 
 Последовательность подряд идущих букв, окруженную запятыми (началом, концом строки), назовем словом. Слово может быть пустым.
Ваша задача — удалить из текста все слова короче k символов.*/

namespace Task2037
{
    class Program
    {
        static void Main(string[] args)
        {            
            string[] words;
            int min;

            words = Console.ReadLine().Split(',');
            min = Convert.ToInt32(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            foreach(string word in words)
            {
                if(word.Length >= min)
                {
                    sb.Append(word);
                    sb.Append(',');
                }
            }
            if(sb.Length > 0)
            {
                sb.Remove(sb.Length - 1, 1);
            }            
            Console.Write(sb);
            Console.ReadLine();
        }
    }
}

using System;
using System.Text;

/*Дан текст, состоящий из латинских букв, пробелов и знаков препинания (точка, запятая, восклицательный и вопросительный знаки). 
 Слово — это последовательность подряд идущих латинских букв.
Ваша задача — расставить пробелы*/
//galileo galilei was an   italian physicist  ,mathematician,astronomer
namespace Task2045
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input;
            char[] punctuations = { '.', ',', '!', '?' };
            char[] temp;
            input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder answer = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                temp = input[i].ToCharArray();
                for (int k = 0; k < temp.Length; k++)
                {
                    for (int j = 0; j < 4; j++)
                    {

                        if (temp[k] == punctuations[j])
                        {
                            if(k == 0)
                            {
                                answer.Remove(answer.Length - 1, 1);
                            }
                            answer.Append(temp[k]);
                            answer.Append(" ");
                            break;
                        }
                        else if (j == 3 && temp[k] != punctuations[j])
                        {
                            answer.Append(temp[k]);
                        }                        
                    }
                    if (k == temp.Length - 1 && answer[answer.Length - 1] != ' ')
                    {
                        answer.Append(" ");
                    }
                }                
            }
            answer.Remove(answer.Length - 1, 1);
            Console.WriteLine(answer);
            //Console.ReadKey();
        }
    }
}

using System;

namespace lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите предложение, без знаков препинания: ");
            string str = Console.ReadLine();
            string[] arrayWords = str.Split(new char[] { ' ', ',', '.', '!', '?', ';' }, StringSplitOptions.RemoveEmptyEntries);
            int maxLength = 0, index = 0;

            for (int i = 0; i < arrayWords.Length; i++)
            {
                if (arrayWords[i].Length > maxLength)
                {
                    maxLength = arrayWords[i].Length;
                    index = i;
                }

            }

            Console.Write($"Самое длинное слово:{arrayWords[index]}");
            Console.ReadLine();
        }
    }
}

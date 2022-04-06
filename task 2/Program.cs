using System;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите предложение, без знаков препинания: ");
            string str = Console.ReadLine();
            /*string sub = str.ToLower();*/
            /*string[] sub = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);*/
            str = str.Replace(" ","").ToLower();
            int len = str.Length;
            bool res = false;

           for (int i = 0; i < len / 2; i++)
           {
                if (str[i] != str[len - i - 1])
                {
                    res = false;
                }
                else
                {
                    res = true;
                }
           }
            if (res == true)
            {
                Console.Write("Строка является палиндромом!");
            }
            else
            {
                Console.Write("Строка не является палиндромом!");
            }

            Console.ReadKey();
        }
    }
}

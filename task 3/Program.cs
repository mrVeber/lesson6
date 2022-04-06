using System;
using System.Text.RegularExpressions;

namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку с использованием {}: ");

            string str = Console.ReadLine();
            string str1 = Regex.Replace(str, @"(?<={)[\d\D]+(?=})", "");

            // если нужно удалить вместе с {} тогда строчка будет такая 
            //string str1 = Regex.Replace (str, @"{[\d\D]+}", "");

            Console.WriteLine($"{str1}");
            Console.ReadKey();
        }
    }
}

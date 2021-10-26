using System;
using System.IO;
using System.Linq;
using System.Threading;

namespace lab_lesson7
{
    internal class Program
    {
        static void IfisIFormatTable(object obj)
        {
            if (obj is IFormattable)
            {
                Console.WriteLine(obj.ToString());
            }
            else
            {

                Console.WriteLine("Не удалось явно преобразовать к IFormatTable");
            }
        }
        public static char[] Reverse(string a)
        {
            char[] reverse = a.Reverse().ToArray();
            return reverse;
        }


        private static void Main(string[] args)
        {
            Console.WriteLine("task 8.1 in the previous lab");
            Thread.Sleep(150);
            Console.WriteLine("task 8.2");
            Thread.Sleep(150);
            Console.WriteLine("Введите строку");
            string str = Console.ReadLine().ToString();
            Console.WriteLine(Reverse(str));

            Console.WriteLine("task 8.3");
            Thread.Sleep(180);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("введите название-->");
            string file = Console.ReadLine() + ".txt";
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("searching.");
            Thread.Sleep(250);
            Console.Write(".");
            Thread.Sleep(250); 
            Console.Write(".");
            Thread.Sleep(250);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            if (File.Exists(file) && !file.Equals("finalfile.txt"))
            {

                StreamReader r = new StreamReader(file);
                file = r.ReadToEnd();
                File.AppendAllText("finalfile.txt", file);
                r.Close();
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("ФАЙЛ НЕ НАЙДЕН");
                Console.ResetColor();
            }
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Task 8.4");
            Console.WriteLine("Введите строку");
            object obj = Console.ReadLine();
            IfisIFormatTable(obj);


        }
    }
}

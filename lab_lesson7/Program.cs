using System;
using System.IO;
using System.Linq;
using System.Threading;

namespace lab_lesson7
{
    internal class Program
    {
        static void IFormattable(object obj)
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
        public static void SearchMail()
        {
            StreamReader sr = new StreamReader("info.txt");
            int count = 0;
            string temp;
            while (sr.ReadLine() != null)
            {
                count++;
            }
            sr = new StreamReader("info.txt");
            for (int i = 0; i < count; i++)
            {
                string[] info = sr.ReadLine().Replace(" ","").Split('#');
                temp = info[1];
                File.AppendAllText("mails.txt", temp+"\n");
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
            Console.WriteLine("\t\t\t\t\t\t\t\ttask 8.2");
            Thread.Sleep(150);
            Console.Write("Введите строку-->\t");
            string str = Console.ReadLine().ToString();
            Console.Write($"Наоборот-->\t\t");
            Console.WriteLine(Reverse(str));

            Console.WriteLine("\t\t\t\t\t\t\t\ttask 8.3");
            Thread.Sleep(180);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("введите название-->\t");
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
                file = r.ReadToEnd().ToUpper();
                File.AppendAllText("finalfile.txt", file);
                r.Close();
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("\t\t\t\t\t\t\t\tФАЙЛ НЕ НАЙДЕН");
                Console.ResetColor();
            }
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("\t\t\t\t\t\t\t\tTask 8.4");
            Console.Write("Введите строку-->\t");
            object obj = Console.ReadLine();
            IFormattable(obj);
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("\t\t\t\t\t\t\t\tHomeTask 8.1");

            SearchMail();

        }
    }
}

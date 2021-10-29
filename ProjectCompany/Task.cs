using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCompany
{
    class Task
    {
        public Task(string name, string description, string destination)
        {
            this.name = name;
            this.description = description;
            this.destination = destination;
        }
        public string name { get; private set; }
        public string description { get; private set; }
        public string destination { get; private set; }
        public static Task CreateTask()
        {
            Console.Write("Название задачи-->");
            string name = Console.ReadLine();
            Console.WriteLine("Описание задачи :\t");
            string description = Console.ReadLine();
            Console.Write("Для кого эта задача?\t");
            string destination = Console.ReadLine();
            return new Task(name, description, destination);

        }
    }
}

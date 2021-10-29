using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCompany
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Department> departments = new List<Department>();
            departments.Add(new Department("ОИТ"));
            departments.Add(new Department("ОБ"));
            List<Sektor> sektors = new List<Sektor>();
            sektors.Add(new Sektor("Engineers"));
            sektors.Add(new Sektor("Dev"));

            //Bosses
            Boss boss = new Boss("Борис", null);
            BossAssistant assistant = new BossAssistant("О Ильхам", boss);

            //
            HeadOfDepartment headBuh = new HeadOfDepartment("Рашид", departments[1], boss);
            MainPersonOfDepartment MainBuh = new MainPersonOfDepartment("Лукас", departments[1], headBuh);
            //OIT
            HeadOfDepartment headOIT = new HeadOfDepartment("Оркадий", departments[0], assistant);
            MainPersonOfDepartment mainOIT = new MainPersonOfDepartment("Володя", departments[0], headOIT);

            //Developer
            HeadOfDevelopers bossDev = new HeadOfDevelopers("Сергей", departments[0], sektors[1], mainOIT);
            MainDeveloper mainDev = new MainDeveloper("Ляйсан", departments[0], sektors[1], bossDev);

            //Developer
            List<Employee> employers = new List<Employee>();
            employers.Add(new Developer("Марат", departments[0], sektors[1], mainDev));
            employers.Add(new Developer("Антон", departments[0], sektors[1], mainDev));
            employers.Add(new Developer("Ильдар", departments[0], sektors[1], mainDev));
            employers.Add(new Developer("Дина", departments[0], sektors[1], mainDev));

            //Engineers
            HeadEngineer bossEng = new HeadEngineer("Ильшат", departments[0], sektors[0], mainOIT);
            MainEngineer mainEng = new MainEngineer("Иваныч", departments[0],sektors[0], bossEng);
            //Engineers
            employers.Add(new Engineer("Илья", departments[0], sektors[0], mainEng));
            employers.Add(new Engineer("Витя", departments[0], sektors[0], mainEng));
            employers.Add(new Engineer("Женя", departments[0], sektors[0], mainEng));

            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Введите команду <task>, чтобы дать задачу; <exit> чтобы завершить программу");
                string input = Console.ReadLine().ToLower();

                if (Equals(input, "task"))
                {
                    Console.WriteLine("кому хотите дать задачу? <системщикам> <инжинер> <начальники>");

                }
                else if (Equals(input, "exit"))
                {
                    flag = false;
                }


        }
    }
    }
}

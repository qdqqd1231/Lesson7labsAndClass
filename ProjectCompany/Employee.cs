using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCompany
{
    abstract class Employee
    {
        public Sektor sektor { get; private set; }
        public int id { get;}
        public string name { get; set; }
        
        public static int lastId;
        public Department department { get; set; }
        public Employee head { get; set; }
        
        public Employee(string name, Employee head)
        {
            id = lastId++;
            this.name = name;
            this.head = head;
        }
        public Employee(string name, Department department)
        {
            id = lastId++;
            this.name = name;
            this.department = department;

        }
        public Employee(string name, Department department, Employee head)
        {
            id = lastId++;
            this.name = name;
            this.department = department;
            this.head = head;

        }
        public Employee(string name, Department department,Sektor sektor, Employee head)
        {
            id = lastId++;
            this.name = name;
            this.department = department;
            this.head = head;
            this.sektor = sektor;

        }
        public Employee() { }
        public List<Task> selfTasks = new List<Task>();


        public void GiveTask(Employee employeeTo, Task task)
        {
            if (employeeTo.head.id ==id)
            {
                if (!(employeeTo.sektor.sektor ==null))
                {
                    employeeTo.selfTasks.Add(task);
                    Console.WriteLine($"имя :  {employeeTo.name} отдел :  {employeeTo.department.department} сектор :  {employeeTo.sektor.sektor}  задача :{employeeTo.selfTasks.Last()}");
                }
                employeeTo.selfTasks.Add(task);
                Console.WriteLine($"имя :  {employeeTo.name} отдел :  {employeeTo.department.department}.  задача :{employeeTo.selfTasks.Last()}");
            }
            else
            {
                Console.WriteLine("нельзя назначить задачу");
                
            }

        }
        
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCompany
{
    abstract class Employee
    {
        public int id { get;}
        public string name { get; set; }
        public string surname { get; set; }
        public static int lastId;
        public Department department { get; set; }
        public Employee head { get; set; }
        public Employee(string name, string surname, Department department, Employee head)
        {
            id = lastId++;
            this.name = name;
            this.name = surname;
            this.department = department;
            this.head = head;

        }
        public List<Task> selfTasks = new List<Task>();
            
        public void GiveTask (Employee employeeLower, Task task)
        {
            if (employeeLower.head.id == id)
            {
                employeeLower.selfTasks.Add(task);
            }
        }







    }
}

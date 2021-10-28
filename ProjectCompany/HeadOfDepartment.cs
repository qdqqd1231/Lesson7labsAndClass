using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCompany
{
    class HeadOfDepartment:Employee
    {
        public HeadOfDepartment(string name, string surname, Department department, Employee head) : base(name, surname, department, head)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCompany
{
    class HeadOfDepartment : Employee
    {
        public HeadOfDepartment(string name, Department department, Employee head):base(name,department,head)
        {

        }

    }
}

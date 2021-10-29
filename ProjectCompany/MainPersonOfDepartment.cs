using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCompany
{
    class MainPersonOfDepartment:Employee
    {
        public MainPersonOfDepartment(string name, Department department, Employee head) : base(name,department, head)
        {

        }
    }
}

using Payot_Week08_Work09.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payot_Week08_Work09.Interfaces
{
    public interface IEmployeeManager
    {
        void Save(Employee e);

        Employee GetById(int id);

        List<Employee> GetEmployeeList();
    }
}

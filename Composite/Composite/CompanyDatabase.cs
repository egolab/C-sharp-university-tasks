using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    class CompanyDatabase : IEmployee
    {
        private List<IEmployee> employeeList = new List<IEmployee>();


        public void ShowEmployeeData()
        {
            foreach(IEmployee e in employeeList)
            {
                e.ShowEmployeeData();
            }
        }
        public void AddEmployee(IEmployee employee)
        {
            employeeList.Add(employee);
        }

        public void RemoveEmployee(IEmployee employee)
        {
            employeeList.Remove(employee);
        }
    }
}

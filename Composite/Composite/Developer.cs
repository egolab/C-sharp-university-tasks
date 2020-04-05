using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public class Developer : IEmployee
    {
        string name;
        int employeeID;
        string jobTitle;
        double salary;

        public Developer(string name, int employeeID, string jobTitle, double salary)
        {
            this.name = name;
            this.employeeID = employeeID;
            this.jobTitle = jobTitle;
            this.salary = salary;
        }

        public void ShowEmployeeData()
        {
            Console.WriteLine("Developer name: " + name + "\nEmployee ID number: " + employeeID + "\nTitle: " + jobTitle + "\nSalary: " + salary + " PLN");
            Console.WriteLine();
        }
    }
}
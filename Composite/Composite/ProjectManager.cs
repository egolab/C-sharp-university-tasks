using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    class ProjectManager: IEmployee
    {
        string name;
        int employeeID;
        string projectName;
        int numberOfSubordinates;
        double salary;

        public ProjectManager(string name, int employeeID, string projectName, int numberOfSubordinates, double salary)
        {
            this.name = name;
            this.employeeID = employeeID;
            this.projectName = projectName;
            this.numberOfSubordinates = numberOfSubordinates;
            this.salary = salary;
        }

    public void ShowEmployeeData()
        {
            Console.WriteLine("Project manager name: " + name + "\nEmployee ID number: " + employeeID + "\nProject name: " + projectName + "\nNumber of subordinates: " + numberOfSubordinates + "\nSalary: " + salary + " PLN");
            Console.WriteLine();
        }
    }
}

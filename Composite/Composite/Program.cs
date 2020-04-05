using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            CompanyDatabase companyDatabase = new CompanyDatabase();

            Developer developer1 = new Developer("John Smith", 200, "junior", 4500);
            Developer developer2 = new Developer("Anna Jones", 201, "mid", 7000);
            Developer developer3 = new Developer("Kate Holmes", 201, "senior", 14000);
            ProjectManager manager = new ProjectManager("Ted Mosby", 100, "Project1", 10, 9000);

            Console.WriteLine("LIST OF EMPLOYEES: \n");
            companyDatabase.AddEmployee(developer1);
            companyDatabase.AddEmployee(developer2);
            companyDatabase.AddEmployee(developer3);
            companyDatabase.AddEmployee(manager);

            companyDatabase.RemoveEmployee(developer2);
            companyDatabase.ShowEmployeeData();
        }
    }
}

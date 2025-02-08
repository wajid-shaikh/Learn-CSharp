using System;

namespace AboutConstructor
{
    class Employee
    {
        public int Id;
        public string Name;
        public string Department;
        public Employee(int id, string name, string department)
        {
            Id = id;
            Name = name;
            Department = department;
        }
        public void EmployeeInfo() 
        {
            Console.WriteLine($"Employee Info.\nId: {Id}\nName: {Name}\nDepartment: {Department}");
        }
        public static void Main(string[] args)
        {
            Employee emp = new Employee(786,"Joe","IT");
            emp.EmployeeInfo();
        }
    }

}
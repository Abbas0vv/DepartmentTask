using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Department
    {
        public string Name { get; set; }
        public int EmployeeLimit { get; set; }

        public Employee[] Employees;

        public Department(string name, int employeeLimit)
        {
            Name = name;
            EmployeeLimit = employeeLimit;
            Employees = new Employee[0];
        }

        public Employee this[int idx]
        {
            get { return Employees[idx]; }
            set { Employees[idx] = value; }
        }

        public int Length {  get { return Employees.Length; } }

        public void AddEmployee(Employee employee)
        {
            Array.Resize(ref Employees, Employees.Length + 1);
            if (Employees.Length > EmployeeLimit)
            {
                throw new CapacityLimitException();
            }
            Employees[^1] = employee;
        }
    }
}

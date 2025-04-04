using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Employee : IPerson
    {
        int _id;

        public Employee(string name, byte age, double salary)
        {
            Id = _id;
            Name = name;
            Age = age;
            Salary = salary;
            _id++;
        }

        public int Id { get; }
        public string Name { get; set; }
        public byte Age { get; set; }
        public double Salary { get; set; }

        public string ShowInfo()
        {
            return $"{Id}. Dear {Name} ({Age}), your salary is {Salary}";
        }

        public override string ToString()
        {
            return ShowInfo();
        }
    }
}

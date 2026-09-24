using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Common
{
    public enum SecurityLevel
    {
        Guest = 1,
        Developer = 2,
        Secretary = 4,
        DBA = 8,
        SecurityOfficer = 15

    }
    public class Employee
    {
        private char _gender;

        public int ID { get; set; }
        public string Name { get; set; }
        public SecurityLevel SecurityLevel { get; set; }
        public decimal Salary { get; set; }
        public HiringDate HiringDate { get; set; }
        public char Gender
        {
            get;
            set
            {
                _gender = value == 'M' || value == 'F' ? value : 'M';
            }
        }
        public Employee()
        {
            
        }

        public Employee(int id, string name, SecurityLevel securityLevel, decimal salary, HiringDate hireDate, char gender)
        {
            ID = id;
            Name = string.IsNullOrWhiteSpace(name) ? "Unknown" : name.Trim();
            SecurityLevel = securityLevel;
            Salary = salary;
            HiringDate = hireDate ?? new HiringDate();
            Gender = gender;
        }

        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, Security Level: {SecurityLevel}, Salary: {Salary:C2}, Hire Date: {HiringDate}, Gender: {_gender}";
        }
    }
}

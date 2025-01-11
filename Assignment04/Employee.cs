using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04
{
    internal class Employee
    {
        #region Properties
        public int ID { get; set; }
        public string Name { get; set; }
        private string gender;
        public string Gender
        {
            get { return gender; }
            set
            {
                if (value == "M" || value == "F")
                {
                    gender = value;
                }
                else
                {
                    throw new ArgumentException("Gender must be 'M' or 'F'");
                }
            }
        }
        public decimal Salary { get; set; }
        public DateTime HireDate { get; set; }
        public SecurityLevel SecurityPrivilege { get; set; }
        #endregion

        #region Constructor
        // Default Constructor
        public Employee() { }

        // Parameterized Constructor
        public Employee(int id, string name, string gender, decimal salary, DateTime hireDate, SecurityLevel securityLevel)
        {
            ID = id;
            Name = name;
            Gender = gender;
            Salary = salary;
            HireDate = hireDate;
            SecurityPrivilege = securityLevel;
        }
        #endregion

        #region Methods
        // Override ToString() method
        public override string ToString()
        {
            return string.Format("ID: {0}, Name: {1}, Gender: {2}, Salary: {3:C}, Hire Date: {4:d}, Security Level: {5}",
                                 ID, Name, Gender, Salary, HireDate, SecurityPrivilege);
            //The salary is formatted using :C, converting it into the local currency format.
            //The hire date is formatted using :d, which shows the date in a short date pattern.
        }
        #endregion
    }
}

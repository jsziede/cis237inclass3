using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass3
{
    //can only inherit from one parent class
    class SalaryEmployee : Employee
    {
        private decimal salary;

        public decimal Salary
        {
            get
            {
                return this.salary;
            }
        }

        /// <summary>
        /// 3 parameter constructor that takes the following arguments
        /// </summary>
        /// <param name="firstName">first name of employees</param>
        /// <param name="lastName">last name of employees</param>
        /// <param name="salary">yearly salary the employee earns</param>
        public SalaryEmployee(string firstName, string lastName, decimal salary) : base(firstName, lastName)
        {
            //assign the passed in salary to the class level one. the first and last names that
            //were passed in are assigned by calling the parent's constructor.
            //the parent's constructor was called by the : base(firstName, lastName)
            this.salary = salary;
        }

        /// <summary>
        /// print out the information of the class in readable format
        /// </summary>
        /// <returns>string consisting of first name, last name, and salary</returns>
        public override string ToString()
        {
            //base.ToString() calls the ToString method of the parent class.

            //we can get a full string of all properties by concating the parent's ToString
            //with the salary of this class. we leave the work of creating the parent's information
            //to the parent class
            return base.ToString() + " " + this.Salary.ToString("C");
        }
    }
}

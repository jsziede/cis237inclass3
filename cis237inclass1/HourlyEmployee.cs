using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass3
{
    class HourlyEmployee : Employee
    {
        //constants for the hours per week and year
        private const decimal HOURS_PER_WEEK = 40;
        private const decimal WEEKS_PER_YEAR = 52;

        //create a backing field for the hourly rate
        private decimal hourlyRate;

        //3 parameter constructor that uses the parent's constructor to do some of the work
        public HourlyEmployee(string firstName, string lastName, decimal hourlyRate)
            : base(firstName, lastName)
        {
            this.hourlyRate = hourlyRate;
        }

        //public property for the salary backing field
        public decimal Salary
        {
            //need to calculate the salary using constants
            get { return this.hourlyRate * WEEKS_PER_YEAR * HOURS_PER_WEEK; }
        }

        //public override of the ToString method. It uses the parent's ToString method to get some of its work done
        public override string ToString()
        {
            return base.ToString() + " " + this.Salary.ToString("C");
        }

        public override string GetFormattedSalary()
        {
            return this.Salary.ToString("C");
        }
    }
}

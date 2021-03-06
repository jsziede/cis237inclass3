﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass3
{
    public abstract class Employee : IEmployee
    {
        //Backing fields
        protected string firstName;
        protected string lastName;

        //properties for the backing fields
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        //One Method that is public. Can be accessed from other classes
        public string GetFullName()
        {
            return this.firstName + " " + this.lastName;
        }

        //abstract method in an abstract class does not have a { body } but all of its children classes must have an override { body } for this method
        public abstract string GetFormattedSalary();

        //virtual string requires a { body } but the { body } can be empty. virtual methods can be overridden
        public virtual string GetLastNameFirstName()
        {
            return this.lastName + ", " + this.firstName;
        }

        //Override method that will print all of the fields
        //It overrides the default ToString that every object gets for free!
        public override string ToString()
        {
            return this.firstName + " " + this.lastName;
        }

        //2 Parameter constructor
        public Employee(string firstName, string lastName)
        {
            //Assign the passed in values to the fields
            this.firstName = firstName;
            this.lastName = lastName;
        }

        //Default constructor
        public Employee()
        {
            //Lets just leave this blank
        }
    }
}

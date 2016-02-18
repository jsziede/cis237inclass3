using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass3
{
    class Program
    {
        static void Main(string[] args)
        {

            //Showing how to use an array with objects
            //Parent class Employee can use child classes HourlyEmployee and SalaryEmployee
            IEmployee[] employees = new Employee[10];

            //Instanciate some employees into the array
            employees[0] = new SalaryEmployee("James", "Kirk", 12345m);
            employees[1] = new HourlyEmployee("Jean-Luc", "Picard", 12.25m);
            employees[2] = new HourlyEmployee("ayy", "lmao", 123.05m);
            employees[3] = new SalaryEmployee("y", "ee", 55123.00m);
            employees[4] = new HourlyEmployee("Benjamin", "Sisko", 42.13m);
            employees[5] = new SalaryEmployee("Kathryn", "Janeway", 14567m);
            employees[6] = new HourlyEmployee("Johnathan", "Archer", 21.12m);
             
            //We are creating a new UserInterface class, and it's okay
            //that the UserInterface class does not have a defined
            //constructor. It will have a default one provide to us that
            //we can take advantage of by just not passing in any parameters
            UserInterface ui = new UserInterface();

            //This is not a valid statement. Because we are trying to make
            //an instance of a static class, it won't work.
            //StaticUserInterface stui = new StaticUserInterface();

            //Call the GetUserInput method of the UI class. It will return
            //a valid integer that represents the choice they want to do.
            int choice = ui.GetUserInput();

            //To use a static class to execute methods we simply call the
            //method on the class name, (or type). Since it is not possible
            //to use the 'new' keyword and make an instance, the only way
            //we can access the class is through the class name, so that
            //is what we do. Here we are calling the GetUserInterface method
            //on the class name to get it to run.
            //choice = StaticUserInterface.GetUserInput();

            //While the choice is not the exit choice (which in this case is 2)
            while (choice != 2)
            {
                //If the choice is 1, which in this case it has to be, but if there
                //were more menu options it might not be so obvious.
                if (choice == 1)
                {
                    //Create a empty string to concat to.
                    string allOutput = "";
                    //For each Employee in the employees array.
                    foreach (Employee employee in employees)
                    {
                        //So long as the spot in the array is not null
                        if (employee != null)
                        {
                            //Concat the employee changed to a string plus a new line
                            //to the allOutput string.
                            allOutput += employee.ToString() + Environment.NewLine;
                        }
                    }
                    //Now that the large string containing what I would like to output
                    //is created, I can output it to the screen using the
                    //PrintAllOutput method of the UI class.
                    ui.PrintAllOutput(allOutput);
                }

                //Now that the "Work" that we wanted to do is done,
                //We need to re-prompt the user for some input
                choice = ui.GetUserInput();
            }





        }

        //This method takes in a integer, which is passed by value
        //and then changes the value of it.
        static void changeAnInt(int myNumber)
        {
            myNumber = 456;
        }

        //This method takes in a Employee class, which is passed by reference
        //and then changes a property of it.
        static void changeAnObject(Employee employee)
        {
            employee.FirstName = "Thor";
        }



    }
}

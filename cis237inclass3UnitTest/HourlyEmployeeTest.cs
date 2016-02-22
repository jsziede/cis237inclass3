using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using cis237inclass3;

namespace cis237inclass3UnitTest
{
    [TestClass]
    public class HourlyEmployeeTest
    {
        [TestMethod]
        public void Test_Salary_Returns_Yearly_Salary()
        {
            HourlyEmployee hourlyEmployee = new HourlyEmployee("Joshua", "Sziede", 10.00m);
            Assert.AreEqual(20800.00m, hourlyEmployee.Salary);
            Assert.IsInstanceOfType(hourlyEmployee, typeof(HourlyEmployee));
        }
    }
}
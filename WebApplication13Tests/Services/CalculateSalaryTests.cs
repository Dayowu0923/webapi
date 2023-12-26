using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication13.Services;

namespace WebApplication13Tests.Services
{
    [TestClass()]
    public class CalculateSalaryTests
    {
        [TestMethod()]
        public void CalculateSalary_FullTimeEmployee_ReturnsCorrectSalary()
        {
            // Arrange
            Employee fullTimeEmployee = new Employee
            {
                name = "正式員工",
                years = 35,
                sex = "男",
                salarytype = 1,
                salary = 50000
            };
            ISalary fullTimeSalary = new FullTimeSalary();
            CalculateSalary calculator = new CalculateSalary(fullTimeSalary);
            // Act
            int result = calculator.Calculate(fullTimeEmployee);
            // Assert
            Assert.AreEqual(fullTimeEmployee.salary, result);

        }
        [TestMethod()]
        public void CalculateSalary_PartTimeEmployee_ReturnsCorrectSalary()
        {
            // Arrange
            int hour = 180;
            Employee partTimeEmployee = new Employee
            {
                name = "工讀生",
                years = 23,
                sex = "女",
                salarytype = 2,
                salary = 200
            };
            ISalary partTimeSalary = new PartTimeSalary(hour);
            CalculateSalary calculator = new CalculateSalary(partTimeSalary);
            // Act
            int result = calculator.Calculate(partTimeEmployee);
            // Assert
            Assert.AreEqual(partTimeEmployee.salary * hour, result);
        }
    }
}
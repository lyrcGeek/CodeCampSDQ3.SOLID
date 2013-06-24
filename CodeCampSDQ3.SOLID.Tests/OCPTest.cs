using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenClosePrinciple.Good;

namespace CodeCampSDQ3.SOLID.Tests
{
    [TestClass]
    public class OCPTest
    {
        [TestMethod]
        public void Normal_Employee_Salary_Calculation()
        {
            var employee = new NormalEmployee();
            employee.TotalOfSales = 200;
            employee.Salary = 5000;

            EmployeePaymentService paymentService = new EmployeePaymentService();
            var result = paymentService.GetNetSalary(employee);

            Assert.AreEqual(5004, result);
        }

        [TestMethod]
        public void Star_Employee_Salary_Calculation()
        {
            var employee = new StarEmployee();
            employee.TotalOfSales = 500;
            employee.Salary = 10000;

            EmployeePaymentService paymentService = new EmployeePaymentService();
            var result = paymentService.GetNetSalary(employee);

            Assert.AreEqual(10050, result);
        }
    }
}

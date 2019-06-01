using System;
using System.Collections.Generic;
using Xunit;

namespace University_Clinic_Hospital.Tests
{
    public class HospitalTests
    {
        [Fact]
        public void AddEmployeeToList_Adds_Employees()
        {
            Hospital sut = new Hospital();

            sut.AddEmployeesToList();

            Assert.True(0 != sut.employeeList.Count);
        }

        [Fact]
        public void PayEmployee_Changes_SalaryPaid_To_True()
        {
            //Arrange
            Hospital sut = new Hospital();
            Employee employee = new Employee();
            //Act
            sut.PayEmployees(employee);
            //Assert
            Assert.True(employee.SalaryPaid);
        }



    }
}

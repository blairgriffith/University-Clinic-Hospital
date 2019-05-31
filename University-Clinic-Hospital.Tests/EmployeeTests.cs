using System;
using Xunit;

namespace University_Clinic_Hospital.Tests
{
    public class EmployeeTests
    {
        [Fact]
        public void AddEmployeeToList_Adds_Employees()
        {
            Hospital sut = new Hospital();

            sut.addEmployeesToList();

            Assert.True(0 != sut.employeeList.Count);
        }
    }
}

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

    }
}

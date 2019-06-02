using System;
using Xunit;

namespace University_Clinic_Hospital.Tests
{
    public class NurseTests
    {
        [Fact]
        public void CareForPatient_Cannot_Make_NumberOfPatients_Exceed_PatientListCount()
        {
            //Arrange
            Nurse sut = new Nurse("sut", 30123);
            sut.NumberofPatients = 2;
            Patient test = new Patient("testPatient");
            //Act
            sut.CareForPatient(test, sut);
            //Assert
            Assert.Equal(2, sut.NumberofPatients);
        }
    }
}

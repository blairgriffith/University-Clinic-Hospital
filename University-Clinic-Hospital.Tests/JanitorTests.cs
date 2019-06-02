using System;
using Xunit;

namespace University_Clinic_Hospital.Tests
{
    public class JanitorTests 
    {
        [Fact]
        public void ChangeSweepingBehavior_Makes_Sweeping_True()
        {
            //Arrange
            Janitor janitor = new Janitor("Janitor", 34567);


            //Act
            janitor.ChangeWorking(janitor);

            //Assert
            Assert.True(janitor.Working);

        }
    }
}

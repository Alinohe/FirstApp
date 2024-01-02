using FirstProject1;

namespace FirstApp1.Test
{
    public class EmployeeTest
    {
        [Test]

        public void GetStatisticsForeach()
        {

            //arrange
            var employee = new Employee("Robert", "Domanski");
            //var employee = new Employee();  
            employee.AddGrade(2);
            employee.AddGrade(2);
            employee.AddGrade(6);

            //act
            var statistics = employee.GetStatisticts();

            //assert

            Assert.That(statistics.Max, Is.EqualTo(6));

        }

      

    }
}
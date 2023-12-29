using FirstProject1;

namespace FirstApp1.Test
{
    public class EmployeeTest
    {
        [Test]

        public void WhenGetStatShouldReturnMax()
        {

            //arrange
            var employee = new Employee("Robert", "Domanski");
            employee.AddGrade(2);
            employee.AddGrade(2);
            employee.AddGrade(6);

            //act
            var statistics = employee.GetStatisticts();

            //assert

            Assert.AreEqual(6, statistics.Max);

        }

        [Test]

        public void WhenGetStatShouldReturnMin()
        {

            //arrange
            var employee = new Employee("Robert", "Domanski");
            employee.AddGrade(2);
            employee.AddGrade(2);
            employee.AddGrade(6);

            //act
            var statistics = employee.GetStatisticts();

            //assert

            Assert.AreEqual(2, statistics.Min);

        }

        [Test]

        public void ThenGetStatShouldReturnAverage()
        {

            //arrange
            var employee = new Employee("Robert", "Domanski");
            employee.AddGrade(2);
            employee.AddGrade(2);
            employee.AddGrade(6);

            //act
            var statistics = employee.GetStatisticts();

            //assert

            Assert.AreEqual(Math.Round(3.33, 2), Math.Round(statistics.Average, 2));


        }


    }
}

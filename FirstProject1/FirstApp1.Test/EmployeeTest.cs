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
            employee.AddGrade(2);
            employee.AddGrade(2);
            employee.AddGrade(6);

            //act
            var statistics1 = employee.GetStatistictsForeach();

            //assert

            Assert.AreEqual(6, statistics1.Max);

        }

        [Test]

        public void GetStatisticsFor()
        {

            //arrange
            var employee = new Employee("Robert", "Domanski");
            employee.AddGrade(2);
            employee.AddGrade(2);
            employee.AddGrade(6);

            //act
            var statistics2 = employee.GetStatistictsFor();

            //assert

            Assert.AreEqual(2, statistics2.Min);

        }

        [Test]

        public void GetStatistiscDoWhile()
        {

            //arrange
            var employee = new Employee("Robert", "Domanski");
            employee.AddGrade(2);
            employee.AddGrade(2);
            employee.AddGrade(6);

            //act
            var statistics3 = employee.GetStatistictsDoWhile();

            //assert

            Assert.AreEqual(Math.Round(3.33, 2), Math.Round(statistics3.Average, 2));


        }

        [Test]

        public void GetStatistiscWhile()
        {

            //arrange
            var employee = new Employee("Robert", "Domanski");
            employee.AddGrade(2);
            employee.AddGrade(2);
            employee.AddGrade(6);

            //act
            var statistics4 = employee.GetStatistictsWhile();

            //assert

            Assert.AreEqual(Math.Round(3.33, 2), Math.Round(statistics4.Average, 2));
        }
    }
}
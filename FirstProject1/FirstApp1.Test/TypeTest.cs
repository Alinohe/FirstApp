namespace FirstApp1.Test
{
    public class TypeTest
    {
        [Test]
        public void TestString()
        {
            //arrange
            string number1 = "Robert";
            string number2 = "Robert";
            //act
            //Assert
            Assert.That(number2, Is.EqualTo(number1));
        }

        [Test]
        public void Testfloat()
        {
            //arrange
            float number1 = 1654981236891;
            float number2 = 24198764385484168;
            //act
            //Assert
            Assert.That(number2, Is.Not.EqualTo(number1));
        }
        [Test]
        public void ValueTest()

        {
            //arrange
            int number1 = 1;
            int number2 = 2;
            //act
            //Assert
            Assert.That(number2, Is.Not.EqualTo(number1));
        }
    }
}

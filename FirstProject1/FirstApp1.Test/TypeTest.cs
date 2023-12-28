using FirstProject1;

namespace FirstApp1.Test
{

    public class TypeTest
    {
        [Test]
        public void TestString()

        {
            //arrange
            string number1 = "50";
            string number2 = "50";

            //act


            //Assert

            Assert.AreEqual(number1, number2);

        }

           
        [Test]
        public void Testfloat()

        {
            //arrange
            float number1 = 1654981236891;
            float number2 = 24198764385484168;

            //act


            //Assert

            Assert.AreNotEqual(number1, number2);

        }
            
            [Test]
        public void TestWartosciowy()

        {
            //arrange
            int number1 = 1;
            int number2 = 2;

            //act


            //Assert

            Assert.AreNotEqual(number1, number2);

        }

        [Test]

        public void TestReferencyjny()
        {
            //arrange
            var user1 = GetUser("Adam", "321asd3213");
            var user2 = GetUser("Robert", "321asd3213");

            //act



            //Assert


            Assert.AreNotEqual(user1, user2);
        }

        private user GetUser(string name, string Login)
        {
            return new user(name, Login);
        }
    }
}


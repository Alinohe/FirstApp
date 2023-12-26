using System.Reflection.Metadata;
using FirstProject1;

namespace FirstProject1.Test
{
    public class Tests
    {
        [Test]
        public void CheckSumOperaton()
        {
            //arrange
            var user = new user("Robert","321asd321");
            user.AddScore(7);
            user.AddScore(8);
            user.AddScore(9);
            user.AddScore(6);
            user.AddScore(3);
            //act
            var result = user.Result;
           //Assert
            Assert.AreEqual(33, result); 
        }

        [Test] 
        public void CheckSumOperaton1() 
        {
            var user = new user("Adam", "321asd321");
            user.AddScore(5);
            user.AddScore(2);
            user.AddScore(1);
            user.AddScore(3);
            user.AddScore(4);

            var result = user.Result;

            Assert.AreEqual(15, result);
        }

        [Test]
        public void CheckSumOperaton2() 
        {
            var user = new user("Zuzia", "321asd321");
            user.AddScore(7);
            user.AddScore(4);
            user.AddScore(3);
            user.AddScore(6);
            user.AddScore(3);

            var result = user.Result;

            Assert.AreEqual(23, result);
        }

    }



}
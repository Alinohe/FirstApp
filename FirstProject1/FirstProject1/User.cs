
using System.Runtime.CompilerServices;

namespace FirstProject1
{
    public class user
    {
        private List<int> score = new List<int>();

        public user(string Login)
        {
            this.Login = Login;
        }

        public user(string Login, string Password)
        {
           this.Login = Login;
           this.Password = Password;
          
        }
        public string Login { get; private set; }

   
        public string Password { get; private set; }
        
        public int Result
        {
            get
            {
                return this.score.Sum();
               
            }
        }
        public void AddScore(int number)

            {
            this.score.Add(number);
        }
    }
}



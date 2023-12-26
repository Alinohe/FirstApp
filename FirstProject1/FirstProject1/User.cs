
namespace FirstProject1
{
    public class user
    {
        public List<int> score = new List<int>();

        public user(string Name, string Password)
        {
           this.Name = Name;
           this.Password = Password;
          
        }
        public string Name { get; set; }
        public string Password { get; set; }
        
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



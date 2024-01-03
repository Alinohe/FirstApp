namespace FirstProject1
{
    public abstract class Person
    {
        private string gender;

        public string Gender
        {
            get
            {
                return gender;
            }
            set
            {
                if (value == "K" || value == "M" || value == "-")
                {
                    gender = value;
                }
                else
                {
                    throw new ArgumentException("Wartość gender musi być 'K' Kobieta' , 'M' Mezczyzna' lub '-'.");
                }
            }
        }

        public Person()
        {
            this.Name = "no Name";
            this.Surname = "no Surname";
            this.Gender = "no Gender";

        }
        public Person(string name, string surname, string gender)
        {
            this.Name = name;
            this.Surname = surname;
            this.Gender = gender;
        }
        public string Name { get; protected set; }
        public string Surname { get; protected set; }
        //public string Gender { get; protected set; }


    }
}





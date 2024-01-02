namespace FirstProject1
{
    public abstract class Person //: System.Object
    {   
        public Person(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
            //this.Sex = sex;
            //this.Age = age;
        }
             public string Name { get; private set; }
             public string Surname { get; private set; }
            // public char Sex { get; private set;}
            //public float Age { get; private set;}
    }
}

namespace FirstProject1
{
    public class Supervisor : IEmployee
    {
        private List<float> grades = new List<float>();
        public Supervisor(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }

        public void AddGrade(int grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                throw new Exception("Invailid grade Value. Choose between 0 and 100");
            }
        }

        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.grades.Add(result);
            }
            else
                switch (grade)
                {
                    case "ocena: 7":
                        this.AddGrade(100.0f);
                        break;
                    case "ocena: 7-" or "ocena: -7":
                        this.AddGrade(95.0f);
                        break;
                    case "ocena: +6" or "ocena: 6+":
                        this.AddGrade(90.0f);
                        break;
                    case "ocena: 6":
                        this.AddGrade(85.0f);
                        break;
                    case "ocena: 6-" or "ocena: -6":
                        this.AddGrade(80.0f);
                        break;
                    case "ocena: +5" or "ocena: 5+":
                        this.AddGrade(75.0f);
                        break;
                    case "ocena: 5":
                        this.AddGrade(70.0f);
                        break;
                    case "ocena: 5-" or "ocena: -5":
                        this.AddGrade(65.0f);
                        break;
                    case "ocena: 4+" or "ocena: +4":
                        this.AddGrade(60.0f);
                        break;
                    case "ocena: 4":
                        this.AddGrade(55.0f);
                        break;
                    case "ocena: 4-" or "ocena: -4":
                        this.AddGrade(50.0f);
                        break;
                    case "ocena: 3+" or "ocena: +3":
                        this.AddGrade(45.0f);
                        break;
                    case "ocena: 3":
                        this.AddGrade(40.0f);
                        break;
                    case "ocena: 3-" or "ocena: -3":
                        this.AddGrade(35.0f);
                        break;
                    case "ocena: 2+" or "ocena: +2":
                        this.AddGrade(30.0f);
                        break;
                    case "ocena: 2":
                        this.AddGrade(25.0f);
                        break;
                    case "ocena: -2" or "ocena: 2-":
                        this.AddGrade(20.0f);
                        break;
                    case "ocena: +1" or "+1":
                        this.AddGrade(15.0f);
                        break;
                    case "ocena: 1":
                        this.AddGrade(10.0f);
                        break;
                    case "ocena: 1-" or "-1":
                        this.AddGrade(5.0f);
                        break;
                    case "ocena: 0":
                        this.AddGrade(0.0f);
                        break;
                    default:
                        throw new Exception("Invailid grade Value. Choose between 0 and 7 include + nad - for example +5 or 4-");
                }
        }

        public void AddGrade(double grade)
        {
            var valueInInt = (int)grade;
            this.AddGrade(valueInInt);
        }

        public void AddGrade(long grade)
        {
            var valueInInt = (int)grade;
            this.AddGrade(valueInInt);
        }

        public void AddGrade(float grade)
        {
            var valueInInt = (int)(grade);
            this.AddGrade(valueInInt);
        }

        public void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A' or 'a':
                    AddGrade(100.0f);
                    break;
                case 'B' or 'b':
                    AddGrade(80.0f);
                    break;
                case 'C' or 'c':
                    AddGrade(60.0f);
                    break;
                case 'D' or 'd':
                    AddGrade(40.0f);
                    break;
                case 'E' or 'e':
                    AddGrade(20.0f);
                    break;
                default:
                    throw new Exception("Wrong Letter Write Letter between A and E or a and e");
            }
        }

        public Statistics GetStatistics()

        {
            var statistics = new Statistics();

            foreach (var grade in this.grades)
            {
                statistics.AddGrade(grade);
            }

            return statistics;
        }

        void IEmployee.AddGrade(char grade)
        {
            throw new NotImplementedException();
        }
    }
}




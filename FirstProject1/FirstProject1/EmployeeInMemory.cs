namespace FirstProject1
{
    public class EmployeeInMemory : EmployeeBase
    {
        public override event GradeAddedDelegate GradeAdded;
        private List<float> grades = new List<float>();
        private string fileName = "grades.txt";

        public EmployeeInMemory(string name, string surname) : base(name, surname)
        {

        }

        public override void AddGrade(double grade)
        {
            this.AddGrade((int)grade);
        }

        public override void AddGrade(float grade)
        {
            this.AddGrade((int)grade);
        }

        public override void AddGrade(int grade)
        {
            {
                if (grade >= 0 && grade <= 100)
                {
                   this.grades.Add(grade);
                    if(GradeAdded != null)
                    {
                        GradeAdded(this, new EventArgs());
                    }
                }
                else
                {
                    throw new Exception("Invailid grade Value. Add between 0 and 100");
                }
            }
        }
        public override void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                if (grade.Length == 1)
                {
                    AddGrade(grade[0]);

                }
                else
                {
                    throw new Exception("Invalid Grade");
                }
            }
        }

        public override void AddGrade(char grade)
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
                    throw new Exception("Wrong Letter. Write Letter between A and E or a and e");
            }
        }

        public override Statistics GetStatistics()

        {
            var statistics = new Statistics();
            
            foreach(var grade in this.grades) 
            {
            statistics.AddGrade(grade);
            }
            
            return statistics;
        }
    }
}


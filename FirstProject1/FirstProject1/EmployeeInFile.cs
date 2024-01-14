namespace FirstProject1
{
    public class EmployeeInFile : EmployeeBase
    {
        public override event GradeAddedDelegate GradeAdded;
        private List<float> grades = new List<float>();
        private string fileName = "grades.txt";

        public EmployeeInFile(string name, string surname) : base(name, surname)
        {

        }
        private List<float> ReadFromFile()
        {
            var grades = new List<float>();
            if (File.Exists($"{fileName}"))
            {
                using (var reader = File.OpenText($"{fileName}"))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var number = float.Parse(line);
                        grades.Add(number);
                        line = reader.ReadLine();
                    }
                }
            }
            else
            {
                throw new FileNotFoundException();
            }
            return grades;
        }
        public override void AddGrade(double grade)
        {
            var valueInFloat = (float)grade;
            this.AddGrade(valueInFloat);
        }

        public override void AddGrade(int grade)
        {
            var valueInFloat = (float)grade;
            this.AddGrade(valueInFloat);
        }

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(grade);
                }

                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new Exception("Wrong value Write value between 0 and 100");
            }
        }

        public override void AddGrade(string grade)
        {

            char[] charArray = grade.ToCharArray();
            if ((charArray.Length == 1) && (char.ToLower(charArray[0]) >= 'a') && (char.ToLower(charArray[0]) <= 'e'))
            {
                this.AddGrade(charArray[0]);
            }
            else if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                throw new Exception("Wrong Letter. Write letter between A and E lower cases possible");
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
            var gradesFromFile = this.ReadFromFile();
            var statistics = new Statistics();
            foreach (var grade in gradesFromFile)
            {
                statistics.AddGrade(grade);
            }
            return statistics;

        }

    }
}

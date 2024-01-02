using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace FirstProject1
{
    public class Employee
    {
        private List<float> grades = new List<float>();

        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name { get; set; }
        public string Surname { get; set; }

        public void AddGrade(float grade)
        {

            

            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                throw new Exception("Invailid grade Value. Add between 0 and 100");
            }

        }
        public void AddGrade(double grade)

        {
            if (float.TryParse(grade.ToString(), out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                throw new Exception($"wrong value - :  {grade}");
            }
        }
        public void AddGrade(char grade)
        {

            switch (grade)
            {
                case 'A'or'a':

                    this.grades.Add(100);
                    break;
                case 'B' or'b':

                    this.grades.Add(80);
                    break;
                case 'C' or'c':

                    this.grades.Add(60);
                    break;
                case 'D' or 'd':

                    this.grades.Add(40);
                    break;
                case 'E' or 'e':

                    this.grades.Add(20);
                    break;
                default:
                    throw new Exception("Wrong Letter Write Letter between A and E or a and e");
                    

            }

        }
        public void AddGrade(long grade)
        {
            var number = (float)grade;

            if (number >= 0 && number <= 100)
                this.grades.Add(number);
            else if (number < 0)
            {
                throw new Exception("NUmber must be bigger than 0");
            }
            else
            {
                throw new Exception("Number must be lower or equal to 100");
            }

        }
        public void AddGrade(string grade)
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
        public Statistics GetStatisticts()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                if (grade >= 0)
                {
                    statistics.Max = Math.Max(statistics.Max, grade);
                    statistics.Min = Math.Min(statistics.Min, grade);
                    statistics.Average += grade;
                }

            }
            statistics.Average /= this.grades.Count;

            switch (statistics.Average)
            {
                case var Average when Average >= 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var Average when Average >= 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var Average when Average >= 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var Average when Average >= 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;
            }
            return statistics;

        }

    }
}

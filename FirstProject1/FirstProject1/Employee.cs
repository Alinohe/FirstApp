

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

            int valueInInt = (int)grade;

            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Invailid grade Value. Add between 0 and 100");
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
                Console.WriteLine($"wrong value - :  {grade}");
            }
        }
        public void AddGrade(char grade)
        {

            switch (grade)
            {
                case 'A':

                    this.grades.Add(100);
                    break;
                case 'B':

                    this.grades.Add(80);
                    break;
                case 'C':

                    this.grades.Add(60);
                    break;
                case 'D':

                    this.grades.Add(40);
                    break;
                case 'E':

                    this.grades.Add(20);
                    break;
                default:
                    Console.WriteLine("Wrong Letter Write Letter between A and E");
                    break;

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
                    Console.WriteLine("Invalid Grade");

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
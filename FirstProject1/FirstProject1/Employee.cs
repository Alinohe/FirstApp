

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

        public string Name { get; private set; }
        public string Surname { get; private set; }

        public void AddGrade(float grade)
        {
            // 3.33
            // 3
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

        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);

            }
            else
            {
                Console.WriteLine("Wrong value add value between 0 and 100");
            }
        }

        public void AddGrade(char grade) 
        
        {
            if(float.TryParse(grade.ToString(), out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                Console.WriteLine($"wrong value - :  {grade}");
            }
        } public void AddGrade(double grade) 
        
        {
            if(float.TryParse(grade.ToString(), out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                Console.WriteLine($"wrong value - :  {grade}");
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
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;

            }

            statistics.Average /= this.grades.Count;

            //

            return statistics;
        }

    }
}

using FirstProject1;


var employee = new Employee("Robert", "Domanski");

employee.AddGrade("4");
employee.AddGrade(2.9);
employee.AddGrade(6);

var statistics = employee.GetStatisticts();



Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");


using FirstProject1;


var employee = new Employee("Robert", "Domanski");

employee.AddGrade("4");
employee.AddGrade(2.9);
employee.AddGrade(6);

var statistics1 = employee.GetStatistictsForeach();
var statistics2 = employee.GetStatistictsFor();
var statistics3 = employee.GetStatistictsDoWhile();
var statistics4 = employee.GetStatistictsWhile();
//var statistics = employee.GetStatistics();


Console.WriteLine("Get Statistics for foreach method");
Console.WriteLine($"Average: {statistics1.Average:N2}");
Console.WriteLine($"Min: {statistics1.Min}");
Console.WriteLine($"Max: {statistics1.Max}");

Console.WriteLine("Get Statistics for for method");
Console.WriteLine($"Average: {statistics2.Average:N2}");
Console.WriteLine($"Min: {statistics2.Min}");
Console.WriteLine($"Max: {statistics2.Max}");

Console.WriteLine("Get Statistics for DoWhile method");
Console.WriteLine($"Average: {statistics3.Average:N2}");
Console.WriteLine($"Min: {statistics3.Min}");
Console.WriteLine($"Max: {statistics3.Max}");

Console.WriteLine("Get Statistics for While method");
Console.WriteLine($"Average: {statistics4.Average:N2}");
Console.WriteLine($"Min: {statistics4.Min}");
Console.WriteLine($"Max: {statistics4.Max}");





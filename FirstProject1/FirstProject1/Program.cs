﻿
using FirstProject1;

Console.WriteLine("Witamy w Programie XYZ do oceny Pracownikow");
Console.WriteLine("================================================");
Console.WriteLine();
Console.WriteLine("Podaj Imie Pracownika");

var name = Console.ReadLine();

Console.WriteLine("Podaj Nazwisko Pracownika");

var surname = Console.ReadLine();
var employee = new Employee(name, surname);

Console.WriteLine($"ocena dla pracownika {employee.Name} {employee.Surname}:");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Podaj ocene pracownika");

while (true)
{
    Console.WriteLine("Podaj kolejna ocene pracownika lub wyjdz naciskajac q");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    try
    {
        employee.AddGrade(input);
    }
    catch(Exception ex)
    { 
        Console.WriteLine($"Exception Found: {ex.Message}");
        Console.WriteLine();
    }
}

var statistics = employee.GetStatisticts();
Console.WriteLine($"ocena dla pracownika {employee.Name} {employee.Surname}:");
Console.WriteLine($"Average: {statistics.Average:N2} Letter  {statistics.AverageLetter}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");

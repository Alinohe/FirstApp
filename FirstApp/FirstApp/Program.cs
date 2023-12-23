int[] grades = new int[365];

List<string> dayOfWeeks = new List<string>();
dayOfWeeks.Add("Poniedzialek");
dayOfWeeks.Add("Wtorek");
dayOfWeeks.Add("Sroda");
dayOfWeeks.Add("Czwartek");
dayOfWeeks.Add("Piatek");
dayOfWeeks.Add("Sobota");
dayOfWeeks.Add("Niedziela");


foreach(var day in dayOfWeeks)
{
    Console.WriteLine(day);
}
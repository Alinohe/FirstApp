
string name = "Robert";
var age = 50;
var sex = "mezczyzna";


if (age > 50 && sex == "mezczyzna")
{
    Console.WriteLine("mezczyzna ponizej 50 lat");
}

else if (name == "Robert" && age == 50)
{
    Console.WriteLine("Robert lat 50");
}
else if (sex == "kobieta" && age < 18)
{
    Console.WriteLine("niepelnoletnmia Kobieta");
}
else if (name == "Ewa" && age < 60 && sex == "kobieta")
{
    Console.WriteLine("");
}
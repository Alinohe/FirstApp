
int number = 4566;
string numberInString = number.ToString();
char[] letters = numberInString.ToArray();
Console.WriteLine("Wyniki Dla Liczby " + number);

int[] count = new int[10];
count[0] = 0;
count[1] = 0;
count[2] = 0;
count[3] = 0;
count[4] = 0;
count[5] = 0;
count[6] = 0;
count[7] = 0;
count[8] = 0;
count[9] = 0;

foreach (char letter in letters)
{
    if (letter == '0')
    {
        count[0]++;

    }
    else if (letter == '1')
    {
        count[1]++;
    }
    else if (letter == '2')
    {
        count[2]++;
    }
    else if (letter == '3')
    {
        count[3]++;
    }
    else if (letter == '4')
    {
        count[4]++;
    }
    else if (letter == '5')
    {
        count[5]++;
    }
    else if (letter == '6')
    {
        count[6]++;
    }
    else if (letter == '7')
    {
        count[7]++;

    }
    else if (letter == '8')
    {
        count[8]++;
    }
    else if (letter == '9')
    {
        count[9]++;
    }

    

}
Console.WriteLine("0 =>" + count[0]);
Console.WriteLine("1 =>" + count[1]);
Console.WriteLine("2 =>" + count[2]);
Console.WriteLine("3 =>" + count[3]);
Console.WriteLine("4 =>" + count[4]);
Console.WriteLine("5 =>" + count[5]);
Console.WriteLine("6 =>" + count[6]);
Console.WriteLine("7 =>" + count[7]);
Console.WriteLine("8 =>" + count[8]);
Console.WriteLine("9 =>" + count[9]);


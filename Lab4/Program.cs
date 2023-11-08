Console.WriteLine("Choose an option:");
Console.WriteLine("1) Enter the A value");
Console.WriteLine("2) Enter the B value");
Console.WriteLine("3) +");
Console.WriteLine("4) -");
Console.WriteLine("5) *");
Console.WriteLine("6) /");

int aValue = 0;
int bValue = 0;
int result = 0;

while (true)
{
    string choosenOption = Console.ReadLine();

    if (choosenOption == "stop")
    {
        break;
    }

    int choosenOptInt = int.Parse(choosenOption);
    switch (choosenOptInt)
    {
        case 4:
            result = aValue - bValue;
            Console.WriteLine(result.ToString());
            break;
    }
}
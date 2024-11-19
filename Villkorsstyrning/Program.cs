int minValue = 0;
int maxValue = 100;

int currentValue = 100;

if (currentValue <= minValue)
{
    Console.WriteLine("Värdet är mindre eller lika med minvärdet");
}
else if (currentValue > maxValue)
{
    Console.WriteLine("Värdet är större än minvärdet");
}
else
{
    Console.WriteLine("Värdet håller sig inom sina ramar");
}

Console.ReadKey();

/* */
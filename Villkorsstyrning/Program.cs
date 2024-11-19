bool isEnabled = true;

if (isEnabled)
{
    Console.WriteLine("Step 1...");
    Console.WriteLine("Step 2...");
    Console.WriteLine("Step 3...");
    Console.WriteLine("Step 4...");
}

string result = isEnabled ? "Detta är sant" : "Detta är falskt";
Console.WriteLine(result);
Console.ReadKey();

/*

if (currentValue > minValue)
{
    if (currentValue > maxValue) 
    {
        Console.WriteLine("Värdet är större än maxvärdet");
    } else
    {
        Console.WriteLine("Värdet håller sig inom sina ramar");
    }
}
 */

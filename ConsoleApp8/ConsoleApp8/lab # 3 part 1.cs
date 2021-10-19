double y;
double x = Convert.ToDouble(Console.ReadLine());
if (x > 5)
{
    y = x - 12;
    Console.WriteLine(y);
}
else if (0 <= x && x <= 5)
{
    y = 12 + x;
    Console.WriteLine(y);
}
else if (x < 0)
{
    y = 12 * x;
    Console.WriteLine(y);
}
Console.ReadKey(); 
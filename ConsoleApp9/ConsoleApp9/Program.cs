bool x, y, z;
NewMethod(out x, out y, out z);
Console.WriteLine(!x & z | !y | !x);

bool x1 = true, y1 = true, z1 = true;
Console.WriteLine(!x & z | !y | !x);

bool x2 = false, y2 = false, z2 = true;
Console.WriteLine(!x & z | !y | !x);

bool x3 = true, y3 = false, z3 = false;
Console.WriteLine(!x & z | !y | !z);

bool x4 false, y4 = true, z4 = false;
Console.WriteLine(!x & z | !y | !z);

bool x5 = true, y5 = true, z5 = false;
Console.WriteLine(!x & z | !y | !x);

bool x6 = false, y6 = false, z6 = false;
Console.WriteLine(!x & z | !y | !z);

private static void NewMethod(out bool x, out bool y, out bool z)
{
    x = false;
    y = false;
    z = false;
}
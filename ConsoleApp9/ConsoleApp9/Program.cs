//f(x, y, z) = !x & z | !y | !x = false
int x, y, z;
3x=Convert.ToInt32(Console.ReadLine());
y=Convert.ToInt32(Console.ReadLine());
z=Convert.ToInt32(Console.ReadLine());
bool c = Convert.ToBoolean(x);
bool d = Convert.ToBoolean(y);
bool e = Convert.ToBoolean(z);

bool f = !c & e | !d | !c;
if (f)
{
    Console.WriteLine(true);
}
else
{
    Console.WriteLine(false);
}
Console.ReadKey();
Console.WriteLine("Введите год рождения первого человека: ");
int g1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите месяц рождения первого человека: ");
int m1 = int.Parse(Console.ReadLine());
if (m1 > 12 || m1 <= 0)
{
    Console.WriteLine("Введите месяц рождения первого человека верно: ");
    m1 = int.Parse(Console.ReadLine());
}
Console.WriteLine("Введите день рождения первого человека: ");
int d1 = int.Parse(Console.ReadLine());
if (((d1 > 31 || d1 <= 0) && ((m1 == 1) || (m1 == 3) || (m1 == 5) || (m1 == 7) || (m1 == 8) || (m1 == 10) || (m1 == 12))) || ((d1 > 30 || d1 <= 0) && ((m1 == 4) || (m1 == 6) || (m1 == 9) || (m1 == 11))) || ((d1 > 28 || d1 <= 0) && (m1 == 2)))
{
    Console.WriteLine("Введите день рождения первого человека верно: ");
    d1 = int.Parse(Console.ReadLine());
}
Console.WriteLine("Введите год рождения ворого человека: ");
int g2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите месяц рождения ворого человека: ");
int m2 = int.Parse(Console.ReadLine());
if (m2 > 12 || m2 <= 0)
{
    Console.WriteLine("Введите месяц рождения первого человека верно: ");
    m2 = int.Parse(Console.ReadLine());
}
Console.WriteLine("Введите день рождения ворого человека: ");
int d2 = int.Parse(Console.ReadLine());
if (((d2 > 31 || d2 <= 0) && ((m2 == 1) || (m2 == 3) || (m2 == 5) || (m2 == 7) || (m2 == 8) || (m2 == 10) || (m2 == 12))) || ((d2 > 30 || d2 <= 0) && ((m2 == 4) || (m2 == 6) || (m2 == 9) || (m2 == 11))) || ((d2 > 28 || d2 <= 0) && (m2 == 2)))
{
    Console.WriteLine("Введите день рождения первого человека верно: ");
    d1 = int.Parse(Console.ReadLine());
}

int sum1 = g1 * 365 + m1 * 30 + d1;
int sum2 = g2 * 365 + m2 * 30 + d2;

if (sum1 < sum2) Console.WriteLine("Первый человек старше второго");
else Console.WriteLine("Второй человек старше первого");
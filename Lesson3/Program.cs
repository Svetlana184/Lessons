
// N = (m * m + 2.8m + 0.355)/(cos2y + 3.6) 15 вариант

try
{
    Console.WriteLine("Введите число m:");
    double m = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите число y:");
    double y = double.Parse(Console.ReadLine());
    double N = (m * m + 2.8 * m + 0.355) / (Math.Cos(2 * y) + 3.6);
    Console.WriteLine($"N = {N:F2}");
}
catch
{
    Console.WriteLine("Введите переменные правильно");
}


try
{
    Console.WriteLine("Введите длину стороны a");
    double a = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите длину стороны b");
    double b = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите длину стороны c");
    double c = double.Parse(Console.ReadLine());
    double medianaA = 0.5 * Math.Sqrt(2 * b * b + 2 * c * c - a * a);
    double medianaB = 0.5 * Math.Sqrt(2 * a * a + 2 * c * c - b * b);
    double medianaC = 0.5 * Math.Sqrt(2 * b * b + 2 * a * a - c * c);
    Console.WriteLine($"N = {medianaA:F2}");
    Console.WriteLine($"N = {medianaB:F2}");
    Console.WriteLine($"N = {medianaC:F2}");
}
catch
{
    Console.WriteLine("Правильно введите данные");
}


try
{
    Console.WriteLine("Введите число m:");
    double m = double.Parse(Console.ReadLine());
    double N = m * m + 2.8 + Math.Abs(m) + 0.55;
    Console.WriteLine($"N = {N:F2}");
}
catch
{
    Console.WriteLine("Правильно введите данные");
}
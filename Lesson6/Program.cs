/*
    №1
try
{
    Console.WriteLine("введите x:");
    double x = double.Parse(Console.ReadLine());
    double y;
    if (x >= 0) y = x;
    else y = -x;
    Console.WriteLine($"модуль от x равен {y}");

}
catch
{
    Console.WriteLine("введите данные правильно");
}

    №2
try
{
    Console.WriteLine("введите x:");
    double x = double.Parse(Console.ReadLine());
    if ((x > -5)&&(x < 3)) Console.WriteLine("принадлежит");
    else Console.WriteLine("не принадлежит");
}
catch
{
    Console.WriteLine("введите число правильно");
}

    //№3
try
{
    Console.WriteLine("введите число");
    int a = int.Parse(Console.ReadLine());
    if ((a / 10 == 3)||(a % 10 == 3)) Console.WriteLine("входит");
    else Console.WriteLine("не входит");
}
catch
{
    Console.WriteLine("введите число правильно");
}
*/

try
{
    Console.WriteLine("введите a:");
    double a = double.Parse(Console.ReadLine());
    Console.WriteLine("введите b:");
    double b = double.Parse(Console.ReadLine());
    Console.WriteLine("введите c:");
    double c = double.Parse(Console.ReadLine());
    double D = b * b - 4 * a * c;
    if (D > 0)
    {
        double x1 = (-b + Math.Sqrt(D)) / (2 * a);
        double x2 = (-b + Math.Sqrt(D)) / (2 * a);
        Console.WriteLine($"x1 = {x1:F2}, x2 = {x2:F2}");
    }
    else if (D == 0)
    {
        double x = (-b) / (2 * a);
        Console.WriteLine($"x = {x:F2}");
    }
    else
    {
        Console.WriteLine("нет корней");
    }

}
catch
{
    Console.WriteLine("введите данные правильно");
}
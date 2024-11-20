try
{
    Console.WriteLine("введите n");
    int n = int.Parse(Console.ReadLine());
    Console.WriteLine("введите x");
    double x = double.Parse(Console.ReadLine());
    double s = 0;
    for (int i = 1; i <= n; i+=2)
    {
        s += Math.Sin(i * Math.Pow(x, i));
    }
    Console.WriteLine(s);
}
catch
{
    Console.WriteLine("");
}
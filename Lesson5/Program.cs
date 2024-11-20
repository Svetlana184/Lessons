try
{
    Console.WriteLine("введите x");
    double x = double.Parse(Console.ReadLine());
    Console.WriteLine("введите y");
    double y = double.Parse(Console.ReadLine());
    Console.WriteLine((x * x + y * y <= 4) && (x * x + y * y >= 1));

}
catch
{
    Console.WriteLine("введите данные правильно");
}
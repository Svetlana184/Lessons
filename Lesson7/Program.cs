try
{
    Console.WriteLine("введите сумму в рублях");
    int c = int.Parse(Console.ReadLine());
    if ((c%100 >=11) && (c%100<=14))
    {
        Console.WriteLine($"{c} рублей");
    }
    else
    {
        int ost = c % 10;
        switch (ost)
        {
            case 1: Console.WriteLine($"{c} рубль"); break;
            case 2: case 3: case 4: Console.WriteLine($"{c} рубля"); break;
            default: Console.WriteLine($"{c} рублей"); break;
        }
    }
    
}
catch
{
    Console.WriteLine("введите данные правильно");
}
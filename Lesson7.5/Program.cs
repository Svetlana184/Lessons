//применение цикла с постусловием



//try
//{
//    Console.WriteLine("введите последовательность целых чисел");
//    int s = 0, count = 0;
//    do
//    {
//        int n = int.Parse(Console.ReadLine());
//        if (n == 0) break;
//        s += n;
//        count++;

//    }
//    while (true);
//    Console.WriteLine($"сумма чисел последовательности равна {s}\nколичество чисел последовательности равно {count}");
//}
//catch 
//{
//    Console.WriteLine("введите данные правильно");
//}

using System.Linq.Expressions;

do
{
    Console.Clear(); //очистка консоли
    try
    {
        Console.WriteLine("МЕНЮ:\n" +
            "выберите пункт меню\n" +
            "1 - Обработка  числовых последовательностей\n" +
            "2 - Использование операторов в теле оператора цикла с условием\n" +
            "3 - Использование операторов после оператора цикла с условием\n" +
            "4 - Использование операторов  в теле оператора цикла с условием и после него\n" +
            "5 - выход");
        Console.WriteLine("выберите пункт меню:");
        int x = int.Parse(Console.ReadLine());
        switch (x)
        {
            case 1:
            {
                    Console.WriteLine("Введите последовательность чисел:");
                    int m = 0, p = 1;
                    do
                    {
                        m=int.Parse(Console.ReadLine());
                        p *= m;
                        Console.Write($"{p} ");
                    }
                    while (m != 0);
                 
            }
            break;
            case 2:
            {
                Console.WriteLine("введите число");
                int m = int.Parse(Console.ReadLine());
                int last = m % 10;
                int countLast = 0, even = 0, sumMore5 = 0, pMore7 = 1, count3 = 0, count0OR5 = 0;
                while (m != 0)
                {
                    int temp = m % 10;
                    if (temp == 3) count3++;
                    if (temp == last) countLast++;
                    if (temp % 2 == 0) even++;
                    if (temp > 5) sumMore5+=temp;
                    if (temp > 7) pMore7*=temp;
                    if (temp == 0 && temp == 5) count0OR5++;
                    m /= 10;
                }
                Console.WriteLine($"количество троек в числе равно {count3}\nколичество {last} в числе равно {countLast}\n" +
                    $"количество чётных цифр равно {even}\nсумма цифр, больше пяти в числе равна {sumMore5}" +
                    $"произведение цифр числа больше семи равно {pMore7}\nколичество 0 и 5 в числе равно {count0OR5}");
                Console.ReadKey();
            }
            break;
            case 3:
                {
                    //double a = 5;
                    //for (int i = 1; i < 5; i++)
                    //{
                    //    Console.WriteLine(a);
                    //    a += 2;
                    //}
                    //Console.ReadKey();
                    //for (int i = 35; i <= 87; i++)
                    //{
                    //    if (i % 7 == 1 || i % 7 == 2 || i % 7 == 5)
                    //    {
                    //        Console.WriteLine(i);
                    //    }
                    //}
                    try
                    {
                        Console.WriteLine("введите n:");
                        int n = int.Parse(Console.ReadLine());
                        int summ=0;
                        for (int i = 1; i <= n; i++)
                        {
                            summ += i;
                        }
                        Console.WriteLine(summ);
                        Console.ReadKey();
                    }
                    catch
                    {
                        Console.WriteLine("введите число правильно");
                    }

                    
                }
            break;
            case 4: 
            {
                    Console.WriteLine("");
            }
            break;
            case 5: Console.WriteLine("здесь нет выхода аххаха"); break;
        }
    }
    catch
    {
        Console.WriteLine("такого пункта нет");
    }
}
while(true);
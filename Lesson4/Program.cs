try
{
    //Console.WriteLine("введите число");
    //int n = int.Parse(Console.ReadLine());
    ////1 см в полные метры
    //Console.WriteLine($"m = {n/100} полных метров");

    ////1 кг в полные центнеры
    //Console.WriteLine($"m = {n / 100} полных центнеров");

    ////1 кг в полные тонны
    //Console.WriteLine($"m = {n / 1000} полных тонн");

    ////1 м в полные км
    //Console.WriteLine($"m = {n / 1000} полных км");

    ////
    //Console.WriteLine("введите число секунд");
    //int n = int.Parse(Console.ReadLine());

    //int hour = n / 3600;
    //int min = n % 3600 / 60;
    //int seconds = n % 60;
    //Console.WriteLine($"{hour}:{min}:{seconds}");

    //Console.WriteLine("введите номер дня в году");
    //int k = int.Parse(Console.ReadLine());
    //Console.Write("введите номер дня недели, выпадающего на 1 января" + "0 - воскресенье, 1 - понедельник, 2 - вторник ... 6 - суббота");
    //int n = int.Parse(Console.ReadLine());
    //int day = (k) % 12 ;
    //Console.WriteLine(day);

    Console.WriteLine("введите трёхзначное число:");
    int a = int.Parse(Console.ReadLine());
    int ed = a % 10;
    int dec = a % 100 / 10;
    int sot = a / 100;
    Console.WriteLine($"сумма чисел {ed+dec+sot}");
    Console.WriteLine($"произведение чисел {ed * dec * sot}");
    Console.WriteLine($"число в обратном порядке {(ed * 100) + (dec * 10) + sot}");

}
catch
{
    Console.WriteLine("введите правильные данные");
}
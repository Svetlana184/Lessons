//вариант 30


//база

//1
//Console.WriteLine("введите первую дату:");
//DateTime d1 = DateTime.Parse(Console.ReadLine());
//Console.WriteLine("введите вторую дату:");
//DateTime d2 = DateTime.Parse(Console.ReadLine());
//if (d1.CompareTo(d2) < 0) Console.WriteLine($"{d1} раньше {d2}");
//else if (d1.CompareTo(d2) == 0) Console.WriteLine($"{d1} равен {d2}");
//else Console.WriteLine($"{d1} позже {d2}");

//2
//Console.WriteLine("введите дату последней профилактики:");
//DateOnly lastCheck = DateOnly.Parse(Console.ReadLine());
//Console.WriteLine("введите периодичность профилактики в месяцах:");
//int period = int.Parse(Console.ReadLine());
//Console.WriteLine($"следующая дата проведения осмотра: {lastCheck.AddMonths(period)}");


//средний уровень


SmartHome[] mas = new SmartHome[3];
for (int i = 0; i < mas.Length; i++)
{
    Console.WriteLine("введите дату включения кондиционера");
    DateOnly d = DateOnly.Parse(Console.ReadLine());
    Console.WriteLine("введите время включения кондиционера");
    TimeOnly t = TimeOnly.Parse(Console.ReadLine());
    Console.WriteLine("выберите температурнй режим:\n1 - охлаждение\n2 - отопление\n3 - вентиляция\n4 - сон\n5 - осушение");
    int n = int.Parse(Console.ReadLine());
    Mode mode = Mode.Сон;
    switch (n)
    {
        case 1: mode = Mode.Охлаждение; break;
        case 2: mode = Mode.Отопление; break;
        case 3: mode = Mode.Вентиляция; break;
        case 4: mode = Mode.Сон; break;
        case 5: mode = Mode.Осушение; break;
    }
    Console.WriteLine("введите температуру:");
    int temp = int.Parse(Console.ReadLine());
    mas[i] = new SmartHome(d,t,mode,temp);
}
foreach (SmartHome ma in mas)
{
    TimeSpan ts = ma.time - TimeOnly.FromDateTime(DateTime.Now);
    if (ma.time > TimeOnly.FromDateTime(DateTime.Now))
    {
        Console.WriteLine($"{ma.mode}.Время для включения {ts.Hours}:{ts.Minutes}:{ts.Seconds}");
    }
    
}
foreach (SmartHome ma in mas)
{
    int d = DateOnly.FromDateTime(DateTime.Now).Day - ma.date.Day;
    if (d == -1)
    {
        Console.WriteLine(ma.mode);
    }
}


enum Mode
{
    Охлаждение,
    Отопление,
    Вентиляция,
    Сон,
    Осушение
}
struct SmartHome
{
    public DateOnly date;
    public TimeOnly time;
    public Mode mode;
    public int temp;
    public SmartHome(DateOnly date, TimeOnly time, Mode mode, int temp)
    {
        this.date = date;
        this.time = time;
        this.mode = mode;
        this.temp = temp;
    }
}
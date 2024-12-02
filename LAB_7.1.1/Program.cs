//Computer[] comps = new Computer[3];
//for (int i = 0; i < comps.Length; i++)
//{
//    Console.WriteLine($"введите название:");
//    string name = Console.ReadLine();
//    Console.WriteLine($"введите частоту:");
//    double fr = double.Parse( Console.ReadLine() );
//    Console.WriteLine("введите объем памяти");
//    int memory = int.Parse( Console.ReadLine() );
//    Console.WriteLine("Выберите y - если присутствует DVd или n - если отсутсвует");
//    char dvd = char.Parse( Console.ReadLine() );
//    bool hasDVD = false;
//    if (dvd == 'y') hasDVD = true;
//    Console.WriteLine( "введите цену");
//    decimal price = decimal.Parse( Console.ReadLine() );
//    Computer comp = new Computer(name, fr, memory,hasDVD,price);
//    comps[i] = comp;
//}
//foreach (Computer item in comps)
//{
//    if (item.DVD == true) item.Print();
//}

Car[] cars = new Car[3];
for (int i = 0; i < cars.Length; i++)
{
    Console.WriteLine("введите название");
    string name = Console.ReadLine();
    Console.WriteLine("Введите производителя");
    string manufacturer = Console.ReadLine();
    Console.WriteLine("выберите тип машины: 1 - sedan, 2 - kupe, 3 - cabriolet, 4 - hatchback, 5 - universal, 6 - pikap");
    int typeInt = int.Parse(Console.ReadLine());
    TypeOfCar typeC = TypeOfCar.pikap;
    switch (typeInt)
    {
        case 1: typeC = TypeOfCar.sedan; break;
        case 2: typeC = TypeOfCar.kupe; break;
        case 3: typeC = TypeOfCar.cabriolet; break;
        case 4: typeC = TypeOfCar.hatchback; break;
        case 5: typeC = TypeOfCar.universal; break;
        case 6: typeC = TypeOfCar.pikap; break;
    }
    Console.WriteLine("Введите год выпуска");
    int year = int.Parse (Console.ReadLine());
    Console.WriteLine("Введите дату техосмотра");
    DateTime dateTime = DateTime.Parse (Console.ReadLine());
    Console.WriteLine("введите дату регистрации");
    DateTime registrationDate = DateTime.Parse(Console.ReadLine());
    Car car = new Car(name, manufacturer, typeC, year, dateTime, registrationDate);
    cars[i] = car;
}


enum TypeOfCar
{
    sedan,
    kupe,
    cabriolet,
    hatchback,
    universal,
    pikap
}
struct Car
{
    public string Marka;
    public string Manufacturer;
    public TypeOfCar Type;
    public int Year;
    public DateTime Date;
    public DateTime RegistrationDate;

    public Car(string marka, string manufacturer, TypeOfCar type, int year, DateTime date, DateTime registrationDate)
    {
        Marka = marka;
        Manufacturer = manufacturer;
        Type = type;
        Year = year;
        Date = date;
        RegistrationDate = registrationDate;
    }
    public void Print()
    {
        Console.WriteLine($"Марка {Marka} Производитель {Manufacturer} Тип машины {Type} Год выпуска {Year} Дата техосмотра {Date} Дата регистрации {RegistrationDate}");
    }
}
struct Computer
{
    public string Name;
    public double Frecuancy;
    public int Memory;
    public bool DVD;
    public decimal Price;
    public Computer(string name, double frecuancy, int memory, bool dVD, decimal price)
    {
        Name = name;
        Frecuancy = frecuancy;
        Memory = memory;
        DVD = dVD;
        Price = price;
    }
    public void Print()
    {
        Console.WriteLine($"Название {Name}\nчастота {Frecuancy}\nпамять {Memory}\nDVD {DVD}\nцена {Price}");
    }
}
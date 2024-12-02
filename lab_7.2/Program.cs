Car[] cars = new Car{
    ("BMV", "Германия", 0.5, 2017, 2024),
    ("Kamaz", "Россия", 4, 2008, 2023),
   ("Peugeot", "Франция", 0.6, 2007, 2015),
    ("Kamaz", "Россия", 5, 2008, 2009),
    ("Belaz", "Беларуссия", 180, 2010, 2022),
    ("MG", "Англия", 0.4, 2005, 2016),
};


for (int i = 0; i < cars.Length; i++)
{
    if (cars[i].Registration < 2023 && cars[i].Capacity > 3) cars[i].Print();
}

struct Car
{
    public string Brand;
    public string Manufacturer;
    public double Capacity;
    public int Date;
    public int Registration;
    public Car(string brand, string manufacturer, double capacity, int date, int registration)
    {
        Brand = brand;
        Manufacturer = manufacturer;
        Capacity = capacity;
        Date = date;
        Registration = registration;
    }
    public void Print()
    {
        Console.WriteLine($"Марка автомобиля: {Brand}\nПроизводитель: {Manufacturer}\nГрузоподъемность: {Capacity}\nГод выпуска: {Date}\nДата регистрации: {Registration}\n");
    }
}

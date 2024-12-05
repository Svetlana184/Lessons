/* ООП (Объектно-ориентированное программирование) - подход, при котором программа рассматривается как набор объектов, взаимодействующих друг с другом
 * У каждого объекта есть св-ва и поведение
 * 
 * Основное понятие ООП
 * Класс - пользовательский тип данных, который состоит из данных и функций для выполнения действий с этими данными
 * Объект - экземпляр класса
 * 3 важнейших принципа ООП:
 * инкапсуляция - как объекты прячут своё внутреннее ус-во
 * наследование - как поддерживается повторное использование кода
 * полиморфизм - как реализована поддержка выполнения нужного действия в зависимости от типа передаваемого объекта
 * + абстракция
 * 
 * Реализация в с#
 */

/*
 * инкапсуляция - область видимости (public - открытый, private - закрытый (по умолчанию), protected - доступен из собственного класса и дочерних)
 * принцип инкапсуляции предполагает, что ко внут. данным объекта нельзя обратиться напрямую через экземпляр этого объекта
 * вместо этого для получения инфы о состоянии объекта и изменений предлагается использовать спец. методы
 */

//подход с методами
//Console.WriteLine("введите ширину прямоугольника");
//double w = double.Parse(Console.ReadLine());
//Console.WriteLine("введите высоту прямоугольника");
//double h= double.Parse(Console.ReadLine());
//Rectangle rectangle = new Rectangle(w, h);
//Console.WriteLine($"площадь: {rectangle.GetWidth()} * {rectangle.GetHeight()} = {rectangle.GetArea():F2}");
//Console.WriteLine($"периметр: {rectangle.GetPerimetr():F2}");
//Console.WriteLine("введите новую ширину:");
//w = double.Parse(Console.ReadLine());
//rectangle.setWidth(w);
//Console.WriteLine($"площадь: {rectangle.GetWidth()} * {rectangle.GetHeight()} = {rectangle.GetArea():F2}");
//Console.WriteLine($"периметр: {rectangle.GetPerimetr():F2}");

//class Rectangle
//{
//    private double width;
//    private double height;

//    public Rectangle(double _width, double _height)
//    {
//        this.width = _width;
//        this.height = _height;
//    }
//    public double GetArea() => width * height;
//    public double GetPerimetr() => 2 * (width + height);
//    public double GetWidth() => width;
//    public double GetHeight() => height;
//    public void setWidth(double _w) => width = _w;
//    public void setHeight(double _h) => height = _h;
//}



//свойства


Console.WriteLine("введите название:");
string name = Console.ReadLine();
Console.WriteLine("введите ширину прямоугольника");
double w = double.Parse(Console.ReadLine());
Console.WriteLine("введите высоту прямоугольника");
double h = double.Parse(Console.ReadLine());
Rectangle rectangle = new Rectangle(name,w, h);
Console.WriteLine($"площадь: {rectangle.Width} * {rectangle.Height} = {rectangle.GetArea():F2}");
Console.WriteLine($"периметр: {rectangle.GetPerimetr():F2}");
Console.WriteLine("введите новую ширину:");
w = double.Parse(Console.ReadLine());
rectangle.Width = w;
Console.WriteLine($"площадь: {rectangle.Width} * {rectangle.Height} = {rectangle.GetArea():F2}");
Console.WriteLine($"периметр: {rectangle.GetPerimetr():F2}");

class Rectangle
{
    public string Name {  get; set; } //автоматическое св-во
    private double width;
    public double Width
    {
        get => width; 
        set
        {
            if (value >= 0) width = value;
        }
    }
    private double height;
    public double Height
    {
        get => height;
        set
        {
            if (value >= 0) height = value;
        }
    }
    public Rectangle(string _n, double _w, double _h)
    {
        Name = _n;
        Width = _w;
        Height = _h;
    }
    public double GetArea() => width * height;
    public double GetPerimetr() => 2 * (width + height);
}
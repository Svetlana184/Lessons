// ФУНКЦИИ

string lang = "en";
switch (lang)
{
    case "en": SayHello(); break;
    case "ru": SayHelloRu(); break;
    case "de": SayHelloDe(); break;
}
Console.WriteLine("Введите ваше имя");
string myName = Console.ReadLine();
WriteMyName(myName);
Console.WriteLine("введите x");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("введите y");
int y = int.Parse(Console.ReadLine());
Sum(x, y);
Console.WriteLine("введите ваше имя");
string name = Console.ReadLine();
Console.WriteLine("введите ваш возраст");
int age = int.Parse(Console.ReadLine());
PrintPerson(name, age, "Голубчиков энтертэймент");
PrintPerson(age: 30, name: "B", company: "A");

void SayHello()
{
    Console.WriteLine("hi!");
}
void SayHelloRu()
{
    Console.WriteLine("привет!");
}
void SayHelloDe() => Console.WriteLine("pepe!"); //лямбда-выражение
void WriteMyName(string name) => Console.WriteLine("ваше имя - " + name);
void Sum(int a, int b) => Console.WriteLine($"{a}+{b}={a + b}");
void PrintPerson(string name, int age, string company = "samsung") => Console.WriteLine($"Меня зовут {name}, мне {age}, я работаю в {company}");

void PrintLine()
{
    for (int i = 0; i < 80; i++) Console.Write("*");
}

PrintLine();
Console.WriteLine();
//возвращение значений и оператор return
void PrintPerson(string name, int age, string company = "samsung")
{
    if (age < 0 || age > 120)
    {
        Console.WriteLine("такой возраст не существует");
        return;
    }
    Console.WriteLine($"Меня зовут {name}, мне {age}, я работаю в {company}");
}
PrintPerson("i", 1);
int Summa(int a, int b)
{
    return a + b;
}
int Min(int a, int b) => a - b;
int Sub(int a, int b) => a + b;
int Mult(int a, int b) => a * b;
int Div(int a, int b)
{
    if (b == 0) return a / b;
    else return 0;
}

Console.WriteLine("введите х");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("введите y");
int y = int.Parse(Console.ReadLine());
Console.WriteLine("Введите операцию(+, -, *, /)");
char op = char.Parse(Console.ReadLine());
switch (op)
{
    case '+': Console.WriteLine($"{x}+{y}={Summa(x, y)}"); break;
    case '-': Console.WriteLine($"{x}-{y}={Min(x, y)}"); break;
    case '*': Console.WriteLine($"{x}*{y}={Mult(x, y)}"); break;
    case '/': Console.WriteLine($"{x}/{y}={Div(x, y)}"); break;
    default:
        Console.WriteLine("Такой операции нет");
        break;
}

double Func(int x)
{
    return (Math.Sqrt(x) + x) / 2;
}
double y = Func(6) + Func(13) + Func(21);
Console.WriteLine($"y = {y:F2}");




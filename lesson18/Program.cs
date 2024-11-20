// ФУНКЦИИ

string lang = "en";
switch(lang)
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
Sum(x,y);




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
void Sum(int a, int b) => Console.WriteLine($"{a}+{b}={a+b}");
void PrintPerson(string name, int age) => Console.WriteLine($"Меня зовут {name}, мне {age}");
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
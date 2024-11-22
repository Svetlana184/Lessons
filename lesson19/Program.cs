//ПЕРЕДАЧА ПАРАМЕТРОВ В ФУНКЦИЮ

void Swap(ref int x, ref int y) //передача параметра по ссылке
{
    int temp = x; 
    x = y;
    y = temp;
}
int a = 6;
int b = 7;
Console.WriteLine($"a = {a}, b = {b}");
Swap(ref a, ref b);
Console.WriteLine($"a = {a}, b = {b}"); //a = 7, b = 6

void Swap1(int x,int y) //передача параметра по значению
{
    int temp = x;
    x = y;
    y = temp;
}
a = 6;
b = 7;
Console.WriteLine($"a = {a}, b = {b}");
Swap1(a, b);
Console.WriteLine($"a = {a}, b = {b}"); //a = 6, b = 7

//выходные параметры. Модификатор out

int Summa(int x,int y) => x + y;


Console.WriteLine(Summa(a,b));

void SummaOut(int x, int y, out int res)
{
    res = a + b;
}
int res;
SummaOut(a,b,out res);
Console.WriteLine("res = "+res);
SummaOut(a,b,out int rez);
Console.WriteLine("rez = "+rez);

//входные параметры. Модификатор in

int Square(in int n) //теперь изменять n внутри функции нельзя
{
    //n = 8;
    return n * n;
}


Console.WriteLine("5 * 5 = " + Square(5));

//массив параметров и ключевое слово params

int SumParams(params int[] numbers)
{
    int sum = 0;
    foreach (int n in numbers)
    {
        sum += n;
    }
    return sum;
}
Console.WriteLine(SumParams(5, 6, 7, 0, 1, 2));

int SumMas(int[] mas)
{
    int sum = 0;
    foreach (int n in mas)
    {
        sum += n;
    }
    return sum;
}
Random rand = new Random();
int[] massive = new int[10];
for (int i = 0; i < massive.Length; i++)
{
    massive[i] = rand.Next(1, 3);
    Console.Write(massive[i] + " ");
}
Console.WriteLine();
Console.WriteLine(SumMas(massive));


//Рекурсивные функции
//рекурсивная фнкция - такая конструкция, при которой функция вызывает саму себя. Это прямая рекурсия

//косвенная - когда две или более процедур вызывают друг друга

/* структура
 * действия на входе в рекурсию
 * if when
 * действия выхода из рекурсии
 * else вызов процедуры с другими параметрами
 */

/*
 * рекурсия должна иметь условие завершения, нерекурсивную ветвь
 * в качестве условия выступают граничные условия параметров, при которых результат работы рекурсии известен - условие завершения вхождения в рекурсию
 */

//рекурсивная функция факториала
long FactorialRecursive(int n)
{
    if (n == 1 || n == 0) return 1;
    else
    {
        return n * FactorialRecursive(n - 1);
    }
}
Console.WriteLine(FactorialRecursive(5));

//нерекурсивная
long Factorial(int n)
{
    long F = 1;
    for (int i = 1; i <= n;i++)
    {
        F *= i;
    }
    return F;
}
Console.WriteLine(Factorial(5));

int F1(int n)
{
    if (n <= 0) return 0;
    else if (n > 0 && n % 2 == 0) return F1(n / 2);
    else return 1 + F1(n - 1);
}
int count = 0;
for (int i = 0; i <= 1000;  i++)
{
    if (F1(i) == 3) count++;
}
Console.WriteLine(count);

int Fib(int n)
{
    if (n == 1) return 0;
    else if (n==2 || n==3) return 1;
    else return Fib(n - 2) + Fib(n - 1);
}
for (int i = 1; i <= 30;i++)
{
    Console.Write(Fib(i) + " ");
}
Console.WriteLine();

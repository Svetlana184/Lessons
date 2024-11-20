//одномерные массивы: ввод

////просто массив в проге
//int[] mas1 = { 5, 6, 2, 4, 10, 22, 11 };

////ввод массива с клавиатуры
//int[] mas2 = new int[5];
//Console.WriteLine("введите элементы массива");
//for (int i = 0; i < mas2.Length; i++)
//{
//    Console.WriteLine($"введите {i+1} элемент массива");
//    try
//    {
//        mas2[i] = int.Parse(Console.ReadLine());
//    }
//    catch
//    {
//        Console.WriteLine("введите число правильно");
//        i--;
//    }
//}
//for (int i = 0;i < mas2.Length;i++)
//{
//    Console.Write(mas2[i]+" ");
//}
//Console.WriteLine();

////генерация массива по формуле
//int[] mas3 = new int[10];
//for (int i = 0; i < mas3.Length; i++)
//{
//    mas3[i] = 2 * i + 1;
//    Console.Write(mas3[i]+" ");
//}
//Console.WriteLine();

////рандомный int
//int[] mas4 = new int[10];
//Random random = new Random();
//for (int i = 0; i < mas4.Length; i++)
//{
//    mas4[i] = random.Next(10,100);
//    Console.Write(mas4[i] + " ");
//}
//Console.WriteLine();

////рандомный float
//double[] mas5 = new double[10];
//for (int i = 0; i < mas5.Length; i++)
//{
//    //mas5[i] = random.NextDouble(); //от нуля до едининцы
//    //mas5[i] = random.NextDouble() * 10;
//    Console.Write($"{mas5[i]:F2} ");
//}
//Console.WriteLine();
//основные операции с массивами


//поиск элемента в массиве
int[] mas = new int[10];
Random random = new Random();
for (int i = 0; i < mas.Length; i++)
{
    mas[i] = random.Next(10, 100);
    Console.Write(mas[i] + " ");
}
Console.WriteLine();

//поиск элемента в массиве
Console.WriteLine("введите число");
try
{
    int x = int.Parse(Console.ReadLine());
    for (int i = 0; i < mas.Length; i++)
    {
        if (mas[i] == x)
        {
            Console.WriteLine($"элемент найден в позиции {i+1}");
            break;
        }
    }

}
catch
{
    Console.WriteLine("введите число правильно!");
}
//поиск максимального и минимального элемента

//1 способ

int max = mas[0];
int min = mas[0];
for (int i = 1; i < mas.Length; i++)
{
    if (mas[i] > max)
    {
        max = mas[i];
    }
    if (mas[i] < min)
    {
        min = mas[i];
    }
}
Console.WriteLine($"минимальное число в массиве {min}");
Console.WriteLine($"максимальное число в массиве {max}");

//2 способ

int max1 = int.MinValue;
int min1 = int.MaxValue;
for (int i = 0; i < mas.Length; i++)
{
    if (mas[i] > max1)
    {
        max1 = mas[i];
    }
    if (mas[i] < min1)
    {
        min1 = mas[i];
    }
}
Console.WriteLine($"минимальное число в массиве {min1}");
Console.WriteLine($"максимальное число в массиве {max1}");

//сортировка массива

for (int i = 0; i < mas.Length;i++)
{
    for (int j = i+1; j < mas.Length; j++)
    {
        if (mas[i] > mas[j])
        {
            int temp = mas[i];
            mas[i] = mas[j];   
            mas[j] = temp;
        }
    }
}
foreach(int i in mas)
     Console.Write(i + " ");
Console.WriteLine();
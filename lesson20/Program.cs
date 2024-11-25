using static ClassLab6_2.ClassLib;
//БИБЛИОТЕКИ
//база
Random random = new Random();
//int[,] mas = new int[7, 4];
//for (int i = 0; i < mas.GetLength(0); i++)
//{
//    for (int j = 0; j < mas.GetLength(1); j++)
//    {
//        mas[i, j] = random.Next(10, 100);
//        Console.Write(mas[i,j] + " ");
//    }
//    Console.WriteLine();
//}
//Console.WriteLine("сумма индексов максимального элемента: " + IndexMax(mas));
//средний
double[,] mas = new double[8, 3];
for (int i = 0; i < mas.GetLength(0); i++)
{
    for (int j = 0; j < mas.GetLength(1); j++)
    {
        mas[i, j] = Math.Pow((Math.Sin(i*i) + Math.Cos(j * j)), (i-5)/(j+1)) + 7.45 * Math.Tan((i-5)/(j+8));
        Console.Write($"{mas[i,j]:F2} ");
    }
    Console.WriteLine();
}
Console.WriteLine("сумма элементов строк матрицы: ");
double[] vector = SumRows(mas);
foreach (double x in vector) Console.Write($"{x:F2} ");
Console.WriteLine();
double res = Res(vector);
Console.WriteLine("разница между макисмальным элментом и индексом минимального элемента : \n" + res);
Random random = new Random();
int[,] mas = new int[random.Next(3, 6), random.Next(3, 6)];
int[] min_mas = new int[mas.GetLength(0)];
for (int i = 0; i < mas.GetLength(0); i++)
{
    for (int j = 0; j < mas.GetLength(1); j++)
    {
        mas[i, j] = random.Next(10, 100);
        Console.Write(mas[i, j] + " ");
    }
    Console.WriteLine();
}
int k = 0;
int[,] mas_final = new int[0, 0];
for (int i = 0; i < mas.GetLength(0); i++)
{
    int n = 0;
    for (int j = 0; j < mas.GetLength(1); j++)
    {
        Array.Resize<int>(ref mas, k + 1, n + 1);
        mas6[k, n++] = mas5[i, j];
    }
    k++;
}





int max = int.MinValue;
for (int i = 0; i < min_mas.Length;i++)
{
    if (min_mas[i] > max) max = min_mas[i];
}
for (int i = 0; i < mas.GetLength(0); i++)
{
    for (int j = 0; j < mas.GetLength(1); j++)
    {
        if (mas[i, j] == max) Console.WriteLine($"максимальное число среди минимальных - {max}\nЕго индексы - {i},{j}");
    }
}
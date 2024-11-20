// двумерные массивы

int[,] mas1 = new int[3, 4]; //массив 3х4 из нулей
int[,] mas2 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };


//найти макс и мин матрицы в целом, а также каждой строки

Random random = new Random();
int[,] mas3 = new int[3, 4];
for (int i = 0; i < mas3.GetLength(0); i++) // 0 - первая размерность (колво строк)
{
    int max_row = int.MinValue;
    int min_row = int.MaxValue;
    for (int j = 0; j < mas3.GetLength(1); j++) // колво столбцов
    {
        mas3[i, j] = random.Next(10, 100);
        Console.Write(mas3[i, j] + " ");
        if (mas3[i, j] > max_row) max_row = mas3[i, j];
        if (mas3[i, j] < min_row) min_row = mas3[i, j];
    }
    Console.WriteLine($"min - {min_row}, max - {max_row}");
}
Console.WriteLine();

int max = int.MinValue;
int min = int.MaxValue;
for (int i = 0; (i < mas3.GetLength(0)); i++)
{

    for (int j = 0; j < mas3.GetLength(1); j++)
    {
        if (mas3[i, j] > max) max = mas3[i, j];
        if (mas3[i, j] < min) min = mas3[i, j];
    }


}
Console.WriteLine($"минимальный элемент  - {min}");
Console.WriteLine($"максимальный элемент  - {max}");
Console.WriteLine();

//сумма элементов строк и столбцов, сумма всей матрицы
int[,] mas4 = new int[random.Next(3, 6), random.Next(3, 6)];
int S = 0;
for (int i = 0; i < mas4.GetLength(0); i++) // 0 - первая размерность (колво строк)
{
    double s_r = 0;
    for (int j = 0; j < mas4.GetLength(1); j++) // колво столбцов
    {
        mas4[i, j] = random.Next(10, 100);
        Console.Write(mas4[i, j] + " ");
        S += mas4[i, j];
        s_r += mas4[i, j];
    }
    s_r/=mas4.GetLength(1);
    Console.WriteLine($"s_r = {s_r:F2}");
}


for (int i = 0; i < mas4.GetLength(1); i++)
{
    double s_c = 0;
    for (int j = 0; j < mas4.GetLength(0); j++)
    {
        s_c += mas4[j, i];
    }
    s_c /= mas4.GetLength(0);
    Console.Write($"{s_c:N2} ");
}
Console.WriteLine();
Console.WriteLine($"S = {S}");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();


int[,] mas5 = new int[random.Next(3, 6), random.Next(3, 6)];
for (int i = 0; i < mas5.GetLength(0); i++) // 0 - первая размерность (колво строк)
{
    for (int j = 0; j < mas5.GetLength(1); j++) // колво столбцов
    {
        mas5[i, j] = random.Next(10, 100);
        Console.Write(mas5[i, j] + " ");
    }
    Console.WriteLine();
}

int k = 0;
int[] mas6 = new int[k];
for (int i = 0;i < mas5.GetLength(0);i++)
{
    for(int j = 0;j < mas5.GetLength(1);j++)
    {
        if(Array.IndexOf(mas6, mas5[i,j]) == -1)
        {
            Array.Resize<int>(ref mas6, k + 1);
            mas6[k++] = mas5[i,j];
        }
    }
}
foreach(int i in mas6) Console.Write(i + " ");
Console.WriteLine();

for(int i = 0; i < mas6.Length; i++)
{
    int m = 0;
    for (int j = 0; j < mas5.GetLength(0); j++)
    {
        for (int l = 0; l < mas5.GetLength(1); l++)
        {
            if (mas6[i] == mas5[j, l]) m++;

        }
        
    }
    Console.WriteLine(mas6[i] + " - " + m);
}

Console.WriteLine("введите первый элемент прогрессии:");
int a1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите разность");
int d = int.Parse(Console.ReadLine());
int[,] mas7 = new int[random.Next(3, 6), random.Next(3, 6)];
int n = 1;
for (int i = 0; i < mas7.GetLength(0); i++)
{
    for (int j = 0; j < mas7.GetLength(1); j++)
    {
        mas7[i, j] = a1 + d * (n++-1);
        Console.Write(mas7[i, j]+" ");
    }
    Console.WriteLine();
}
//i == j - главная диагональ
//i + j = n-1 (размерность) - побочная диагональ
//i + j <  n - 1 - выше побочной
//i + j > n - 1 - ниже побочной
// i < j - выше главной
//  i > j - ниже главной
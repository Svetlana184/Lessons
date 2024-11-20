double[] mas = new double[12];
Random random = new Random();
// рандомный массив с двоичными числами
for (int i = 0; i < mas.Length; i++)
{
    int temp = random.Next(10, 100);
    Console.WriteLine(temp);
    int counter = 0;
    mas[i] = 0;
    while (temp > 1)
    {
        mas[i] = mas[i] + (temp%2) * Math.Pow(10, counter);
        counter+=1;
        temp /= 2;
    }
    mas[i] += 1* Math.Pow(10, counter);
    Console.WriteLine(mas[i]);

}
for (int i = 0;i < mas.Length; i++)
{
    double ex = mas[i];
    int counter2 = 0;
    for (int j = i; j < mas.Length; j++)
    {
        if(ex == mas[j])
        {
            counter2++;
            if (counter2 > 2)
            {
                mas[j] = 0;
            }
        }
    }
}
double[] res = Array.FindAll(mas, p => p != 0);
foreach (int item in res) Console.Write(item + " ");
Console.WriteLine();

//double[] mas = new double[12];
//Random random = new Random();
//for (int i = 0;i  < mas.Length;i++)
//{
//    mas[i] = random.NextDouble() * 90 + 10;
//    Console.Write($"{mas[i]:F2} ");
//}
//double min = double.MaxValue;
//int imin = -1;
//for  (int i = 0; i < mas.Length;i++)
//{
//    if (mas[i] < min)
//    {
//        min = mas[i]; imin = i;
//    }
//}
//Console.WriteLine($"min = {(min+imin):F2}");

////средний уровень
//Random random1 = new Random();
//int length = random1.Next(10, 20);
//double[] mas1  = new double[length];
//double[] mas2 = new double[length];
//for (int i = 0; i  < length;i++)
//{

//}

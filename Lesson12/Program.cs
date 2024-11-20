//class array - класс для работы с массивами
/*
 Методы массива

*Length - длина массива
*Rank - размерность массива
*BinarySearch - бинарный поиск (в уже отсортированном массиве)
*Sort - сортировка массива
*IndexOf - возвращает индекс первого вхождения элемента в массив
*LastIndexOf - возвращает индекс последнего вхождения элемента в массив
*FindIndex - возвращает индекс первого вхождения элемента, который удовлетворяет опр. условию
*FindLastIndex - возвращает индекс последнего вхождения элемента, который удовлетворяет опр. условию
*Find - находит первый элемент, удовлетворяющий условию (или null)
*FindLast - находит последний элемент, удовлетворяющий условию (или null)
*FindAll - возвращает в виде массива все эелементы, которые удовлятворяют опр. условию
*Reverse - располагает элементы массива в обраном порядке
*Exists - содержит ли массив элемент, которые удовлетворяют условию
*Fill - заполняет массив некоторым значением value
*Resize - изменяет размер одномерного массива
 */

string[] people = { "Gabitov U", "Karpov T", "Goluboy G", "Kirill H" };
Console.WriteLine(people.Length); //4
Console.WriteLine(people.Rank); //1
Array.Sort(people);
foreach (string item in people) Console.Write(item + " ");
Console.WriteLine();

int[] numbers = { 4, 8, 3, 2, 6, 9, 1, 7 };
Array.Sort(numbers);
foreach (int item in numbers) Console.Write(item + " ");
Console.WriteLine();
Console.WriteLine(Array.BinarySearch(numbers, 6));
Console.WriteLine(Array.BinarySearch(numbers, 5));
Console.WriteLine();


//поиск индекса элемента
int[] mas = { 7, 3, 9, 3, 8, 3, 6 };
Console.WriteLine(Array.IndexOf(mas,3));
Console.WriteLine(Array.LastIndexOf(mas, 3));


//лямбда-выражение
Console.WriteLine(Array.FindIndex(mas, p=>p>7));
Console.WriteLine(Array.FindLastIndex(mas, p => p > 7));

//find
Console.WriteLine(Array.Find(mas, p=>p>=3));
Console.WriteLine(Array.FindLast(mas, p => p >= 3));

int[] res = Array.FindAll(mas, p=>p>5);
foreach (int item in res) Console.Write(item + " ");
Console.WriteLine();
Array.Reverse(mas);

foreach (int item in mas) Console.Write(item+" ");
Console.WriteLine();

Console.WriteLine(Array.Exists(mas, p=>p>7));

int[] fillmas = new int[10];
Array.Fill(fillmas, 5);
foreach (int item in fillmas) Console.Write(item + " ");
Console.WriteLine();
int[] fillmas1 = new int[10];
Array.Fill(fillmas1, 3,1,7);
foreach (int item in fillmas1) Console.Write(item + " ");
Console.WriteLine();


int[] copymas = new int[10];
Array.Copy(fillmas, copymas,5);
foreach (int item in copymas) Console.Write(item + " ");
Console.WriteLine();

Array.Clear(mas);
foreach (int item in mas) Console.Write(item + " ");
Console.WriteLine();

Array.Resize<int>(ref mas, 8);
foreach (int item in mas) Console.Write(item + " ");
Console.WriteLine();
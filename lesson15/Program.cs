//СТРОКИ

using System.Security.Cryptography;

string s1 = "hello"; //hello
Console.WriteLine(s1);
string s2 = new string('a', 6); //aaaaaa
Console.WriteLine(s2);
string s3 = new string(new char[] { 'd', 'c', 'q', 'r'}); //dcqr
Console.WriteLine(s3);
string s4 = new string(new char[] { 'd', 'c', 'q', 'r' }, 1,2); //cq
Console.WriteLine(s4);
Console.WriteLine(s1.Length);
Console.WriteLine(s1[3]);
for (int i = 0; i < s1.Length; i++)
{
    Console.Write(s1[i] + " ");
}
Console.WriteLine();
Console.WriteLine(s1==s4);
Console.WriteLine(s1 != s4);
string text = """ 
    rrrrr
    rrr
    rr
    r
    """;
Console.WriteLine(text);

//ОПЕРАЦИИ СО СТРОКАМИ

//объединение строк

string s5 = "hello, ";
string s6 = "world";
string s7 = s5 + s6;
Console.WriteLine(s7);
string s8 = string.Concat(s7, "!!!!");
Console.WriteLine(s8);
string s9 = "A";
string s10 = "B";
string s11 = "C";
string[] strings = new string[] {s9, s10, s11};
string s14 = string.Join(" ", strings);
Console.WriteLine(s14);

//сравнение строк

string s15 = "hello";
string s16 = "world";
string s17 = "world";
string s18 = "aello";
int result = string.Compare(s15, s16); //-1 второй аргумент больше, чем первый
int result1 = string.Compare(s17, s16); //0 аргументы равны
int result2 = string.Compare(s15, s18); //1 второй аргумент меньше, чем первый
Console.WriteLine(result);
Console.WriteLine(result1);
Console.WriteLine(result2);

//поиск в строке

string s19 = "Hello, world!";
Console.WriteLine(s19.IndexOf('o'));
Console.WriteLine(s19.LastIndexOf('o'));
Console.WriteLine(s19.StartsWith("Hell"));
Console.WriteLine(s19.EndsWith("Hell"));
string[] files = { "first.jpg", "second.bmp", "third.exe", "four.exe" };
for (int i = 0;  i < files.Length; i++)
{
    if (files[i].EndsWith("exe"))
    {
        Console.WriteLine(files[i]);
    }
}

//разделение строк

string s20 = "DDDDDD ijhkljoij kniolknljoi knjm jlknmklnoi, kfmgk, kknnkm";
string[] words = s20.Split(' ', ',',StringSplitOptions.RemoveEmptyEntries);
foreach (string word in words) Console.WriteLine(word + " ");

//обрезка строки
string s21 = " Good day ";
Console.WriteLine(s21.Trim()); //Good Day
Console.WriteLine(s21); // Good Day
s21 = s21.Trim();
Console.WriteLine(s21); //Good Day
Console.WriteLine(s21.Trim('G', 'y')); //ood da
string s22 = s21.Substring(2); //начиная со второго элемента
Console.WriteLine(s22);

string s23 = s21.Substring(2, 3); //начиная со второго элемента до третьего
Console.WriteLine(s23);

//Удаление
string s24 = "Хороший Катакай";
s24 = s24.Remove(7, 4); // удаляет 4 символа, начиная с седьмого
Console.WriteLine(s24);
s24 = s24.Remove(7);
Console.WriteLine(s24);

//Вставка
string s25 = "RRRRRRr";
s25 = s25.Insert(5, "eeeee");
Console.WriteLine(s25);

//Замена

string s26 = "Хороший день";
s26 = s26.Replace("Хороший", "Плохой");
Console.WriteLine(s26);

//Смена регистра

string s27 = "всем привет";
s27 = s27.ToUpper();
Console.WriteLine(s27);


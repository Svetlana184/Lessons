//работа со строками и символами
//
//char - 2 байта - ' '
//string - " "
//StringBuilder


char ch = 'q';
char p = '\n';
char d = (char)1000;
Console.WriteLine(d);


int first = (int)'A';
int last = (int)'z';
for (int i = 0; i <= last; i++)
{
    Console.WriteLine($"{i} - {(char)i}");
}

for (int i = (int)'0'; i <= (int)'9'; i++)
{
    Console.WriteLine($"{i} - {(char)i}");
}

//IsDigit

if (char.IsDigit(ch)) Console.WriteLine("цифра");
else Console.WriteLine("не цифра");

//IsLetter

if (char.IsLetter(ch)) Console.WriteLine("буква");
else Console.WriteLine("не буква");

//IsControl - управляющий символ

if (char.IsControl('\xA')) Console.WriteLine("управляющий");
else Console.WriteLine("не управляющий");



//ЗАДАЧИ 
char[] mas = new char[10];
Random random = new Random();
for (int i = 0; i < mas.Length;i++)
{
    mas[i] = (char)random.Next((int)'А', (int)'я'+1);
    Console.Write(mas[i] + " ");
}
Console.WriteLine();
//IsUpper - заглавная буква, ToUpper - преобразование в большую, IsLower, ToLower
// Is Punctuation - знак препинания
// IsSeparator - знак разделителя
//IsSymbol - символ
//IsWhiteSpace - пробел
for (int i = 0;i < mas.Length;i++)
{
    if (char.IsUpper(mas[i])) mas[i] = char.ToLower(mas[i]);
    else mas[i] = char.ToUpper(mas[i]);
    Console.Write(mas[i] + " ");
}
Console.WriteLine();



//for (int i = 0; i < mas.Length;i++)
//{
//    mas[i] = char.Parse(Console.ReadLine());
//}
//Console.WriteLine();
//foreach (var item in mas) Console.Write(item + " ");
//Console.WriteLine();
//int count = 0;
//for (int i = 0; i < mas.Length; i++)
//{
//    if (mas[i] == 'r' || mas[i] == 'k' || mas[i] == 't') count++;
//}
//Console.WriteLine("count = " + count);


int length = random.Next(10, 20);
char[] mas1 = new char[length];

for (int i = 0; i < mas1.Length; i++)
{
    mas1[i] = char.Parse(Console.ReadLine());
}
Console.WriteLine();
foreach (char c in mas1) Console.Write(c);
Console.WriteLine();
char[] mas_temp =  new char[length];
int k = 0;
for (int i = 0; i < mas1.Length; i++)
{
    if (char.IsLetter(mas1[i])) mas_temp[k++] = mas1[i];
    else
    {
        if (Array.IndexOf(mas_temp, 'k') != -1)
        {
            foreach (char c in mas_temp) Console.Write(c);
            Console.WriteLine();
        }
        else
        {
            for (int j = 0; j < mas_temp.Length; j++) mas_temp[j] = '\0';
            k = 0;
        }
        
    }
}

int l = random.Next(10, 20);
char[]mas2 = new char[l];
for (int i = 0; i <= mas2.Length; i++)
{
    mas2[i] = char.Parse(Console.ReadLine());
}
int max = int.MaxValue;
for (int i = 0; i < mas2.Length; i++)
{
    if (char.IsNumber(mas2[i]))
    {
    }
}
﻿string[] mas = new string[5];
int count = -1;
for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Введите {i + 1} строку на с++ посимвольно, не вводя пробелы\nПосле ввода последнего элемента нажмите Enter дважды");
    char[] chars = [];
    try
    {
        char elem = char.Parse(Console.ReadLine());
        while (elem != '\0')
        {
            Array.Resize<char>(ref chars, chars.Length + 1);
            chars[chars.Length - 1] = elem;
            try
            {
                elem = char.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("строка введена");
                count = Array.IndexOf(chars, '=');
                mas[i] = String.Join("", chars);
                Console.WriteLine(mas[i]);
                if (count != -1)
                {
                    if (mas[i].Substring(count+1) == mas[i].Substring(0, count) + "+1;") mas[i] = mas[i].Substring(0, count) + "++;";
                    if (mas[i].Substring(count + 1) == mas[i].Substring(0, count) + "-1;") mas[i] = mas[i].Substring(0, count) + "--;";
                }
                break;
            }
        }
    }
    catch
    {
        Console.WriteLine("строка не может быть пустой");
        i--;
    }
}
foreach (string c in mas) Console.WriteLine(c);

Console.WriteLine("введите первое число");
string ch1 = Console.ReadLine();
Console.WriteLine("Введите второе число");
string ch2 = Console.ReadLine();
if (ch1.Length > ch2.Length)
{
    string tmp = new string('0', ch1.Length - ch2.Length);
    ch2 = tmp + ch2;
}
else
{
    string tmp = new string('0', ch2.Length - ch1.Length);
    ch1 = tmp + ch1;
}
string tmp2 = new string('0', ch1.Length-1);
string ed = tmp2 + "1";
Console.WriteLine("первое число" + ch1);
string ch2_inv = "";
for (int i = 0; i < ch2.Length; i++)
{
    if (ch2[i] == '0') ch2_inv += "1";
    if (ch2[i] == '1') ch2_inv += "0";
}
Console.WriteLine("второе инвентированное число" + ch2_inv);
Console.WriteLine("единица" + ed);

int Sum2 (string ch1,  string ch2, int i = 1, int p = 0)
{
    if (ch1[ch1.Length - 1] == '1' && ch2[ch2.Length - 1] == '1')
    {
        //

    }
}
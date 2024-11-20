using System.Text;

StringBuilder sb1 = new StringBuilder(); // class StringBuilder - динамическая строка
StringBuilder sb2 = new StringBuilder("Hello");
Console.WriteLine(sb2);
Console.WriteLine($"Length - {sb2.Length}"); //длина - 5
Console.WriteLine($"Capacity - {sb2.Capacity}"); //ёмкость - 16 
StringBuilder sb3 = new StringBuilder("New String", 32);
Console.WriteLine(sb3);
Console.WriteLine($"Length - {sb3.Length}"); //длина - 10
Console.WriteLine($"Capacity - {sb3.Capacity}"); //ёмкость - 32

string str = "Hello, world";
str = str.Insert(7, "me");
Console.WriteLine(str); //строка неизменяема

//METHODS
sb1.Append("First"); //add element to string
Console.WriteLine(sb1); 

sb1.Insert(5, " second"); //объединение строк
Console.WriteLine(sb1);

sb1.Remove(10, 2); //удаление
Console.WriteLine(sb1);

sb1.Replace("First", "Первый"); //замена
Console.WriteLine(sb1);

sb1.AppendFormat("Второй"); //добавление
Console.WriteLine(sb1);

//когда сипользовать string, а когда StringBuilder
/* string, если
 *  при небольшом кол-ве операций и изменений
 *  при выполнении фиксированного кол-ва объединений
 *  при выполнении
 */

//

//РЕГУЛЯРНЫЕ ВЫРАЖЕНИЯ


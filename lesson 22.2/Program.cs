// СТРУКТУРЫ И ЗАПИСИ
/*
 * Структура - это набор зависимых друг от друга переменных. Зависимость исключительно логическая и определяется условиями задачи
 * Структура относится к типу значений, а не к ссылочному
 * 
 * описание:
 * struct name_structure
 * {
 *      public тип поле1;
 *      public тип поле2;
 *      ...
 * };
 * 
 * пример:
 * struct person
 * {
 *      public string fio;
 *      public DateTime dat;
 *      public char pol;
 * };
 */

using System.Net.Http.Headers;

Person tom = new Person();
tom.name = "Tom";
tom.age = 30;
tom.Print();
Person golub = new();
golub.name = "Голубок";
golub.age = 25;
golub.Print();
Person bob = new Person("Bob", 32);
Console.WriteLine(bob.age);
Console.WriteLine(bob.name);
Console.WriteLine();
Person jerry = bob with { name = "Jerry" };
Console.WriteLine(jerry.name);
Console.WriteLine(jerry.age);


Human human = new Human("Хроменков", 20);



struct Person
{
    public string name;
    public int age;
    public Person(string _name, int _age)
    {
        name = _name;
        age = _age;
    }
    public void Print()
    {
        Console.WriteLine($"Имя {name}\nВозраст {age}");
        Console.WriteLine();
    }
};

//records представляет новый ссылочный тип, который появился в c# 9
//ключевая особенность - они могут представлять неизменяемый (immutable) тип, который по умолчанию обладает рядом доп. возможностей по сравнению со структурами



public record Human
{
    public string name;
    public int age;

    public Human(string _name, int _age)
    {
        this.name = _name;
        this.age = _age;
    }
    public void Print()
    {
        Console.WriteLine($"имя - {name}, возраст - {age}");
    }
};
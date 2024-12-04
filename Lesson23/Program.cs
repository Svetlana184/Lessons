﻿//РАБОТА С ДАТАМИ И ВРЕМЕНЕМ
//тип DateTime - структура

using System.Globalization;


DateTime dateTime = new DateTime(); //01.01.0001 00:00:00
Console.WriteLine(dateTime);
Console.WriteLine(DateTime.MinValue);
DateTime date1 = new DateTime(2024, 12, 3); //03.12.2024
Console.WriteLine(date1);
DateTime date2 = new DateTime(2024, 12, 3, 13, 30, 25); //03.12.2024 13:30:25
Console.WriteLine(date2);
Console.WriteLine(DateTime.Now); //время сейчас
Console.WriteLine(DateTime.UtcNow); //время по гринвичу
Console.WriteLine(DateTime.Today);
DateTime somedate = new DateTime(1582, 10, 5);
Console.WriteLine(somedate.DayOfWeek);
DateTime today = DateTime.Now;

//СВОЙСТВА
Console.WriteLine(today.Date);
Console.WriteLine(today.Day);
Console.WriteLine(today.DayOfWeek);
Console.WriteLine(today.DayOfYear);
Console.WriteLine(today.Minute);
Console.WriteLine(today.Second);
Console.WriteLine(today.TimeOfDay);
Console.WriteLine(today.Year);
Console.WriteLine(today.Month);

//МЕТОДЫ
today = today.AddHours(4); //сам по себе неизменяемый тип
Console.WriteLine(today);
Console.WriteLine(today.AddDays(3));
Console.WriteLine(today.AddMonths(14));
Console.WriteLine(today.AddYears(3));
Console.WriteLine(today.AddYears(-2));
DateTime date3 = new DateTime(1917, 11, 7);
DateTime date4 = new DateTime(1991, 8, 21);
Console.WriteLine(date4.Subtract(date3));
Console.WriteLine(today.ToLocalTime());
Console.WriteLine(today.ToUniversalTime());
Console.WriteLine(today.ToLongDateString());
Console.WriteLine(today.ToShortDateString());
Console.WriteLine(today.ToLongTimeString());
Console.WriteLine(today.ToShortTimeString());
Console.WriteLine(date3.Equals(date4));
Console.WriteLine(date3.CompareTo(date4));

//форматирование дат и времени
Console.WriteLine($"D : {today.ToString("D")}");
Console.WriteLine($"d : {today.ToString("d")}");
Console.WriteLine($"F : {today.ToString("F")}");
Console.WriteLine($"f : {today.ToString("f")}");
Console.WriteLine($"G : {today:G}");
Console.WriteLine($"g : {today:g}");
Console.WriteLine($"M : {today:M}");
Console.WriteLine($"O : {today:O}");
Console.WriteLine($"o : {today:o}");
Console.WriteLine($"R : {today:R}");
Console.WriteLine($"T : {today:T}");
Console.WriteLine($"t : {today:t}");
Console.WriteLine($"U : {today:U}");
Console.WriteLine($"u : {today:u}");
Console.WriteLine($"Y : {today:Y}");

Console.WriteLine(today.ToString("hh:mm:ss"));
Console.WriteLine(today.ToString("dd:MM:yyyy"));

//DateOnly 
DateOnly d1 = new DateOnly();
Console.WriteLine(d1);
DateOnly d2 = new DateOnly(2024, 12,4);
Console.WriteLine(d2);
DateOnly d3 = new DateOnly(2024, 12, 4, new JulianCalendar());
Console.WriteLine(d3);
DateOnly now = DateOnly.FromDateTime(DateTime.Now);
Console.WriteLine(now.Day);
Console.WriteLine(now.Month);
Console.WriteLine(now.Year);
Console.WriteLine(now.DayNumber);
Console.WriteLine(now.DayOfWeek);
Console.WriteLine(now.DayOfYear);
Console.WriteLine(DateOnly.MinValue);
Console.WriteLine(DateOnly.MaxValue);
now = now.AddDays(4);
now = now.AddMonths(4);
now = now.AddYears(-1);
Console.WriteLine(now.ToShortDateString());
Console.WriteLine(now.ToLongDateString());

//TimeOnly
TimeOnly t1 = new TimeOnly();
Console.WriteLine(t1);
TimeOnly t2 = TimeOnly.FromDateTime(DateTime.Now);
Console.WriteLine(t2);
Console.WriteLine(t2.Second);
Console.WriteLine(t2.Minute);
Console.WriteLine(t2.Hour);
Console.WriteLine(t2.Millisecond);
Console.WriteLine(t2.Ticks);
Console.WriteLine(t2.AddHours(4));
Console.WriteLine(t2.AddMinutes(4));
Console.WriteLine(t2.Add(t2 - t1));
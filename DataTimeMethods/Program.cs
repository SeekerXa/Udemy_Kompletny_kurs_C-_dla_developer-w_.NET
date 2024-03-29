﻿// See https://aka.ms/new-console-template for more information
using System;
;
Console.WriteLine("Hello, World!");
//DataTimeModification();
//DateTimeFormatting();
TimeNeasurement();



static void DataTimeModification()
{
    DateTime now = DateTime.Now;
    DateTime openDate = new DateTime(1992, 6, 17);
    TimeSpan result = now - openDate;

    Console.WriteLine(result.Days);

    DateTime expiresAt = now.AddDays(7);
    DateTime expiresAt2 = now.Add(new TimeSpan(4, 3, 3));

    Console.WriteLine(expiresAt);
    Console.WriteLine(expiresAt2);

    bool expiresAtTheSameDay = expiresAt.Date == expiresAt2.Date;
    Console.WriteLine($"expires at the same date: {expiresAtTheSameDay}");
}

static void DateTimeFormatting()
{
    DateTime now = DateTime.Now;
    Console.WriteLine(now.ToShortDateString());
    Console.WriteLine(now.ToLongDateString());
    Console.WriteLine(now.ToString("g"));
    Console.WriteLine(now.ToString("G"));
    Console.WriteLine(now.ToString("yyyy-MM-dd hh:mm:ss")); 

}


static void TimeMeasurement()
{
    Console.WriteLine("what is 2 +2 ?");
    Console.WriteLine("A) 4");
    Console.WriteLine("B) 3");
    Console.WriteLine("C) 1");
    Console.WriteLine("D) 6");

    DateTime start = DateTime.Now;

    string userAswer = Console.ReadLine();

    DateTime end = DateTime.Now;

    TimeSpan responseTime = end - start;

    Console.WriteLine($" REsponse took you {responseTime.TotalSeconds} seconds");


}


static void DateTimeHelpers()
{
    int daysInFeb2021 = DateTime.DaysInMonth(2021, 2);    //   28
    bool isLeapYear = DateTime.IsLeapYear(2021);               //    false
     
}
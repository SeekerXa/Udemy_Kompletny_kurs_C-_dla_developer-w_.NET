// See https://aka.ms/new-console-template for more information
using System;
;
Console.WriteLine("Hello, World!");
//DataTimeModification();
//DateTimeFormatting();




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
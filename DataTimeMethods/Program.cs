// See https://aka.ms/new-console-template for more information
using System;
;
Console.WriteLine("Hello, World!");
DataTimeModification();





static void DataTimeModification()
{
    DateTime now = DateTime.Now;
    DateTime openDate = new DateTime(1992, 6, 17);
    TimeSpan result = now- openDate ;

    Console.WriteLine(result.Days);




}
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using CsvHelper;
using CsvHelper.Configuration;


namespace LINQDeeperLook
{


    class Program
    {
        static void Main(string[] args)
        {
            string csvPath = @"E:\Projects\Learning\C#\Udemy_Kompletny_kurs_C-_dla_developer-w_.NET\LINQDeeperLook\Data\googleplaystore1.csv";
            var googleApps = LoadGoogleAps(csvPath);

            // Display(googleApps);
            GetData(googleApps);

        }

        static void Display(IEnumerable<GoogleApp> googleApps)
        {
            foreach (var googleApp in googleApps)
            {
                Console.WriteLine(googleApp);
            }                                            
            Console.WriteLine("..................................");
                                                        
        }
        static void Display(GoogleApp googleApp)
        {
            Console.WriteLine(googleApp);
        }

        static List<GoogleApp> LoadGoogleAps(string csvPath)
        {
            using (var reader = new StreamReader(csvPath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Context.RegisterClassMap<GoogleAppMap>();
                var records = csv.GetRecords<GoogleApp>().ToList();
                return records;
            }

        }

        static void GetData(IEnumerable<GoogleApp> googleApps)
        {
            var highRatedApp= googleApps.Where(e => e.Rating > 4.6);
            var highRatedAppBeauty = googleApps.Where(e => e.Rating > 4.6 && e.Category == Category.BEAUTY);
            var first = highRatedAppBeauty.FirstOrDefault(e => e.Reviews < 50);
            var single = highRatedAppBeauty.SingleOrDefault(e => e.Reviews < 300);
            Display(highRatedAppBeauty);
       
            Display(first);

            Display(single);
        }




    }
    //pobieranie danych
    //Where
    //First
    //Single
    //LAst

    //projekcja danych
    //Select
    //SelectMany

    //podział danych
    //Skip
    //Take
    //SkipWhile
    //TakeWhile

    //Sortowanie 
    //OrderBy
    //OrderByDescending
    //ThenBy
    //ThenByDescending

    //operacje na zbiorach
    //Distinct
    //Union
    //Intersect
    //Except

    //weryfikacja danych
    //All
    //Any

}
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

            //Display(googleApps);
            //GetData(googleApps);
            //projectData(googleApps);
            DivideData(googleApps);

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
            var highRatedApp = googleApps.Where(e => e.Rating > 4.6);
            var highRatedAppBeauty = googleApps.Where(e => e.Rating > 4.6 && e.Category == Category.BEAUTY);
            var first = highRatedAppBeauty.FirstOrDefault(e => e.Reviews < 50);
            var single = highRatedAppBeauty.SingleOrDefault(e => e.Reviews < 300);
            Display(highRatedAppBeauty);

            Display(first);

            Display(single);
        }

        public static void projectData(IEnumerable<GoogleApp> googleApps)
        {
            var highRatedAppBeauty = googleApps.Where(e => e.Rating > 4.6 && e.Category == Category.BEAUTY);
            Display(highRatedAppBeauty);
            var highRatedAppBeautyNames = highRatedAppBeauty.Select(e => e.Name);

            //Console.WriteLine(string.Join(",\n", highRatedAppBeautyNames));

            //var dtos = highRatedAppBeauty.Select(e => new GoogleAppDto()
            //{
            //    Name = e.Name,
            //    Reviews = e.Reviews
            //});

            //foreach(GoogleAppDto dto in dtos)
            //{
            //     Console.WriteLine($"{dto.Name} : {dto.Reviews}");
            //}

            //kolekcje listy
            var genresList = highRatedAppBeauty.Select(e => e.Genres);
            var genres = highRatedAppBeauty.SelectMany(e => e.Genres);
            Console.WriteLine(string.Join("\n", genres));

            //typy anonimowe
            var anonymousDtos = highRatedAppBeauty.Select(e => new
            {
                e.Name,
                e.Reviews,
                e.Category
            });
            foreach (var e in anonymousDtos)
            {
                Console.WriteLine($"{e.Name} : {e.Reviews} : {e.Category}");
            }
        }


        static void DivideData(IEnumerable<GoogleApp> googleApps)
        {
            var highRatedAppBeauty = googleApps.Where(e => e.Rating > 4.6 && e.Category == Category.BEAUTY);
            Display(highRatedAppBeauty);

            //var first5highRatedAppBeauty = new List<GoogleApp>();
            //foreach (var e in highRatedAppBeauty)
            //{
            //     first5highRatedAppBeauty.Add(e);
            //    if (first5highRatedAppBeauty.Count == 5) break;
            //}
            //var first5highRatedAppBeauty = highRatedAppBeauty.Take(5);
            //var first5highRatedAppBeauty = highRatedAppBeauty.TakeWhile(E => E.Reviews >=1000);


            var skipFirst5highRatedAppBeauty = highRatedAppBeauty.Skip(5);
            Display(skipFirst5highRatedAppBeauty);
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
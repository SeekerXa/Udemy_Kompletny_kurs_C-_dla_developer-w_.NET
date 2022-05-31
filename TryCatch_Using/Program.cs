using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TryCatch_Using
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var filePath = @"E:\Projects\Learning\C#\Udemy_Kompletny_kurs_C-_dla_developer-w_.NET\TryCatch_Using\file.txt";
            var fileContent = File.ReadAllText(filePath);

            //var readFileStream = new FileStream(filePath, FileMode.Open);
            //try
            //{

            //}
            //finally
            //{
            //    readFileStream.Close();
            //}

            //==== this same
            UnicodeEncoding uniencoding = new UnicodeEncoding();
            string text = "Something!";
            byte[] temp = uniencoding.GetBytes(text);

        

            using (var writeFileStream = new FileStream(filePath, FileMode.Open))
            {
               // writeFileStream.Write(temp, 0, temp.Length);
               writeFileStream.Write(temp, 0, temp.Length);
            }

            using (var readFileStream = new FileStream(filePath, FileMode.Open, FileAccess.ReadWrite))
            {
                byte[] b = new byte[1024];
                UnicodeEncoding tempRead = new UnicodeEncoding();
                while (readFileStream.Read(b, 0, b.Length) > 0)
                {
                    Console.WriteLine(tempRead.GetString(b));
                }
            }

        }
    }
}

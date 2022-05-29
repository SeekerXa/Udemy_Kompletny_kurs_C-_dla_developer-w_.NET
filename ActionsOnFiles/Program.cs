using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionsOnFiles
{
    internal class Program
    {
        const string _filePath = @"E:\Projects\Learning\C#\Udemy_Kompletny_kurs_C-_dla_developer-w_.NET\ActionsOnFiles\Files";

        static void ReadFiles()
        {
            var document1 = File.ReadAllText(_filePath + @"\SimpleTexts\document1.txt");
            var document2 = File.ReadAllLines(_filePath + @"\\SimpleTexts\document2.txt");

            Console.WriteLine("Doc1");
            Console.WriteLine(document1);

            var document2String = string.Join(Environment.NewLine, document2);
            Console.WriteLine("Doc2");
            Console.WriteLine(document2String);

        }

        public static void GenerateDocuments()
        {
            var name = "ktos";
            string orderNumber = "123456789";

            var template = File.ReadAllText(_filePath + @"\\Write\Template.txt");
            var replacedtemplate = template.Replace("{name}", name)
                .Replace("{orderNumber}", orderNumber)
                .Replace("{dataTime}", DateTime.Now.ToString());

            File.WriteAllText(_filePath + $@"\Write\document_{name}_{orderNumber}.txt", replacedtemplate);
        }

        static void ScandAppend()
        {
           var files =  Directory.GetFiles(_filePath + @"\Append\", "*.txt",SearchOption.AllDirectories);
            foreach (var file in files)
            {
                File.AppendAllText(file, "\nAll rights reserverd");
            }
        }


        static void Main(string[] args)
        {
            ReadFiles();
            GenerateDocuments();
            ScandAppend();
           
        }
    }
}

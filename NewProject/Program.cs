using System;
using System.Text;


class Program
{

    static void Main(String[] args)
    {
        Console.WriteLine("Hello, World!");


        string someText = "some text";
        char jchar = 'j';
        char jCharUnicode = '\u006A';

        bool isUserReady = false;

        DateTime now = DateTime.Now;
        DateTime dayOfBirth = new DateTime(1990, 06, 02);

        float floatNumber = 1.5f;
        decimal decimalNumber = 1.5M;
        double doubleNumber = 1.5;

        string text = "he said \"hi\"";

        string fontsFolder = @"c:\windows\fonsts";

        string concatenated = string.Concat(text, fontsFolder, "me");
        string concatenated2 = text + "too";
        string interpolated = $"{text}";

        StringBuilder sb = new StringBuilder("this is first:");
        sb.Append("is");
        sb.Append("a");
        sb.Append("long");
        sb.Append("text");
        Console.WriteLine(sb);

        String result = sb.ToString();
        Console.WriteLine(result);
    }

}


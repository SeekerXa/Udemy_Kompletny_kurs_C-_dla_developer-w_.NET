using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataReverse
{
    internal class Kata
    {


        public static List<string> Split(string input, char separator)
        {
            var result = new List<string>();
            var currentIndex = 0;

            for (var i = 0; i < input.Length; i++)
            {
                if (input[i] == separator)
                {
                    var word = input.Substring(currentIndex, i - currentIndex);
                    result.Add(word);
                    currentIndex = i + 1;
                }
                else if (i == input.Length - 1)
                {
                    var word = input.Substring(currentIndex, input.Length - currentIndex);
                    result.Add(word);
                }
            }

            return result;
        }

        public static List<string> Reverse(List<string> list)
        {
            var resultList = new List<string>();

            for (var i = list.Count - 1; i >= 0; i--)
            {
                resultList.Add(list[i]);
            }

            return resultList;
        }

        public static string Join(List<string> list,char separator)
        {
            var sb = new StringBuilder();
            for(var i = 0; i < list.Count; i++)
            {
                sb.Append(list[i]);
                if(i != list.Count-1)
                {
                    sb.Append(separator);
                }
            }

            return sb.ToString();
        }


        public static string ReverseWords(string str)
        {
           // var split = str.Split(' ');
           // var reverse = split.Reverse();
           // var result = string.Join(' ', reverse);


           //// return result;
            return string.Join(" ", str.Split(' ').Reverse());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StringTask
{
    class Program
    {


        static void Main(string[] args)
        {

            string kebabCase = "some-variable-name";
            string camelCase = "someVariableValue";



            Console.WriteLine(KebabToCamel(kebabCase));
            Console.WriteLine(CamelToKebab(camelCase));

        }


        public static string KebabToCamel(string value)
        {
            var stringTab = value.Split('-');
            for (int i = 1; i < stringTab.Length; i++)
            {
                string temp = stringTab[i][0].ToString();
                stringTab[i] = stringTab[i].Remove(0, 1);
                stringTab[i] = stringTab[i].Insert(0, temp.ToUpper());
            }
            return String.Join(null, stringTab);
        }

        public static string CamelToKebab(string value)
        {
            //for (int i = 0; i < value.Length; i++)
            //{
            //    if (char.IsUpper(value[i]))
            //    {
            //        var temp = char.ToLower(value[i]).ToString();
            //        value = value.Remove(i, 1).
            //            Insert(i, temp).
            //            Insert(i, "-");
            //    }
            //}

            //exammple with sb.

            StringBuilder sb = new StringBuilder();
            foreach (char c in value)
            {
                if (char.IsUpper(c))
                {
                    sb.Append("-");
                    sb.Append(char.ToLower(c));
                }
                else sb.Append(c);
            }
             value = sb.ToString();







            return value;
        }








    }

}
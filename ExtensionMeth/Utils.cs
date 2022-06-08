using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMeth
{
    public static class Utils
    {

        public static bool IsDateBetwen(DateTime date, DateTime from, DateTime to)
        {
            return date > from && date < to;

        }
        public static bool IsBetwen(this DateTime date, DateTime from, DateTime to)
        {
            return date > from && date < to;

        }

        public static int Squared(this int value)
        {
            return value * value;
        }
    }
}

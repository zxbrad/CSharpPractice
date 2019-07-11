using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountLibrary.AccountExtension
{
    public static class DateTimeExtension
    {
        public static bool SameMonthOfSameYear(this DateTime dateTime, DateTime DateTime2)
        {
            return dateTime.Year == DateTime2.Year && dateTime.Month == DateTime2.Month;
        }
    }
}

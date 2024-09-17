using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercise14
{
    internal class Date
    {
        public static string WeekdayInDutch(int year, int month, int day)
        {
            DateTime date = new DateTime(year, month, day);

            CultureInfo dutchCultureInfo = new CultureInfo("nl-NL");

            DateTimeFormatInfo formatInfo = dutchCultureInfo.DateTimeFormat;

            string dayName = formatInfo.DayNames[(int)date.DayOfWeek];

            return dayName;
        }
    }
}


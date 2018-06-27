using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MitarbeiterVerwaltung
{
    static class DateTimeExtensions
    {
        public static bool IsWorkingDay(this DateTime date)
        {
            return date.DayOfWeek != DayOfWeek.Saturday
                && date.DayOfWeek != DayOfWeek.Sunday;

        }
    }
}

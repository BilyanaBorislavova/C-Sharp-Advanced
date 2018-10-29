using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace DateModifier
{
    public class DateModifier
    {
        private string firstDate;
        private string secondDate;

        public DateModifier(string firstDate, string secondDate)
        {
            this.firstDate = firstDate;
            this.secondDate = secondDate;
        }

        public long FindDifferenceBetweenDates()
        {
            DateTime dateTime1 = DateTime.ParseExact(this.firstDate, "yyyy MM dd", CultureInfo.InvariantCulture);
            DateTime dateTime2 = DateTime.ParseExact(this.secondDate, "yyyy MM dd", CultureInfo.InvariantCulture);
            var diff = (dateTime1 - dateTime2).TotalDays;
            return Math.Abs((long)diff);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesPractice2
{
    internal class DateAndTimes
    {

        public void PrintMyDates()
        {
            //   Write a program to display the:
            //a) Current date and time
            //b) Current year
            //c) Month of year
            //d) Week number of the year // todo: 
            //e) Weekday of the week //todo
            //f) Day of year
            //g) Day of the month
            //h) Day of week
            //j) if the current year is a leap year or not


            DateTime myDate = DateTime.Now;
            //Console.WriteLine($"Current date is: {myDate}");
            //Console.WriteLine($"Current year is: {myDate.Year}");
            Console.WriteLine($"Curent month is: {myDate.Month}");

            CultureInfo cultureInfo = new CultureInfo("ro-Ro");
            Calendar calendar = cultureInfo.Calendar;

            CalendarWeekRule rule = cultureInfo.DateTimeFormat.CalendarWeekRule;
            DayOfWeek dayOfWeek = cultureInfo.DateTimeFormat.FirstDayOfWeek;

            Console.WriteLine($"Week number of the year: {calendar.GetWeekOfYear(myDate, rule, dayOfWeek)}");


            //Console.WriteLine($"Day of week: {myDate.DayOfWeek}");
            //Console.WriteLine($"Day of year: {myDate.DayOfYear}");
            //Console.WriteLine($"Day of the month: {myDate.Day}");
            //Console.WriteLine($"Weekday of the week: {myDate.Day}");

            Console.WriteLine($"Is leap year: {DateTime.IsLeapYear(myDate.Year)}");
            int nextYear = myDate.AddYears(1).Year;
            int nextYear1 = myDate.Year + 1;
            Console.WriteLine($"Is next year leap year: {DateTime.IsLeapYear(nextYear)}");
            Console.WriteLine(nextYear1);

            Console.WriteLine("Let's see in the past" + myDate.AddDays(-10).ToShortDateString());
        }
    }
}

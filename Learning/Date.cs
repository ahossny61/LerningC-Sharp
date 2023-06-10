using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    public class Date
    {
        private static readonly int[] DayesInMonths365 =
        {31,28,31,30,31,30,31,31,30,31,30,31 };
        private static readonly int[] DayesInMonths366 =
       {31,29,31,30,31,30,31,31,30,31,30,31 };
        public int Day { get;private set; }
        public int Month { get;private set; }
        public int Year { get;private set; }

        public Date(int day, int month, int year)
        {
            
            bool isValid = false;
            if(year > 0 && year <= 9999 && month > 0 && month <= 12 && day > 0 && day <= 31)
            {
                var isLeap = year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
                var maxDay = isLeap ? DayesInMonths366[month - 1] : DayesInMonths365[month - 1];
                if (day <= maxDay)
                {
                    Day = day;
                    Month = month;
                    Year = year;
                    isValid = true;
                }

            }

            if (!isValid)
            {
                Day = 1;
                Month = 1;
                Year = 1;
            }

           
        }
        public Date() { }   

        public string GetDate()
        {
            return $"{ this.Day.ToString().PadLeft(2, '0')}/{ Month.ToString().PadLeft(2, '0')}/{ Year.ToString().PadLeft(4, '0')}";
        }
    }
}

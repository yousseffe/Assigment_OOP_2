using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment_OOP_2
{
    internal class HiringDate
    {
        #region Attributes
        private int day;
        private int month;
        private int year;
        #endregion

        #region Properties
        public int Day
        {
            get { return day; }
            set
            {
                if (value < 1 || value > DateTime.DaysInMonth(year, month))
                    throw new ArgumentException("Invalid day for the given month and year.");
                day = value;
            }
        }

        public int Month
        {
            get { return month; }
            set
            {
                if (value < 1 || value > 12)
                    throw new ArgumentException("Month must be between 1 and 12.");
                month = value;
                if (day > DateTime.DaysInMonth(year, month))
                    throw new ArgumentException("Invalid day for the given month and year.");
            }
        }

        public int Year
        {
            get { return year; }
            set
            {
                if (value < 1 || value > DateTime.Now.Year)
                    throw new ArgumentException("Year must be a positive integer and not in the future.");
                year = value;
                if (day > DateTime.DaysInMonth(year, month))
                    throw new ArgumentException("Invalid day for the given month and year.");
            }
        }
        #endregion

        #region Constructors
        public HiringDate(int day, int month, int year)
        {
            Year = year;
            Month = month;
            Day = day;
        }

        public HiringDate() : this(DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year) { }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"{Day:D2}/{Month:D2}/{Year}";
        }
        #endregion
    }
}

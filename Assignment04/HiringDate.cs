using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04
{
    internal class HiringDate
    {
        #region Properties
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        #endregion

        #region Constructor
        public HiringDate(int day, int month, int year)
        {
            // Validate the date before assign
            if (!IsValidDate(day, month, year))
            {
                throw new ArgumentException("Invalid date provided.");
            }

            Day = day;
            Month = month;
            Year = year;
        }
        #endregion

        #region Methods
        // Method to validate the date
        private bool IsValidDate(int day, int month, int year)
        {
            // Check if month is between 1 and 12
            if (month < 1 || month > 12)
            {
                return false;
            }

            // Check if day is valid for the given month and year
            try
            {
                DateTime date = new DateTime(year, month, day);
                return true;
            }
            catch
            {
                return false;
            }
        }

        // Override ToString() to display the date in a readable format
        public override string ToString()
        {
            return string.Format("{0:D2}/{1:D2}/{2}", Day, Month, Year);
        } 
        #endregion
    }
}


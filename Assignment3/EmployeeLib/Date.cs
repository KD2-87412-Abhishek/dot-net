using System;

namespace EmployeeLib
{
    public class Date
    {
        private int day;
        private int month;
        private int year;

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public int Month
        {
            get { return month; }
            set { month = value; }
        }

        public int Day
        {
            get { return day; }
            set { day = value; }
        }


        public Date()
        {

        }
        public Date(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        public void AcceptDate()
        {
            Console.WriteLine("Enter the day");
            day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the month");
            month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the year");
            year = Convert.ToInt32(Console.ReadLine());
        }
        public void PrintDate()
        {
            Console.WriteLine("The day : " + day);
            Console.WriteLine("The month : " + month);
            Console.WriteLine("The year : " + year);

        }

        public bool IsValid(Date date)
        {
            if (date == null)
            {
                return false;
            }

            if (date.Year < 1980 && date.Year > 2005)
            {
                Console.WriteLine("Year should be between 1980 and 2005");
                return false;
            }
            else if (date.month > 12 && date.month < 0)
            {
                Console.WriteLine("Month should be between 1 to 12");
                return false;
            }
            else if (date.day < 0 && date.day > 31)
            {
                Console.WriteLine("Month should be between 1 to 31");
                return false;
            }
            else
            {
                return true;
            }

        }

        public string ToString()
        {
            string message = "Date : {0}/{1}/{2}";
                return string.Format(message, day, month, year);
        }


        public static Date operator -(Date date1, Date date2)
        {
            return new Date(date1.day - date2.day,
                date1.month - date2.month,
                    date1.year - date2.year);
        }


    }
}
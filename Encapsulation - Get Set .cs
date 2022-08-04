using System;
namespace ConsoleApp1
{
    class Date
    {
        private int day, month, year;
        public Date()
        {
            day = 31;
            month = 10;
            year = 2001;
        }
        public int MM   //get set method
        {
            get { return month; }
            set
            {
                if (value >= 1 && value <= 12)
                    month = value;
            }
        }
        public int DD   //get set method
        {
            get { return day; }
            set
            {
                if (value >= 1 && value <= 30)
                    day = value;
                else
                    Console.WriteLine("\tNote: Incorrect value try again.");
            }
        }
        public int YY   //get set method
        {
            get { return year; }
            set
            {
                year = value;
            }
        }
        public void DisplayDate()
        {
            Console.WriteLine("\n===>New Assigned Date: ");
            Console.WriteLine("Day/Month/Year");
            Console.WriteLine("{0}/{1}/{2}", day, month, year);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Date dat = new Date();
            Console.WriteLine("Intial Date: ");
            dat.DisplayDate();
            Console.WriteLine("\n===>Enter New Date");
            Console.Write("Day: ");
            dat.DD = Convert.ToInt32(Console.ReadLine());
            Console.Write("Month: ");
            dat.MM = Convert.ToInt32(Console.ReadLine());
            Console.Write("Year: ");
            dat.YY = Convert.ToInt32(Console.ReadLine());
            dat.DisplayDate();
        }
    }
}

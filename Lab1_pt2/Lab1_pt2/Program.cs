using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_pt2
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date1 = new DateTime(2019, 7, 10);
            DateTime date2 = new DateTime(2018, 7, 30);

            //Call the function to calaculate the difference
            calculateDifference(date1, date2);
        }

        //Method to calculate and print date difference. This function return nothing. i.e void


        static void calculateDifference(DateTime dateTime2, DateTime dateTime1)
        {
            //Get the difference between the two dates
            TimeSpan timespan = dateTime2.Subtract(dateTime1);

            //Get the absolute value in difference in terms of days
            Console.WriteLine("There are {0} number of days between {1} and {2}", timespan.TotalDays, dateTime1.ToShortDateString(), dateTime2.ToShortDateString());

            //Get the absolute value in difference in terms of hours
            Console.WriteLine("There are {0} number of hours between {1} and {2}", timespan.TotalHours, dateTime1.ToShortDateString(), dateTime2.ToShortDateString());

            //Get the absolute value in difference in terms of minutes
            Console.WriteLine("There are {0} number of minutes between {1} and {2}", timespan.TotalMinutes, dateTime1.ToShortDateString(), dateTime2.ToShortDateString());

        }
    }
}

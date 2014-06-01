using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student180
{
    class Schedule
    {

        public static void Scheduler(DateTime startDate, string startTime, int numOfWeeks = 15, int duration = 120)
        {



            DateTime startDateTime = DateTime.Parse(startTime);
            DateTime endDateTime = startDateTime.AddMinutes(duration);
            int numOfDays = numOfWeeks * 7;

            if (startDate.DayOfWeek.ToString() == "Sunday")
            {
                Console.WriteLine("You cannot have classes on this day!");

            }

            for (int i = 0; i <= numOfDays; i += 7)
            {
                Console.Write(startDate.DayOfWeek.ToString().ToUpper() + ":  ");
                Console.WriteLine(startDate.AddDays(i).ToString("dd/MM/yyyy") + "\n" + "\t" + " From " + startTime.ToString() +
                     " to " + endDateTime.TimeOfDay.ToString());
                Console.WriteLine();

            }
        }   
    
    }
}

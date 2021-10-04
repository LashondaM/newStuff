using System;

namespace newStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetDay(6));

            Console.ReadLine();
        }
        
        static string GetDay(int dayNum)
        {
            string dayName;

            switch (dayNum) // pass a value and check to see if it's equal to a whole bunch of stuff
            {
                case 0: // in the case dayNum is equal to 0, I want to do this down here, etc
                    dayName = "Sunday";
                    break; // put break to have c# stop checking for another case, if you want it to keep checking, don't use break;
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;
                default: // use this to specify what to do if none of these cases are true
                    dayName = "Invalid Day Number";
                    break;

            // Can also use an if statement to do these as well

            }

            return dayName;
        }
    }
}
 
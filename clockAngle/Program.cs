using System;

namespace ClockAngle
{
    class Program
       
    {
        private static int hours, minutes;
        static void Main(string[] args)
        {
            ReceiveHoursAndMinutesFromUser();
            ClockAngleCalculator clockAngleCalculator = new ClockAngleCalculator(hours, minutes);
            double angle = clockAngleCalculator.CalculateSmallestAngleConnectingShortAndLongClockHands();
            PrintClockAngle(angle);
        }

        static void ReceiveHoursAndMinutesFromUser()
        {
            Console.WriteLine("Enter the hours:");
            hours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the minutes:");
            minutes = Convert.ToInt32(Console.ReadLine());
        }

        static void PrintClockAngle(double angle)
        {
            Console.WriteLine("The angle between the long hand and short hand is: " + angle);
        }


    }
}

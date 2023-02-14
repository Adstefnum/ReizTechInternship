using System;

namespace ClockAngleCalculatorNS
{
    public class ClockAngleCalculator
    {
     
        public ClockAngleCalculator()
        {
           

        }

       public double CalculateSmallestAngleConnectingShortAndLongClockHands(int hours, int minutes)
        {
            double hourAngle = 0.5 * (60 * hours + minutes);
            double minuteAngle = 6 * minutes;
            double angle = Math.Abs(hourAngle - minuteAngle);
            return Math.Min(360 - angle, angle);
           
        }
    }
}

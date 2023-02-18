using System;

namespace ClockAngleCalculatorNS
{
    public class ClockAngleCalculator
    {
    //O(1) space and time
       public double CalculateSmallestAngleConnectingClockHands(int hours, int minutes)
        {
            double hourAngle = 0.5 * (60 * hours + minutes);
            double minuteAngle = 6 * minutes;
            double angle = Math.Abs(hourAngle - minuteAngle);
            return Math.Min(360 - angle, angle);
           
        }
    }
}

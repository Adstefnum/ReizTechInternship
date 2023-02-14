using System;

namespace ClockAngle
{
    public class ClockAngleCalculator
    {
        private int hours, minutes;
        public ClockAngleCalculator(int _hours,int _minutes)
        {
            hours = _hours;
            minutes = _minutes;

        }

       public double CalculateSmallerClockAngle()
        {
            double hourAngle = 0.5 * (60 * hours + minutes);
            double minuteAngle = 6 * minutes;
            double angle = Math.Abs(hourAngle - minuteAngle);
            angle = Math.Min(360 - angle, angle);
            return angle;
        }
    }
}

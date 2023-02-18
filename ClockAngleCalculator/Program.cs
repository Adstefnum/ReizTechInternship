

namespace ClockAngleCalculatorNS
{
    public class Program
       
    {
        static void Main(string[] args)
        {
            InputReader inputReader = new InputReader();
            int hours = inputReader.ReadClockHandsInputFromUser("Enter the hours (1-12): ",1,12);
            int minutes = inputReader.ReadClockHandsInputFromUser("Enter the minutes (0-59): ",0,59);

            ClockAngleCalculator clockAngleCalculator = new ClockAngleCalculator();
            double angle = clockAngleCalculator.CalculateSmallestAngleConnectingClockHands(hours, minutes);
            PrintClockAngle(angle);
        }

        public static void PrintClockAngle(double angle)
        {
            Console.WriteLine("The angle between the long hand and short hand is: " + angle);
        }


    }
}

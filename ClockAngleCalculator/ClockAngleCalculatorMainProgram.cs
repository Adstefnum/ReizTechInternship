

namespace ClockAngleCalculatorNS
{
    public class ClockAngleCalculatorMainProgram
       
    {
        private int hours, minutes;
        static void Main(string[] args)
        {
            ClockAngleCalculatorMainProgram clockAngleCalculatorMainProgram = new ClockAngleCalculatorMainProgram();
            clockAngleCalculatorMainProgram.hours = clockAngleCalculatorMainProgram.ReadClockHandsInputFromUser("Enter the hours (1-12): ",1,12);
            clockAngleCalculatorMainProgram.minutes = clockAngleCalculatorMainProgram.ReadClockHandsInputFromUser("Enter the minutes (0-59): ",0,59);

            ClockAngleCalculator clockAngleCalculator = new ClockAngleCalculator();
            double angle = clockAngleCalculator.CalculateSmallestAngleConnectingShortAndLongClockHands(clockAngleCalculatorMainProgram.hours, clockAngleCalculatorMainProgram.minutes);
            PrintClockAngle(angle);
        }

        public int ReadClockHandsInputFromUser(string prompt, int minValue, int maxValue)
        {
                int value;

                do
                {
                    Console.WriteLine(prompt);
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out value))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid integer.");
                        continue;
                    }

                    if (value < minValue || value > maxValue)
                    {
                        Console.WriteLine($"Input must be between {minValue} and {maxValue}.");
                        continue;
                    }

                    break;

                } while (true);

                return value;
            }


        public static void PrintClockAngle(double angle)
        {
            Console.WriteLine("The angle between the long hand and short hand is: " + angle);
        }


    }
}

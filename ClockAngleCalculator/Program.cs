

namespace ClockAngleCalculatorNS
{
    public class Program
       
    {
        private int hours, minutes;
        static void Main(string[] args)
        {
            Program program = new Program();
            program.hours = program.ReadClockHandsInputFromUser("Enter the hours (1-12): ",1,12);
            program.minutes = program.ReadClockHandsInputFromUser("Enter the minutes (0-59): ",0,59);

            ClockAngleCalculator clockAngleCalculator = new ClockAngleCalculator();
            double angle = clockAngleCalculator.CalculateSmallestAngleConnectingShortAndLongClockHands(program.hours, program.minutes);
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

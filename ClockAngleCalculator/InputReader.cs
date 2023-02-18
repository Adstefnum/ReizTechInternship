

namespace ClockAngleCalculatorNS
{
    public class InputReader
    {
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


       
    }
}

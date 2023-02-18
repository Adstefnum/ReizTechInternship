using ClockAngleCalculatorNS;

namespace ClockAngleCalculatorTestsNS
{
    [TestClass]
    public class ClockAngleCalculatorTests
    {

        private ClockAngleCalculator clockAngleCalculator;

        [TestInitialize]
        public void Setup()
        {
            clockAngleCalculator = new ClockAngleCalculator();
        }


        [DataRow(10, 30, 135)]
        [DataRow(1, 1, 24.5)]
        [DataRow(2, 30, 105)]
        [DataRow(5, 45, 97.5)]
        [DataRow(6, 0, 180)]
        [DataRow(9, 15, 172.5)]
        [DataRow(10, 10, 115)]
        [DataRow(11, 55, 27.5)]
        [DataRow(12, 0, 0)]
        [DataRow(3, 20, 20)]
        [DataRow(7, 50, 65)]
        [TestMethod]
        public void ShouldTakeInValueAndReturnValue(int hours, int minutes, double expectedAngle)
        {
            double angle = clockAngleCalculator.CalculateSmallestAngleConnectingClockHands(hours, minutes);

            Assert.AreEqual(expectedAngle, angle);
        }


        [DataRow(10, 30, 225)]
        [DataRow(1, 1, 335.5)]
        [DataRow(2, 30, 255)]
        [DataRow(5, 45, 262.5)]
        [DataRow(9, 15, 187.5)]
        [DataRow(10, 10, 245)]
        [DataRow(11, 55, 332.5)]
        [DataRow(3, 20, 340)]
        [DataRow(7, 50, 295)]
        [TestMethod]
        public void ShouldFindSmallestAngleNotBiggest(int hours, int minutes, double expectedBiggestAngle)
        {

            double angle = clockAngleCalculator.CalculateSmallestAngleConnectingClockHands(hours, minutes);


            Assert.AreNotEqual(expectedBiggestAngle, angle);
        }

        [DataRow(12, 0, 0)]
        [DataRow(6, 0, 180)]
        [TestMethod]
        public void ShouldReturnTheSameAngleForBiggestAndSmallestForTwelveAndSixOClock(int hours, int minutes, double biggestAngle) {

            double angle = clockAngleCalculator.CalculateSmallestAngleConnectingClockHands(hours, minutes);
            Assert.AreEqual(biggestAngle, angle);
        }

        [TestMethod]
        public void ShouldReturnDoubleValue()
        {
            int hours = 12;
            int minutes = 12;

            double angle = clockAngleCalculator.CalculateSmallestAngleConnectingClockHands(hours, minutes);

            Assert.IsInstanceOfType(angle, typeof(double));
        }
    }
}
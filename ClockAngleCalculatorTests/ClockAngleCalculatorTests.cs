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
            double angle = clockAngleCalculator.CalculateSmallestAngleConnectingShortAndLongClockHands(hours, minutes);

            Assert.AreEqual(expectedAngle, angle);
        }

        public void NumberOfHoursShouldBeLessThanTwelve() { }

        public void NumberOfMinutesShouldBeLessThanSixty() { }

        public void ShouldFindSmallerOfTwoAngles() { }

        public void ShouldTakeInIntegerValue() { }

        public void ShouldReturnDoubleValue() { }
    }
}
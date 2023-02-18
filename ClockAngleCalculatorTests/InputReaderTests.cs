//using ClockAngleCalculatorNS;

//namespace ClockAngleCalculatorTestsNS
//{
//    [TestClass]
//    public class InputReaderTests
//    {
//        int expectedMinutesMaxValue = 59;
//        int expectedMinutesMinValue = 0;
//        int expectedHoursMinValue = 1;
//        int expectedHoursMaxValue = 12;
//        private InputReader inputReader;

//        [TestInitialize]
//        public void Setup()
//        {
//            inputReader = new InputReader();
            
//        }



//        [TestMethod]
//        public void NumberOfHoursReceivedShouldBeBetweenOneAndTwelve()
//        {
//            int actualValue = inputReader.ReadClockHandsInputFromUser("Enter the hours (1-12): ", expectedHoursMinValue, expectedHoursMaxValue);
//            Console.WriteLine(actualValue);
//            Console.WriteLine(expectedHoursMaxValue);

//            Assert.IsTrue(actualValue >= expectedHoursMinValue && actualValue <= expectedHoursMaxValue);
//        }

//        [TestMethod]
//        public void NumberOfMinutesReceivedShouldBeBetweenZeroAndFiftyNine()
//        {
//            int actualValue = inputReader.ReadClockHandsInputFromUser("Enter the minutes (0-59): ", expectedMinutesMinValue, expectedMinutesMaxValue);

//            Assert.IsTrue(actualValue >= expectedMinutesMinValue && actualValue <= expectedMinutesMaxValue);
//        }

//        [TestMethod]
//        public void ShouldTakeInOnlyIntegerValueForHoursValue()
//        {
//            var actualValue = inputReader.ReadClockHandsInputFromUser("Enter the hours (1-12): ", expectedHoursMinValue, expectedHoursMaxValue);

//            Assert.IsInstanceOfType(actualValue, typeof(int));
//        }

//        [TestMethod]
//        public void ShouldTakeInOnlyIntegerValueForMinutesValue()
//        {
//            var actualValue = inputReader.ReadClockHandsInputFromUser("Enter the minutes (0-59): ", expectedMinutesMinValue, expectedMinutesMaxValue);

//            Assert.IsInstanceOfType(actualValue, typeof(int));
//        }


//    }

//}


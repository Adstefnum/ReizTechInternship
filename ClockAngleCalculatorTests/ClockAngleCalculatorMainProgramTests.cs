using ClockAngleCalculatorNS;

namespace ClockAngleCalculatorTestsNS
{
    [TestClass]
    public class ClockAngleCalculatorMainProgramTests { 
        int expectedMinutesMinValue;
        int expectedMinutesMaxValue;
        int expectedHoursMinValue;
        int expectedHoursMaxValue;
        private Program clockAngleCalculatorMainProgram;

        [TestInitialize]
        public void Setup()
        {
            clockAngleCalculatorMainProgram= new Program();
            expectedMinutesMinValue = 0;
            expectedMinutesMaxValue = 59;
            expectedHoursMinValue = 1;
            expectedHoursMaxValue = 12;
        }

        

            [TestMethod]
            public void NumberOfHoursReceivedShouldBeBetweenOneAndTwelve()
            {
                int actualValue = clockAngleCalculatorMainProgram.ReadClockHandsInputFromUser("Enter the hours (1-12): ", expectedHoursMinValue, expectedHoursMaxValue);

                Assert.IsTrue(actualValue >= expectedHoursMinValue && actualValue <= expectedHoursMaxValue);
            }

            [TestMethod]
            public void NumberOfMinutesReceivedShouldBeBetweenZeroAndFiftyNine()
            {
                int actualValue = clockAngleCalculatorMainProgram.ReadClockHandsInputFromUser("Enter the minutes (0-59): ", expectedMinutesMinValue, expectedMinutesMaxValue);

                Assert.IsTrue(actualValue >= expectedMinutesMinValue && actualValue <= expectedMinutesMaxValue);
            }

            [TestMethod]
            public void ShouldTakeInOnlyIntegerValueForHoursValue()
            {
                var actualValue = clockAngleCalculatorMainProgram.ReadClockHandsInputFromUser("Enter the hours (1-12): ", expectedHoursMinValue, expectedHoursMaxValue);
                
                Assert.IsInstanceOfType(actualValue, typeof(int));
            }

            [TestMethod]
            public void ShouldTakeInOnlyIntegerValueForMinutesValue()
            {
                var actualValue = clockAngleCalculatorMainProgram.ReadClockHandsInputFromUser("Enter the minutes (0-59): ", expectedMinutesMinValue, expectedMinutesMaxValue);
     
                Assert.IsInstanceOfType(actualValue, typeof(int));
            }

         
        }

    }

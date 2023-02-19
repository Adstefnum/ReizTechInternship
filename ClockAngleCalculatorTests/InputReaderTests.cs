//using ClockAngleCalculatorNS;

//namespace ClockAngleCalculatorTestsNS
//{
//    [TestClass]
//    public class InputReaderTests
//    {
//        private InputReader inputReader;
//        private int expectedMinutesMaxValue;
//        private int expectedMinutesMinValue;
//        private int expectedHoursMinValue;
//        private int expectedHoursMaxValue;

//        [TestInitialize]
//        public void Setup()
//        {
//            inputReader = new InputReader();
//            expectedMinutesMaxValue = 59;
//            expectedMinutesMinValue = 0;
//            expectedHoursMinValue = 1;
//            expectedHoursMaxValue = 12;
//        }


//[TestMethod]
//public void ReadClockHandsInputFromUser_ValidInput_ReturnsValue()
//{
   
//    string prompt = "Enter a value between 0 and 59";
//    int expectedValue = 30;
//    string input = expectedValue.ToString();
//    var inputStream = new StringReader(input);
//    Console.SetIn(inputStream);

   
//    int actualValue = inputReader.ReadClockHandsInputFromUser(prompt, expectedMinutesMinValue, expectedMinutesMaxValue);

   
//    Assert.AreEqual(expectedValue, actualValue);
//}

//[TestMethod]
//public void ReadClockHandsInputFromUser_InvalidInput_ReturnsValue()
//{
   
//    string prompt = "Enter a value between 0 and 59";
//    int expectedValue = 30;
//    string input = "invalid input\n" + expectedValue.ToString();
//    var inputStream = new StringReader(input);
//    Console.SetIn(inputStream);

   
//    int actualValue = inputReader.ReadClockHandsInputFromUser(prompt, expectedMinutesMinValue, expectedMinutesMaxValue);

   
//    Assert.AreEqual(expectedValue, actualValue);
//}

//[TestMethod]
//public void ReadClockHandsInputFromUser_OutOfRangeInput_ReturnsValue()
//{
   
//    string prompt = $"Enter a value between {expectedHoursMinValue} and {expectedHoursMaxValue}";
//    int expectedValue = 5;
//    string input = "0\n" + expectedValue.ToString();
//    var inputStream = new StringReader(input);
//    Console.SetIn(inputStream);

   
//    int actualValue = inputReader.ReadClockHandsInputFromUser(prompt, expectedHoursMinValue, expectedHoursMaxValue);

   
//    Assert.AreEqual(expectedValue, actualValue);
//}


//    //[TestMethod]
//    //public void NumberOfHoursReceivedShouldBeBetweenOneAndTwelve()
//    //{
//    //    int actualValue = inputReader.ReadClockHandsInputFromUser("Enter the hours (1-12): ", expectedHoursMinValue, expectedHoursMaxValue);
//    //    Console.WriteLine(actualValue);
//    //    Console.WriteLine(expectedHoursMaxValue);

//    //    Assert.IsTrue(actualValue >= expectedHoursMinValue && actualValue <= expectedHoursMaxValue);
//    //}

//    //[TestMethod]
//    //public void NumberOfMinutesReceivedShouldBeBetweenZeroAndFiftyNine()
//    //{
//    //    int actualValue = inputReader.ReadClockHandsInputFromUser("Enter the minutes (0-59): ", expectedMinutesMinValue, expectedMinutesMaxValue);

//    //    Assert.IsTrue(actualValue >= expectedMinutesMinValue && actualValue <= expectedMinutesMaxValue);
//    //}

//    //[TestMethod]
//    //public void ShouldTakeInOnlyIntegerValueForHoursValue()
//    //{
//    //    var actualValue = inputReader.ReadClockHandsInputFromUser("Enter the hours (1-12): ", expectedHoursMinValue, expectedHoursMaxValue);

//    //    Assert.IsInstanceOfType(actualValue, typeof(int));
//    //}

//    //[TestMethod]
//    //public void ShouldTakeInOnlyIntegerValueForMinutesValue()
//    //{
//    //        int expectedValue = 5;
//    //        string input = "0\n" + expectedValue.ToString();
//    //        var inputStream = new StringReader(input);
//    //        Console.SetIn(inputStream);
//    //        var actualValue = inputReader.ReadClockHandsInputFromUser("Enter the minutes (0-59): ", expectedMinutesMinValue, expectedMinutesMaxValue);

//    //    Assert.IsInstanceOfType(actualValue, typeof(int));
//    //}


//}

//}


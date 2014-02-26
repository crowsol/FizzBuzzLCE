namespace FizzBuzz.Tests
{
    using FizzBuzz.Library;
    using NUnit.Framework;
    
    [TestFixture]
    public class NumberCheckerTest
    {
        NumberChecker numberChecker;

        [SetUp]
        public void Init()
        {
            numberChecker = new NumberChecker();
        }

        [Test]
        public void Output()
        {
            var output = numberChecker.Output();

            Assert.AreEqual("Fizz", output[2].ToString());
            Assert.AreEqual("Buzz", output[4].ToString());
            Assert.AreEqual("FizzBuzz", output[14].ToString());
        }

        [Test]
        public void OutputWithRange()
        {
            var output = numberChecker.Output(1,15);

            Assert.AreEqual("Fizz", output[2].ToString());
            Assert.AreEqual("Buzz", output[4].ToString());
            Assert.AreEqual("FizzBuzz", output[14].ToString());
        }

        [Test]
        public void OutputWithCustomTokens()
        {
            var output = numberChecker.Output("Pork","Chops","Applesauce");

            Assert.AreEqual("Pork", output[2].ToString());
            Assert.AreEqual("Chops", output[4].ToString());
            Assert.AreEqual("Applesauce", output[14].ToString());
        }

        [Test]
        public void OutputWithRangeAndTokens()
        {
            var output = numberChecker.Output(1, 15, "Pork", "Chops", "Applesauce");

            Assert.AreEqual("Pork", output[2].ToString());
            Assert.AreEqual("Chops", output[4].ToString());
            Assert.AreEqual("Applesauce", output[14].ToString());
        }

        [Test]
        [ExpectedException(typeof(InvalidParameterException))]
        public void OutputWithInvalidRange()
        {
            var output = numberChecker.Output(19, 15);
        }

        [Test]
        [ExpectedException(typeof(InvalidParameterException))]
        public void OutputWithNullToken()
        {
            var output = numberChecker.Output("Pork", null, "Applesauce");
        }
    }
}

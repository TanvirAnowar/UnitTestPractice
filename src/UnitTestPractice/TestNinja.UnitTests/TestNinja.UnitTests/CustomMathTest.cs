using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestNinja.UnitTests
{
    [TestClass]
    public class CustomMathTest
    {
        private CustomMath _customMath;

        [TestInitialize]
        public void SetUp()
        {
            _customMath = new CustomMath();

        }

        [TestMethod]
        [DataRow(1, 2, 2)]
        [DataRow(2, 1, 2)]
        [DataRow(2, 2, 2)]
        public void CanBeDetermineMaxNumber_GivenInputs_returnsValidResults(int first, int second, int returnNumber)
        {
            //Arrange

            //Act
            var result = _customMath.MaxNumber(first, second);

            //Assert
            Assert.AreEqual(result, returnNumber);
        }

        [TestMethod]
        [Ignore("don't run")]

        public void CanBeMethod_Condition_returnsAssert()
        {
            //Arrange

            //Act

            //Assert
            Assert.IsFalse(false);
        }



    }
}
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class MathTests
    {
        [Test]
        public void Add_WhenCalled_ReturnTheSumOfArguments()
        {
            //Arrange
            var math = new Math();

            //Act
            var result = math.Add(1, 2);

            //Assert
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void Max_WhenFirstArgumentIsGreater_ReturnTheFirstArgument()
        {
            //Arrange
            var math = new Math();
            //Act
            var result = math.Max(2, 1);

            //Assert
            Assert.That(result, Is.EqualTo(2));
        }


        [Test]
        public void Max_WhenSecondArgumentIsGreater_ReturnTheSecondArgument()
        {
            //Arrange
            var math = new Math();

            //Act
            var result = math.Max(1, 2);

            //Assert
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void Max_WhenArgumentsAreEqual_ReturnTheSameArgument()
        {
            //Arrange
            var math = new Math();

            //Act
            var result = math.Max(2, 2);

            //Assert
            Assert.That(result, Is.EqualTo(2));
        }
    }
}

using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class HtmlFormatterTest
    {
        [Test]
        public void FormatAsBold_WhenCalled_ShouldEncloseTheStringWithStrongElement()
        {
            //Arrange
            var formatter = new HtmlFormatter();

            //Act
            var result = formatter.FormatAsBold("abc");

            //Specific Assert
            Assert.That(result, Is.EqualTo("<strong>abc</strong>").IgnoreCase);

            //More General
            //Assert.That(result, Does.StartWith("<strong>").IgnoreCase);
            //Assert.That(result, Does.EndWith("</strong>").IgnoreCase);
            //Assert.That(result, Does.Contain("abc"));
        }
    }
}

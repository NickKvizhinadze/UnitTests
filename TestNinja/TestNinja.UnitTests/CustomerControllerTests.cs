using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class CustomerControllerTests
    {
        private CustomerController _controller;

        [SetUp]
        public void SetUp()
        {
            _controller = new CustomerController();
        }

        [Test]
        public void GetCuStomer_IdIsZero_ReturnNotFound()
        {
            var result = _controller.GetCustomer(0);

            //NotFound
            Assert.That(result, Is.TypeOf<NotFound>());

            //NotFount or one of its derivates
            //Assert.That(result, Is.InstanceOf<NotFound>());
        }

        [Test]
        public void GetCuStomer_IdIsNotZero_ReturnNotFound()
        {
            var result = _controller.GetCustomer(1);

            Assert.That(result, Is.TypeOf<Ok>());
        }
    }
}

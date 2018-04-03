using Moq;
using NUnit.Framework;
using TestNinja.Mocking;

namespace TestNinja.UnitTests.Mocking
{
    [TestFixture]
    public class EmployeeControllerTests
    {

        [Test]
        public void DeleteEmployee_WhenCalled_DeleteTheEmployeeFromDb()
        {
            var mock = new Mock<IEmployeeRepository>();
            var controller = new EmployeeController(mock.Object);

            controller.DeleteEmployee(1);
            
            mock.Verify(m => m.Delete(1));
        }
        
    }
}

using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class StackTests
    {
        private Stack<string> _stack;

        [SetUp]
        public void SetUp()
        {
            _stack = new Stack<string>();
        }

        [Test]
        public void Count_WhenStackIsEmpty_ReturnZero()
        {
            Assert.That(_stack.Count, Is.EqualTo(0));
        }

        [Test]
        public void Push_AddNull_ThrowArgumentNullException()
        {
            Assert.That(() => _stack.Push(null), Throws.ArgumentNullException);
        }

        [Test]
        public void Push_AddObject_IncreaseCount()
        {
            _stack.Push("Test");

            Assert.That(_stack.Count, Is.EqualTo(1));
        }

        [Test]
        public void Pop_WhenCountIsZero_ThrowInvalidOperationException()
        {
            Assert.That(() => _stack.Pop(), Throws.InvalidOperationException);
        }

        [Test]
        public void Pop_WhenCalled_ReturnObject()
        {
            var obj = "Test";
            _stack.Push(obj);

            var result = _stack.Pop();

            Assert.That(result, Is.EqualTo(obj));
            Assert.That(_stack.Count, Is.EqualTo(0));
        }

        [Test]
        public void Peek_WhenCountIsZero_ThrowInvalidOperationException()
        {
            Assert.That(() => _stack.Peek(), Throws.InvalidOperationException);
        }

        [Test]
        public void Peek_WhenCalled_ReturnObject()
        {
            var obj = "Test";
            _stack.Push(obj);

            var result = _stack.Pop();

            Assert.That(result, Is.EqualTo(obj));
            Assert.That(_stack.Count, Is.EqualTo(0));
        }
    }
}

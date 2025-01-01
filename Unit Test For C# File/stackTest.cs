using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTesr
{
    [TestFixture]
    public class StackTest
    {
        [Test]
        public void Push_ArgIsNull_ThrowArgumentNullException()
        {
            var stack = new Stack<string>();
            Assert.That(() => stack.Push(null), Throws.ArgumentNullException);
            
        }

        [Test]
        public void Push_ValidArg_AddObjectToTheStack()
        {
            var stack = new Stack<string>();
            
            stack.Push("test");
            Assert.That(stack.Count, Is.EqualTo(1));
            
        }

        [Test]
        public void Count_EmptyStack_ReturnZero()
        {
            var stack = new Stack<string>();
            Assert.That(stack.Count, Is.EqualTo(0));
        }
        [Test]
        public void Pop_EmptyStack_ThrowInvalidOperationException()
        {}
    }
}
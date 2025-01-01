using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTest

{
    [TestFixture]
    
    public class MathUnitTest
    {
        private MathUnit _mathUnit; 
        
        // SetUp
        // TearDown

        [SetUp]
        public void SetUp()
        {
            _mathUnit = new MathUnit();
        }
        
        [Test]

        public void Add_WhenCalled_ReturnTheSumOfArguments()
        {
            var result = _mathUnit.Add(1, 2);
            
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        [TestCase(2, 1, 2)]
        [TestCase(1, 2, 2)]
        [TestCase(1, 1, 1)]
        public void Max_WhenCalled_ReturnTheGreaterArgument(int a, int b, int expectedResult)
        {
            var result = _mathUnit.Max(a, b);
            
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void GetOddNumbers_LimitIsGreaterThanZero_ReturnOddNumbersUpToLimit()
        {
            var result = _mathUnit.GetOddNumbers(5);


            Assert.That(result, Is.EquivalentTo(new [] {1, 3, 5}));
        }
    }
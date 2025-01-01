using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTesr
{
    [TestFixture]
    public class FizzBuzzUnitTest
    {
        [Test]
        public void GetOutPut_NumberDivisibleBy3And5_ReturnFizzBuzz()
        {
        //Arrange 
        int number = 15;
        //Act
        var result = FizzBuzz.GetOutput(number);
        //Assert 
        Assert.That(result, Is.EqualTo("FizzBuzz"));
        }

        [Test]
        public void GetOutPut_NumberDivisibleBy3_ReturnFizzBuzz()
        {
            //Arrange 
            int number = 9;
            //Act
            var result = FizzBuzz.GetOutput(number);
            //Assert 
            Assert.That(result, Is.EqualTo("Fizz"));
        }
        [Test]
        public void GetOutPut_NumberDivisibleBy5_ReturnFizzBuzz()
        {
            //Arrange 
            int number = 10;
            //Act
            var result = FizzBuzz.GetOutput(number);
            //Assert 
            Assert.That(result, Is.EqualTo("Buzz"));
        }
        [Test]
        public void GetOutPut_NumberNotDivisibleBy3And5_ReturnFizzBuzz()
        {
            //Arrange 
            int number = 1;
            //Act
            var result = FizzBuzz.GetOutput(number);
            //Assert 
            Assert.That(result, Is.EqualTo("1"));
        }
    }
}
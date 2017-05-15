using System;
using NUnit.Framework;

namespace FizzBuzz.Tests
{
    [TestFixture]
    public class FizzBuzzConverterTests
    {
        private FizzBuzzCompositeConverter _sut;

        [SetUp]
        public void Initialize()
        {
            _sut = new FizzBuzzCompositeConverter(new NumberConverter(), new FizzConverter(), new BuzzConverter());
        }

        [TestCase(1, ExpectedResult = "1")]
        [TestCase(2, ExpectedResult = "2")]
        [TestCase(3, ExpectedResult = "Fizz")]
        [TestCase(5, ExpectedResult = "Buzz")]
        [TestCase(15, ExpectedResult = "FizzBuzz")]
        public string ConvertTest(int number)
        {
            return _sut.Convert(number);
        }
    }
}

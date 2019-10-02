using System;
using NUnit.Framework;
using UnitTesting;

namespace UnitTestingTests
{
    public class CalculatorTests
    {
        [Test]
        [TestCase(5, 2, 7)]
        [TestCase(2147483647, 2, 2147483649)]
        [TestCase(5, 2147483647, 2147483652)]
        public void Add_FromTestCase_ReturnExpected(int a, int b, long expectedResult)
        {
            var calculator = new Calculator();

            var result = calculator.Add(a, b);

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        [TestCase(7, 2, 5)]
        [TestCase(Int32.MinValue, 2, -2147483650)]
        public void Sub_FromTestCase_ReturnExpected(int a, int b, long expectedResult)
        {
            var calculator = new Calculator();

            var result = calculator.Sub(a, b);

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        [TestCase(5, 2, 10)]
        [TestCase(Int32.MinValue, Int32.MinValue, 4611686018427387904)]
        public void Mul_FromTestCase_ReturnExpected(int a, int b, long expectedResult)
        {
            var calculator = new Calculator();

            var result = calculator.Mul(a, b);

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        [TestCase(15, 2, 7)]
        [TestCase(50, 0, long.MinValue)]
        public void Div_FromTestCase_ReturnExpected(int a, int b, long expectedResult)
        {
            var calculator = new Calculator();

            var result = calculator.Div(a, b);

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        [TestCase(15, 2, 1)]
        [TestCase(50, 0, long.MinValue)]
        public void Mod_FromTestCase_ReturnExpected(int a, int b, long expectedResult)
        {
            var calculator = new Calculator();

            var result = calculator.Mod(a, b);

            Assert.AreEqual(expectedResult, result);
        }

    }
}
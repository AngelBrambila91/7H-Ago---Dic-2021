using System;
using Xunit;
using CalculatorLib;
namespace CalculatorUnitTests
{
    public class CalculatorUnitTests
    {
        [Fact]
        public void TestingAdd2And2()
        {
            //Arrange
            double a = 2;
            double b = 2;
            double expected = 4;
            // Act
            var calc = new Calculator();
            double actual = calc.Add(a, b);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestAdd2And3()
        {
            // Arrange
            double a = 2;
            double b = 3;
            double expected = 5;
            // Act
            var calc = new Calculator();
            double actual = calc.Add(a, b);
            // Assert
            Assert.Equal(expected, actual);
        }
    }
}

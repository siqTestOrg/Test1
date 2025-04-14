using Xunit;
using MyLibrary;

namespace MyLibrary.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_ShouldReturnCorrectSum()
        {
            Calculator calculator = new Calculator();
            // Arrange
            int a = 2;
            int b = 3;

            // Act
            int result = calculator.Add(a, b);

            // Assert
            Assert.Equal(5, result);
        }
    }
}

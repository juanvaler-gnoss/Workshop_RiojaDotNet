using Xunit;
using FluentAssertions;
using ConsoleApp2;

namespace MathTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(2, 1, 1)]
        [InlineData(27, 13, 14)]
        [InlineData(5, 2, 3)]
        [InlineData(20, 1, 19)]
        public void Suma(int expected,int operando1,int operando2)
        {
            //Arrange

            //Act
            var result = MathOperations.Suma(operando1, operando2);

            //Assert
            result.Should().Be(expected);
        }
    }
}

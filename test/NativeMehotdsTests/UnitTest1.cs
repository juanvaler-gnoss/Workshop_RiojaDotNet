using NetCoreExample;
using Xunit;

namespace NativeMehotdsTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(2, 1, 1)]
        [InlineData(27, 13, 14)]
        [InlineData(5, 2, 3)]
        [InlineData(20, 1, 19)]
        public void Suma(int expected, int operando1, int operando2)
        {
            //Arrange

            //Act
            var result = NativeMethods.SumaNativo(operando1, operando2);

            //Assert
            Assert.Equal(expected, result);
        }
    }
}

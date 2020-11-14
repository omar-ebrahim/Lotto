using Lotto.Extensions;
using Xunit;

namespace Lotto.Tests.Extensions
{
    public class IntExtensionsTests
    {
        [Theory]
        [InlineData(1, 1, "1")]
        [InlineData(2, 1, " 1")]
        [InlineData(3, 1, "  1")]
        [InlineData(4, 1, "   1")]
        [InlineData(5, 1, "    1")]
        [InlineData(1, 12345, "12345")]
        [InlineData(0, 12345, "12345")]
        [InlineData(-1, 12345, "12345")]
        public void PadToString_Called_PadsNumber(int maxLength, int number, string expected)
        {
            // Arrange
            // Act
            var result = number.PadToString(maxLength);  //padder.PadNumber(number);

            // Assert
            Assert.Equal(expected.Length, result.Length);
            Assert.Equal(expected, result);
        }
    }
}

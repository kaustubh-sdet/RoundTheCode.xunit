using RoundTheCode.xUnit.methods;

namespace RoundTheCode.xUnit
{
    public class NumberHelperFactTests
    {
        [Fact]

        public void isOddNumber_ValueOf3_ShouldReturnTrue()
        {
            // Assert
            Assert.True(NumberHelper.IsOddNumber(3));
        }

        [Fact]
        public void isOddNumber_ValueOf6_ShouldReturnFalse()
        {
            // Assert
            Assert.False(NumberHelper.IsOddNumber(6));
        }

        [Fact]
        public void isEvenNumber_ValueOf3_ShouldReturnFalse()
        {
            // Assert
            Assert.False(NumberHelper.IsEvenNumber(3));
        }

        [Fact]
        public void isEvenNumber_ValueOf6_ShouldReturnTrue()
        {
            // Assert
            Assert.True(NumberHelper.IsEvenNumber(6));
        }

    }
}

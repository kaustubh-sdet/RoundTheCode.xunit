using RoundTheCode.xUnit.methods;

namespace RoundTheCode.xUnit
{
    public class NumberHelperTheoryTests
    {
        [Theory]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(7)]

        public void isOddNumber_ValueOf3_ShouldReturnTrue(int number)
        {
            // Assert
            Assert.True(NumberHelper.IsOddNumber(number));
        }

        [Theory]
        [InlineData(2)]
        [InlineData(4)]
        [InlineData(6)]
        public void isOddNumber_ValueOf6_ShouldReturnFalse(int number)
        {
            // Assert
            Assert.False(NumberHelper.IsOddNumber(number));
        }

        [Theory]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(7)]
        public void isEvenNumber_ValueOf3_ShouldReturnFalse(int number)
        {
            // Assert
            Assert.False(NumberHelper.IsEvenNumber(number));
        }

        [Theory]
        [InlineData(2)]
        [InlineData(4)]
        [InlineData(6)]
        public void isEvenNumber_ValueOf6_ShouldReturnTrue(int number)
        {
            // Assert
            Assert.True(NumberHelper.IsEvenNumber(number));
        }

        [Theory]
        [InlineData(2,"Poor")]
        [InlineData(5, "Average")]
        [InlineData(9, "Excellent")]
        public void RatingScore_Values_EqualCorrectRating(int number, string rating)
        {
            Assert.Equal(rating, NumberHelper.RatingScore(number));
        }
    }
}

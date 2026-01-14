using Day1UnitTest.xUnit.methods;
namespace Day1UnitTest.xUnit
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

        [Fact]
        public void RatingScore_ValueOf7_EqualsIsGreat()
        {
            // Assert
            Assert.Equal("Excellent", NumberHelper.RatingScore(7));
        }

        [Fact]
        public void RatingScore_ValueOf7_DoesNotEqualsBad()
        {
            // Assert
            Assert.NotEqual("Bad", NumberHelper.RatingScore(7));
        }
    }
}

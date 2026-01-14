namespace Day1UnitTest.xUnit.methods
{
    public static class NumberHelper
    {
        public static bool IsOddNumber(int number)
        {
            return number % 2 == 1;
        }

        public static bool IsEvenNumber(int number)
        {
            return number % 2 == 0;
        }

        public static string RatingScore(int number) => number switch
        {
            < 3 => "Poor",
            >= 3 and < 7 => "Average",
            >= 7 and <= 10 => "Excellent",
            _ => "Invalid Score",
        };
    }
}

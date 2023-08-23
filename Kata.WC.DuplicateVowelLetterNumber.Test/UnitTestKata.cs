namespace Kata.WC.DuplicateVowelLetterNumber.Test
{
    public class UnitTestKata
    {
        [Theory]
        [InlineData("kkkaattthhhyyy", "kathy")]
        [InlineData("aallleejjj9999nnnddd*rrroo", "alej9nd%ro")]
        [InlineData("vvvaallleennntttiinnnaa", "valentina")]
        [InlineData("jjjnnnqqq*", "jnq/")]
        [InlineData("ttt3333llllll0000", "t3ll0")]
        public void Test1_ValidInput_ReturnsCorrectResult(string expected, string actual)
        {
            Assert.Equal(expected,Kata.DuplicateVowelLetterNumber(actual));
        }
    }
}
using Xunit;

namespace NCoreUtils.Backports.Unit
{
    public class StringTests
    {
        [Fact]
        public void StartsWith()
        {
            Assert.True(StringBackports.StartsWith("xasd", 'x'));
            Assert.False(StringBackports.StartsWith("xasd", 'a'));
            Assert.False(StringBackports.StartsWith("", 'a'));
            Assert.False(StringBackports.StartsWith(null, 'a'));
        }

        [Fact]
        public void EndsWith()
        {
            Assert.True(StringBackports.EndsWith("xasd", 'd'));
            Assert.False(StringBackports.EndsWith("xasd", 'a'));
            Assert.False(StringBackports.EndsWith("", 'd'));
            Assert.False(StringBackports.EndsWith(null, 'd'));
        }
    }
}
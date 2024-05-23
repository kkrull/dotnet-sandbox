using System;
using Xunit;

namespace Conway.net
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var subject = new Greeter();
            Assert.Equal("Hello World!", subject.Message());
        }
    }
}

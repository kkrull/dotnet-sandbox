using Util;

namespace Util.Tests;
public class GreeterTest
{
  [Fact]
  public void Greet_AddressesEverybody()
  {
    var subject = new Greeter();
    Assert.Equal("Hello World!", subject.Greet());
  }
}

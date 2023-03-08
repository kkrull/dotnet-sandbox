using Util;

namespace Util.Tests;
public class GreeterTest
{
  [Fact]
  public void Greet_AddressesEverybody()
  {
    var subject = new Greeter();
    Assert.AreEqual("Hello World!", subject.Greet());
  }
}

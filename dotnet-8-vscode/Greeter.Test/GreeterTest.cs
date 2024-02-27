namespace GreeterApp;

public class GreeterTest
{
  [Fact]
  public void Greet_GivenNoName()
  {
    var subject = new Greeter();
    var response = subject.Greet();
    Assert.Equal("Hello World!", response);
  }

  [Fact]
  public void Greet_GivenAName()
  {
    var subject = new Greeter();
    var response = subject.Greet("Vijay");
    Assert.Equal("Hello Vijay!", response);
  }

  [Fact]
  public void Greet_GivenADifferentNameSoYouCanNotFakeTheProductionCodeAndHaveToWriteLogicInstead()
  {
    var subject = new Greeter();
    var response = subject.Greet("Vidya");
    Assert.Equal("Hello Vidya!", response);
  }
}

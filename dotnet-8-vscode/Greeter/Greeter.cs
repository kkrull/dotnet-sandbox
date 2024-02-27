namespace GreeterApp;

public class Greeter
{
  public string Greet()
  {
    return "Hello World!";
  }

  public string Greet(string name)
  {
    return $"Hello {name}!";
  }
}

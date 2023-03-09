namespace Util;

using System;
public class Greeter
{
  public String Greet(string name = "World")
  {
    return string.Format("Hello {0}!", name);
  }
}

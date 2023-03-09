using System;
using Util;

namespace Greeter;
class Program
{
  static void Main(string[] args)
  {
    var greeter = new Util.Greeter();
    Console.WriteLine(greeter.Greet());
  }
}

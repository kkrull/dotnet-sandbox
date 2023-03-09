using System;
using Util;

namespace App;
class Program
{
  static void Main(string[] args)
  {
    var greeter = new Greeter();
    string message = args.Length == 0 ? greeter.Greet() : greeter.Greet(args[0]);
    Console.WriteLine(message);
  }
}

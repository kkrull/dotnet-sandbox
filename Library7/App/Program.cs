using System;
using System.Linq;
using Util;

namespace App;
class Program
{
  static void Main(string[] args)
  {
    var greeter = new Greeter();
    var message = args.Select(x => greeter.Greet(x)).FirstOrDefault(greeter.Greet());
    Console.WriteLine(message);
  }
}

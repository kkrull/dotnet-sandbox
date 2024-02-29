namespace GreeterApp;

public static class RomanNumeral
{
  public static string Convert(int number)
  {
    if(number == 1)
    {
      return "I";
    }
    else if(number == 2)
    {
      return "II";
    }
    else
    {
      return "<undefined>";
    }
  }
}

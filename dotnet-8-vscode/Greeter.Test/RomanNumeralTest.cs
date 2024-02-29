namespace GreeterApp;

public class RomanNumeralTest
{
  [Fact]
  public void Convert_GivenOne()
  {
    var romanNumeral = RomanNumeral.Convert(1);
    Assert.Equal("I", romanNumeral);
  }

  [Fact]
  public void Convert_GivenTwo()
  {
    var romanNumeral = RomanNumeral.Convert(2);
    Assert.Equal("II", romanNumeral);
  }
}

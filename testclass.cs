using Xunit;
using c_sharp_console_arcade;

public class testclass
{
  [Fact]
  public void RandomNumberGeneratorTest()
  {
    Assert.InRange(Program.RandomNumberGenerator(), 1, 4);
  }
}
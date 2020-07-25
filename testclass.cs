using Xunit;
using c_sharp_console_arcade;

public class testclass
{
  [Fact]
  public void RandomNumberGeneratorTest()
  {
    Assert.InRange(Program.RandomNumberGenerator(), 1, 4);
  }

  [Fact]
  public void ComputerChoiceTest()
  {
    Assert.Equal("rock", Program.ComputerChoice(1));
    Assert.Equal("paper", Program.ComputerChoice(2));
    Assert.Equal("scissors", Program.ComputerChoice(3));
  }
}
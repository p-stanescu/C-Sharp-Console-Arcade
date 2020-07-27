using Xunit;
using c_sharp_console_arcade;

public class testclass
{

  // Test function to check the numbers generated are only between 0 and 4

  [Fact]
  public void RandomNumberGeneratorTest()
  {
    Assert.InRange(Program.RandomNumberGenerator(), 1, 4);
  }

  // Test function the outcome of the ComputerChoice function based on all the numbers

  [Fact]
  public void ComputerChoiceTest()
  {
    Assert.Equal("rock", Program.ComputerChoice(1));
    Assert.Equal("paper", Program.ComputerChoice(2));
    Assert.Equal("scissors", Program.ComputerChoice(3));
  }

  // Test function to check the outcome of the game based on all different choices

  [Fact]
  public void GameOutcomeTest()
  {
    Assert.Equal("You lost!", Program.GameOutcome("rock", "paper"));
    Assert.Equal("You lost!", Program.GameOutcome("paper", "scissors"));
    Assert.Equal("You lost!", Program.GameOutcome("scissors", "rock"));
    Assert.Equal("You won, congratulations!", Program.GameOutcome("rock", "scissors"));
    Assert.Equal("You won, congratulations!", Program.GameOutcome("paper", "rock"));
    Assert.Equal("You won, congratulations!", Program.GameOutcome("scissors", "paper"));
    Assert.Equal("It's a draw!", Program.GameOutcome("paper", "paper"));
    Assert.Equal("It's a draw!", Program.GameOutcome("scissors", "scissors"));
    Assert.Equal("It's a draw!", Program.GameOutcome("rock", "rock"));
  }

}
using System;

namespace c_sharp_console_arcade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the C# version of rock, paper, scissors! This your chance to play this classic game against a computer. To start off, please enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}! Now, choose rock, paper or scissors: ");
            string userChoice = Console.ReadLine();
            string lowerUserChoice = userChoice.ToLower();
            int randomNumber = RandomNumberGenerator();
        }

        public static int RandomNumberGenerator()
        {
            Random integer = new Random();
            int number = integer.Next(1, 4);
            return number;
        }

        public static string ComputerChoice()
        {
            

        }

    }
}

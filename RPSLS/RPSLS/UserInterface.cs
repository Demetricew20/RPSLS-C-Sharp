using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    class UserInterface
    {
        public void StartMessage(string gameName)
        {
            Console.WriteLine($"Welcome to {gameName}!");
        }

        public void Rules()
        {
            Console.WriteLine("**RULES**:\nEach player will simultaneously through a gesture from the available options list.");
            Console.WriteLine("\nScoring goes as follows:\nRock > Scissors\nRock > Lizard\nPaper > Rock\nPaper > Spock");
            Console.WriteLine("\nScissors > Lizard\nScissors > Paper\nLizard > Spock\nLizard > Paper\nSpock > Scissors\nSpock > Rock");
        }
    }
}

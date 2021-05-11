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
            Console.WriteLine("\n**RULES**:\nEach player will simultaneously through a gesture from the available options list.");
            Console.WriteLine("\nScoring goes as follows:\nRock > Scissors\nRock > Lizard\nPaper > Rock\nPaper > Spock");
            Console.WriteLine("\nScissors > Lizard\nScissors > Paper\nLizard > Spock\nLizard > Paper\nSpock > Scissors\nSpock > Rock");
        }

        public string ModeSelection()
        {
            Console.WriteLine("Enter mode - Single player | Multi-Player");
            string userInput = Console.ReadLine();
            return userInput;
        }

        public void ModeSelectionStatement(string mode)
        {
            Console.WriteLine($"** {mode} mode selected!**");
        }

        public void AvailableGestures(string options)
        {
            Console.WriteLine($"\nAvailable Gestures: {options}");
        }

        public string GestureSelection(string playerGesture, string playerName)
        {
            Console.WriteLine($"{playerName} select gesture: ");
            return playerGesture;
        }

        public void GestureSelectedStatement(string playerName, string playerGesture)
        {
            Console.WriteLine($"{playerName} selected: {playerGesture}");
        }

        public void CpuSelectionStatment(string cpuName, string cpuGesture)
        {
            Console.WriteLine($"{cpuName} selected: {cpuGesture}");
        }

        public void ValidationStatement()
        {
            Console.WriteLine("Invalid input. Must select gesture from list. Try Again.");
        }
    }
}

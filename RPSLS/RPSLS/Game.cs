using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    class Game
    {
        public string name;
        public string[] modeOptions = new string[2];
        public string modeSelected;
        public UserInterface userInterface = new UserInterface();

        public Game()
        {
            name = "RPSLS";
            modeOptions[0] = "Single-Player";
            modeOptions[1] = "Multi-Player";
        }

        public void WelcomeMessage()
        {
            userInterface.StartMessage(this.name);
            userInterface.Rules();
        }

        public void SelectMode()
        {
            string userInput = userInterface.ModeSelection();
            if (userInput != modeOptions[0] || userInput != modeOptions[1])
            {
                userInterface.ValidationStatement();
                userInput = userInterface.ModeSelection();
            }
            this.modeSelected = userInput;
        }
    }
}

using System;

namespace RPSLS
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Human playerOne = new Human("John");
            Human playerTwo = new Human("Jane");
            CPU cpuPlayer = new CPU("CPU");
            PlayersList playerList = new PlayersList();
            playerList.AddPlayer(playerOne);
            playerList.AddPlayer(playerTwo);
            playerList.AddPlayer(cpuPlayer);
            playerList.ListCount();
            Game rpsls = new Game();
            rpsls.WelcomeMessage();
            rpsls.SelectMode();

        }
    }
}

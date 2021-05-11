using System;

namespace RPSLS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Human playerOne = new Human("John");
            CPU cpuPlayer = new CPU("CPU");
            PlayersList playerList = new PlayersList();
            playerList.AddPlayer(playerOne);
            playerList.AddPlayer(cpuPlayer);
            playerList.listCount();
        }
    }
}

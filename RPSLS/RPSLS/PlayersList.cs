using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    class PlayersList
    {

        public List<object> players = new List<object>();

        public PlayersList()
        {

        }

        public void AddPlayer(object player)
        {
            players.Add(player);
        }

        public void listCount()
        {
            Console.WriteLine(players.Count);
        }

    }
}

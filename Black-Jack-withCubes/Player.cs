using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black_Jack_withCubes
{
    public class Player
    {
        //player constructor
        public Player(string name)
        {
            name = Name;
        }


        public string Name { get; set; }
        public bool IsPlaying { get; set; }

        public static Game operator +(Game game, Player player)
        {
            game.Players.Add(player);
            return game;
        }
        public static Game operator -(Game game, Player player)
        {
            game.Players.Remove(player);
            return game;
        }
    }
}

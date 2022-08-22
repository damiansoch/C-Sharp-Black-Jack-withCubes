using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black_Jack_withCubes
{
    public class Game
    {

        private List<Player> _players = new();
        public List<Player> Players { get { return _players; } set { _players = value; } }
    }
}

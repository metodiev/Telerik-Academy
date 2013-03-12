using JustBelot.Common;
using JustBelot.NikiAI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustBelot.UI
{
    class Program
    {
        static void Main(string[] args)
        {

            HumanPlayer player = new HumanPlayer(true);
            Console.WriteLine(player.IsLocal);

            List<IPlayer> players = new List<IPlayer>();

            players.Add(new HumanPlayer());
            players.Add(new Player());
            players.Add(new Player());
            players.Add(new Player());
        }
    }
}

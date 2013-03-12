using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustBelot.Common
{
    public class HumanPlayer : IPlayer
    {
        private bool isLocal = true;

        public bool IsLocal
        {
            get { return isLocal; }
        }

        public HumanPlayer(bool isLocal)
        {
            this.isLocal = isLocal;
        }

        public HumanPlayer()
        {
            this.isLocal = false;
        }

        public string Name
        {
            get { return "Human player"; }
        }

        public string Points
        {
            get { throw new NotImplementedException(); }
        }

        public void PlayCard()
        {
            Console.WriteLine("Human player played a card.");
        }
    }
}

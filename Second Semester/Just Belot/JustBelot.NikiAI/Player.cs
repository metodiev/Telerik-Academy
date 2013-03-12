using JustBelot.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustBelot.NikiAI
{
    public class Player : IPlayer
    {
        public string Name
        {
            get { return "Niki bot"; }
        }

        public string Points
        {
            get { throw new NotImplementedException(); }
        }

        public void PlayCard()
        {
            var helper = new PlayHelper();
            helper.MakeDecision();
            Console.WriteLine("Niki played a card.");
        }
    }
}

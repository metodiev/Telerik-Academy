using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustBelot.Common
{
    public class Card
    {
        public CardColor Color { get; set; }
        public CardType Type { get; set; }

        public Card(CardColor color, CardType type)
        {
            this.Color = color;
            this.Type = type;
        }
    }
}

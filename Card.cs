using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stacks_conway_david
{
    internal class Card
    {

      public string Number { get; }

        public string Suit { get; }

        public Card(string numParam, string suitParam)
        {
            Number = numParam;  
            Suit = suitParam;
        }

    }
}

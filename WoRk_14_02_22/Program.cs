using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoRk_14_02_22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var startingDeck = from s in Suits()
                               from r in Ranks()
                               select new { Suit = s, Rank = r };

            // Display each card that we've generated and placed in startingDeck in the console
            foreach (var card in startingDeck)
            {
                Console.WriteLine(card);
            }
        }
    }
}

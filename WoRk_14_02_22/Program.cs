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
            //var startingDeck = from s in Suits()
            //                   from r in Ranks()
            //                   select new { Suit = s, Rank = r };

            //foreach (var card in startingDeck)
            //{
            //    Console.WriteLine(card);
            //}

            var startingDeck = Suits().SelectMany(suit => Ranks().Select(rank => new { Suit = suit, Rank = rank }));
        }

        static IEnumerable<string> Suits()
        {
            yield return "Трефы";
            yield return "Бубны";
            yield return "Червы";
            yield return "Пики";
        }

        static IEnumerable<string> Ranks()
        {
            yield return "два";
            yield return "трии";
            yield return "четыре";
            yield return "пять";
            yield return "шесть";
            yield return "семь";
            yield return "восемь";
            yield return "девять";
            yield return "десять";
            yield return "Джокер";
            yield return "Королева";
            yield return "Король";
            yield return "Туз";
        }
    }
}

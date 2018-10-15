using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03._Number_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> firstPlayerCards = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> secondPlayerCards = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            Regex number = new Regex(@"([0-9]+)");

            int i = 0;
            int j = 0;

            int turns = 0;

            while (firstPlayerCards.Any() && secondPlayerCards.Any())
            {
                Match firstMatch = number.Match(firstPlayerCards[i]);
                Match secondMatch = number.Match(secondPlayerCards[i]);

                if (firstPlayerCards[i] != secondPlayerCards[i])
                {
                    if(int.Parse(firstMatch.Value) > int.Parse(secondMatch.Value))
                    {
                        firstPlayerCards.Add(firstPlayerCards[i]);
                        firstPlayerCards.Add(secondPlayerCards[i]);
                        firstPlayerCards.RemoveAt(0);
                        secondPlayerCards.RemoveAt(0);
                    }
                    else if(int.Parse(firstMatch.Value) < int.Parse(secondMatch.Value))
                    {
                        secondPlayerCards.Add(firstPlayerCards[i]);
                        secondPlayerCards.Add(secondPlayerCards[i]);
                        firstPlayerCards.RemoveAt(0);
                        secondPlayerCards.RemoveAt(0);
                    }
                }

                //  if(i > currentCount )
                //  {
                //      i = 0;
                //      j = 0;
                //  }
                //

                if(i )

                i++;
                j++;
                turns++;
            }

            Console.WriteLine(turns);
        }
    }
}

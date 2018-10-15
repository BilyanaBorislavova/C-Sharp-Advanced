using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace _03._Ticket_Trouble
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"\[([^\[\]]*)\{([A-Z]{3}\s[A-Z]{2})\}([^\[\]]*)\{([A-Z][0-9]{1,2})\}([^\[\]]*)\]|\{([^\{\}]*)\[([A-Z]{3}\s[A-Z]{2})\]([^\{\}]*)\[([A-Z][0-9]{1,2})\]([^\[\]]*)\}");

            string location = Console.ReadLine();

            string input = Console.ReadLine();

            MatchCollection matches = regex.Matches(input);
            List<string> seats = new List<string>();

            foreach (Match m in matches)
            {
                //2 4 //7 9

                if(m.Groups[2].Value == location)
                {
                    seats.Add(m.Groups[4].Value);
                   
                }
            }

            Console.WriteLine($"You are traveling to {location} on seats {string.Join(" and ", seats)}.");

        }
    }
}

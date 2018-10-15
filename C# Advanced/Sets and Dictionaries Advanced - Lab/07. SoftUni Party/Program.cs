using System;
using System.Collections.Generic;

namespace _07._SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            string guestList = Console.ReadLine();

            List<string> reservations = new List<string>();
            List<string> VIPs = new List<string>();

            while (guestList != "PARTY")
            {
                if(guestList.Length == 8)
                {
                    if (Char.IsDigit(guestList[0]))
                    {
                        VIPs.Add(guestList);
                    }
                    else
                    {
                        reservations.Add(guestList);
                    }
                }

                guestList = Console.ReadLine();
            }

            string comingGuests = Console.ReadLine();

            while (comingGuests != "END")
            {
                if (reservations.Contains(comingGuests))
                {
                    reservations.Remove(comingGuests);
                }

                if (VIPs.Contains(comingGuests))
                {
                    VIPs.Remove(comingGuests);
                }

                comingGuests = Console.ReadLine();
            }

            Console.WriteLine(VIPs.Count + reservations.Count);
            if (VIPs.Count > 0)
            {
                Console.WriteLine(string.Join("\n", VIPs));
            }
            Console.WriteLine(string.Join("\n", reservations));
        }
    }
}

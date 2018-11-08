using System;
using System.Text.RegularExpressions;

namespace Telephony
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] phones = Console.ReadLine().Split();
            string[] sites = Console.ReadLine().Split();

            Regex phoneRegex = new Regex(@"^([0-9]+)$");
            Regex sitesRegex = new Regex(@"^([^0-9]+)$");

            Smartphone smartphone = new Smartphone();

            foreach (var phone in phones)
            {
                if(phoneRegex.IsMatch(phone))
                {
                    Console.WriteLine(smartphone.Call() + phone);
                }
                else
                {
                    Console.WriteLine("Invalid number!");
                }
            }

            foreach (var site in sites)
            {
                if(sitesRegex.IsMatch(site))
                {
                    Console.WriteLine(smartphone.Browse() + site + "!");
                }
                else
                {
                    Console.WriteLine("Invalid URL!");
                }
            }
        }
    }
}

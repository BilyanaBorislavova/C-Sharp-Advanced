using System;
using System.Text.RegularExpressions;

namespace fak1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Regex regex = new Regex(@"^s:([^;]+);r:([^;]+);m--(""[A-Za-z ]+"")$");

            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                MatchCollection matches = regex.Matches(input);

                foreach (Match item in matches)
                {
                    string sender = item.Groups[1].Value;
                    string senderName = "";

                    string receiver = item.Groups[2].Value;
                    string receiverName = "";

                    string message = item.Groups[3].Value;

                    foreach (var ch in sender)
                    {
                        if(Char.IsLetter(ch) || ch == ' ')
                        {
                            senderName += ch;
                        }

                        if (Char.IsDigit(ch))
                        {
                            sum += int.Parse(ch.ToString());
                        }
                    }

                    foreach (var ch in receiver)
                    {
                        if (Char.IsLetter(ch) || ch == ' ')
                        {
                            receiverName += ch;
                        }

                        if (Char.IsDigit(ch))
                        {
                            sum += int.Parse(ch.ToString());
                        }
                    }

                    Console.WriteLine($"{senderName} says {message} to {receiverName}");
                }
            }
            Console.WriteLine($"Total data transferred: {sum}MB");
        }
    }
}

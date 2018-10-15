using System;
using System.Text.RegularExpressions;

namespace _03._Cubic_s_Messages
{
    class CubicMessages
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Regex regex = new Regex(@"^([0-9]+)([A-Za-z]+)([^A-Za-z]*)$");

            while (input != "Over!")
            {
                int number = int.Parse(Console.ReadLine());

                MatchCollection matches = regex.Matches(input);

                foreach (Match item in matches)
                {
                    string message = item.Groups[2].Value;
                    if (message.Length == number)
                    {
                        string numOne = item.Groups[1].Value;
                        string numTwo = item.Groups[3].Value;
                        string str = "";
                        string str1 = "";

                        foreach (var digit in numOne)
                        {
                            int currentDigit = int.Parse(digit.ToString());

                            if (currentDigit > message.Length - 1)
                            {
                                str += " ";
                            }
                            else
                            {
                                str += message[currentDigit];
                            }
                        }

                        foreach (var digit in numTwo)
                        {
                            if (Char.IsDigit(digit))
                            {
                                int currentDigit = int.Parse(digit.ToString());

                                if (currentDigit > message.Length - 1)
                                {
                                    str1 += " ";
                                }
                                else
                                {
                                    str1 += message[currentDigit];
                                }
                            }
                        }

                        Console.WriteLine(message + " " + "==" + " " + str + str1);
                    }
                }

                input = Console.ReadLine();
            }
        }
    }
}

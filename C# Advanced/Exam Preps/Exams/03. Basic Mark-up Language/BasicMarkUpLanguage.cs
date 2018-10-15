using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _03._Basic_Mark_up_Language
{
    class BasicMarkUpLanguage
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Regex inversedRegex = new Regex(@"\s*<\s*inverse\s* content\s*=\s*""(?<word>[^""]+)""\s*\/\s*>\s*");
            Regex reversedRegex = new Regex(@"\s*<\s*reverse\s* content\s*=\s*""(?<word>[^""]+)""\s*\/\s*>\s*");
            Regex repeatRegex = new Regex(@"\s*<\s*repeat\s* value\s*=\s*""\s*([0-9]*)\s*""\s* content\s*=\s*""(?<word>[^""]+)""\s*\/\s*>\s*");

            List<string> output = new List<string>();
            while (input != "<stop/>")
            {
                MatchCollection inversedMatch = inversedRegex.Matches(input);
                MatchCollection reversedMatch = reversedRegex.Matches(input);
                MatchCollection repeatMatch = repeatRegex.Matches(input);

                foreach (Match item in inversedMatch)
                {
                    string result = item.Groups["word"].Value;
                    string word = "";
                    foreach (var ch in result)
                    {
                        char currentChar = ch;
                        if (Char.IsUpper(currentChar))
                        {
                            word += Char.ToLower(currentChar);
                        }
                        else if (Char.IsLower(currentChar))
                        {
                            word += Char.ToUpper(currentChar);
                        }
                        else
                        {
                            word += currentChar;
                        }
                    }
                    output.Add(word);
                }

                foreach (Match item in reversedMatch)
                {
                    string result = item.Groups["word"].Value;
                    string word = "";

                    for (int i = result.Length - 1; i >= 0; i--)
                    {
                        word += result[i];
                    }
                    output.Add(word);
                }

                foreach (Match item in repeatMatch)
                {
                    string result = item.Groups["word"].Value;
                    int number = int.Parse(item.Groups[1].Value);

                    for (int i = 0; i < number; i++)
                    {
                        output.Add(result);
                    }
                }

                input = Console.ReadLine();
            }

            int counter = 0;
            foreach (var item in output)
            {
                Console.WriteLine($"{++counter}. {item}");
            }
        }
    }
}

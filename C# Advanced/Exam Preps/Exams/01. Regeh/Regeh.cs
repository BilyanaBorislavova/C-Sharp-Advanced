using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _01._Key_Revolver
{
    class Regeh
    {
        static void Main(string[] args)
        {
            //\[([^\s[\]]+)(?<nums><([0-9]+)REGEH([0-9]+)>)([^\s[\]]+)\]

            string input = Console.ReadLine();

            Regex regex = new Regex(@"\[([^\s[\]]+)(?<nums><([0-9]+)REGEH([0-9]+)>)([^\s[\]]+)\]");
            Regex regexNum = new Regex(@"([0-9]+)");

            MatchCollection match = regex.Matches(input);

            int indexSum = 0;
            string str = "";

            foreach (Match item in match)
            {
                var nums = item.Groups["nums"].Value;

                MatchCollection numMatches = regexNum.Matches(nums);

                foreach (Match n in numMatches)
                {
                    int currIndex = int.Parse(n.ToString());

                    if (indexSum + currIndex <= input.Length - 1)
                    {
                        indexSum += currIndex;
                    }
                    else
                    {
                        indexSum = currIndex;
                    }

                    str += input[indexSum];
                }
            }

            Console.WriteLine(str);
        }
    }
}

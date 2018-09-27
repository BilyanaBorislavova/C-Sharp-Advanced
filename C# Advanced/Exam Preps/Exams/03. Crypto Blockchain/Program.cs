using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _03._Crypto_Blockchain
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            StringBuilder str = new StringBuilder();

            Regex regex = new Regex(@"\{([^\{\}\[\]]*)\}|\[([^\{\}\[\]]*)\]");
            Regex numRegex = new Regex(@"([0-9]{3})");

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                str.Append(input);
            }

            int length = 0;

            MatchCollection matches = regex.Matches(str.ToString());

            foreach (Match m in matches)
            {
                MatchCollection numMatch = numRegex.Matches(m.Value);
                length = m.Value.Length;
                foreach (Match item in numMatch)
                {
                    int currNumber = int.Parse(item.Value) - length;
                    Console.Write((char)currNumber);
                }
            }

            Console.WriteLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

public class DuplicateKeyComparer<TKey>
                :
             IComparer<TKey> where TKey : IComparable
{
    #region IComparer<TKey> Members

    public int Compare(TKey x, TKey y)
    {
        int result = x.CompareTo(y);

        if (result == 0)
            return 1;   // Handle equality as beeing greater
        else
            return result;
    }

    #endregion
}

public class Program
{
    public static void Main()
    {
        SortedDictionary<int, string> list = new SortedDictionary<int, string>(new DuplicateKeyComparer<int>());
        List<int> numbers = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();


        foreach (var number in numbers)
        {
            string str = "";

            foreach (var digit in number.ToString())
            {
                if (digit == '0')
                {
                    str += "zero-";
                }
                else if (digit == '1')
                {
                    str += "one-";
                }
                else if (digit == '2')
                {
                    str += "two-";
                }
                else if (digit == '3')
                {
                    str += "three-";
                }
                else if (digit == '4')
                {
                    str += "four-";
                }
                else if (digit == '5')
                {
                    str += "five-";
                }
                else if (digit == '6')
                {
                    str += "six-";
                }
                else if (digit == '7')
                {
                    str += "seven-";
                }
                else if (digit == '8')
                {
                    str += "eight-";
                }
                else if (digit == '9')
                {
                    str += "nine-";
                }
            }
            str = str.Substring(0, str.Length - 1);

            list.Add(number, str);
        }

        string output = "";
        foreach (var item in list.OrderBy(a => a.Value))
        {
            output += item.Key + ", ";
        }

        Console.WriteLine(output.Substring(0, output.Length - 2));

    }
}
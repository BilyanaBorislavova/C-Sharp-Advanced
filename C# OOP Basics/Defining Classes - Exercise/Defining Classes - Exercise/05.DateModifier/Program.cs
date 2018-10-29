using System;

namespace DateModifier
{
   public class Program
    {
       public static void Main(string[] args)
        {
            string date1 = Console.ReadLine();
            string date2 = Console.ReadLine();

            DateModifier date = new DateModifier(date1, date2);
            Console.WriteLine(date.FindDifferenceBetweenDates());
        }
    }
}

using System;
using static HotelReservation.Enums;

namespace HotelReservation
{
     public class Program
    {
        static void Main(string[] args)
        {
            string[] info = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            decimal price = decimal.Parse(info[0]);
            int days = int.Parse(info[1]);
            Seasons seasons = Enum.Parse<Seasons>(info[2]);

            if (info.Length == 4)
            {
                DiscountType discount = Enum.Parse<DiscountType>(info[3]);
                PriceCalculator priceCalculator = new PriceCalculator(price, days, seasons, discount);
                Console.WriteLine(priceCalculator.TotalPrice());
            }
            else if(info.Length == 3)
            {
                PriceCalculator priceCalculator = new PriceCalculator(price, days, seasons);
                Console.WriteLine(priceCalculator.TotalPrice());
            }


            
        }
    }
}

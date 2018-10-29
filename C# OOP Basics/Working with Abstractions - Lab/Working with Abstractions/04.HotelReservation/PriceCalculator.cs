using System;
using System.Collections.Generic;
using System.Text;
using static HotelReservation.Enums;

namespace HotelReservation
{
   public class PriceCalculator
    {
        private decimal pricePerDay;
        private int numberOfDays;
        private Seasons season;
        private DiscountType discountType;

        public PriceCalculator(decimal price, int days, Seasons seasons)
        {
            this.pricePerDay = price;
            this.numberOfDays = days;
            this.season = seasons;
        }

        public PriceCalculator(decimal price, int days, Seasons seasons, DiscountType discount) : this(price, days, seasons)
        {
            this.discountType = discount;
        }

        public string TotalPrice()
        {
            var total = (numberOfDays * pricePerDay) * (int)season;
            var discount = ((decimal)(int)discountType) / 100;
            return $"{total - (total * discount):f2}";
        }
    }
}

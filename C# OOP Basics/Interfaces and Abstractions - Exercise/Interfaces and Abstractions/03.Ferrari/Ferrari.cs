using System;
using System.Collections.Generic;
using System.Text;

namespace Ferrari
{
    public class Ferrari : IFerrari
    {
        public string Model { get; set; }
        public string Driver { get; set; }

        public Ferrari(string driver)
        {
            this.Model = "488-Spider";
            this.Driver = driver;
        }

        public string GasPedal()
        {
            return "Zadu6avam sA!";
        }

        public string PushBrakes()
        {
            return "Brakes!";
        }

        public override string ToString()
        {
            return $"{this.Model}/{this.PushBrakes()}/{this.GasPedal()}/{this.Driver}";
        }
    }
}

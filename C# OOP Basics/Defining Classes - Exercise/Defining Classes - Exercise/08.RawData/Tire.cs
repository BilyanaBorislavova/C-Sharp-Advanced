using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
   public class Tire
    {
        private double tireOnePressure;
        private int tireOneAge;

        private double tireTwoPressure;
        private int tireTwoAge;

        private double tireThreePressure;
        private int tireThreeAge;

        private double tireFourPressure;
        private int tireFourAge;

        public Tire(double onePressure, int oneAge, double twoPressure, int twoAge, double threePressure, int threeAge, double fourPresuure, int fourAge)
        {
            this.TireOnePressure = onePressure;
            this.TireOneAge = oneAge;
            this.TireTwoPressure = twoPressure;
            this.TireTwoAge = twoAge;
            this.TireThreePressure = threePressure;
            this.TireThreeAge = threeAge;
            this.TireFourPressure = fourPresuure;
            this.TireFourAge = fourAge;
        }

        public int TireFourAge
        {
            get { return tireFourAge; }
            set { tireFourAge = value; }
        }

        public double TireFourPressure
        {
            get { return tireFourPressure; }
            set { tireFourPressure = value; }
        }


        public int TireThreeAge
        {
            get { return tireThreeAge; }
            set { tireThreeAge = value; }
        }


        public double TireThreePressure
        {
            get { return tireThreePressure; }
            set { tireThreePressure = value; }
        }


        public int TireTwoAge
        {
            get { return tireTwoAge; }
            set { tireTwoAge = value; }
        }

        public double TireTwoPressure
        {
            get { return tireTwoPressure; }
            set { tireTwoPressure = value; }
        }

        public int TireOneAge
        {
            get { return tireOneAge; }
            set { tireOneAge = value; }
        }

        public double TireOnePressure
        {
            get { return tireOnePressure; }
            set { tireOnePressure = value; }
        }

    }
}

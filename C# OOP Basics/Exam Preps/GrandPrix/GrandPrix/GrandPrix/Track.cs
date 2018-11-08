using System;
using System.Collections.Generic;
using System.Text;


    public class Track
    {

    private int lapsNumber;
    private double length;
    private string weather;
    private int currLap;

    public int CurrLap
    {
        get { return currLap; }
        set { currLap = value; }
    }


    public Track(int lapsNumber, double length)
    {
        this.Weather = "Sunny";
        this.LapsNumber = lapsNumber;
        this.Length = length;
        this.CurrLap = 0;
    }

    public string Weather
    {
        get { return weather; }
        set { weather = value; }
    }

    public double Length
    {
        get { return length; }
        set { length = value; }
    }


    public int LapsNumber
    {
        get { return lapsNumber; }
        set { lapsNumber = value; }
    }

}


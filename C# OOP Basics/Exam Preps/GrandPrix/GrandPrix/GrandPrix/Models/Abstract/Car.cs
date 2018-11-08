using System;
using System.Collections.Generic;
using System.Text;


    public class Car
    {
    private int hp;
    private double fuelAmount;
    private Tyre tyre;

    public Car(int hp, double fuelAmount, Tyre tyre)
    {
        this.Hp = hp;
        this.FuelAmount = fuelAmount;
        this.Tyre = tyre;
    }

    public Tyre Tyre
    {
        get { return tyre; }
        set { tyre = value; }
    }

    public double FuelAmount
    {
        get { return fuelAmount; }
        set
        {
            if(value > 160)
            {
                value = 160;
            }
            else if(value < 0)
            {
                throw new ArgumentException("Out of fuel");
            }
            this.fuelAmount = value;
        }
    }


    public int Hp
    {
        get { return hp; }
        set { hp = value; }
    }

}


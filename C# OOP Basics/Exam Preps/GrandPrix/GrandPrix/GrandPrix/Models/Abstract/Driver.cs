using System;
using System.Collections.Generic;
using System.Text;


    public abstract class Driver
    {
    private string name;
    private double totalTime;
    private Car car;
    private double fuelConsumptionPerKm;
    private double speed;

    protected Driver(string name, Car car, double consumption)
    {
        this.Name = name;
        this.Car = car;
        this.TotalTime = 0;
        this.Speed = (this.Car.Hp + this.Car.Tyre.Degradation) / this.Car.FuelAmount;
    }

    public virtual double Speed
    {
        get { return speed; }
        set { speed = value; }
    }

    public double FuelConsumptionPerKm
    {
        get { return fuelConsumptionPerKm; }
        set { fuelConsumptionPerKm = value; }
    }

    public Car Car
    {
        get { return car; }
        set { car = value; }
    }


    public double TotalTime
    {
        get { return totalTime; }
        set { totalTime = value; }
    }

    public string Name
    {
        get { return name; }
        set
        {
            if(value.Contains(" "))
            {
                throw new ArgumentException("");
            }
            name = value;
        }
    }

}


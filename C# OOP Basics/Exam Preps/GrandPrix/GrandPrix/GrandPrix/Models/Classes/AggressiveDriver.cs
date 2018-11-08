using System;
using System.Collections.Generic;
using System.Text;


public class AggressiveDriver : Driver
{
    public AggressiveDriver(string name, Car car) : base(name, car, 2.7)
    {

    }

    public override double Speed
    {
        get => base.Speed;
        set
        {
            base.Speed *= 1.3;
        }

    }
}


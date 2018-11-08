using System;
using System.Collections.Generic;
using System.Text;


public class UltrasoftTyre : Tyre
{
    private double grip;

    public UltrasoftTyre(double hardness, double grip) : base("Ultrasoft", hardness)
    {
        this.Grip = grip;
    }

    public override double Degradation
    {
        get => base.Degradation;
        set
        {
            if (value < 30)
            {
                throw new ArgumentException("Blown Tyre");
            }
            base.Degradation = value;
        }
    }

    public double Grip
    {
        get { return grip; }
        set { grip = value; }
    }

}


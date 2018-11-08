using System;
using System.Collections.Generic;
using System.Text;


public abstract class Tyre
{
    private string name;
    private double hardness;
    private double degradation;

    protected Tyre(string name, double hardness)
    {
        this.Name = name;
        this.Hardness = hardness;
        this.Degradation = 100;
    }

    public virtual double Degradation
    {
        get { return degradation; }
        set
        {
            if(value < 0)
            {
                throw new ArgumentException("Blown Tyre");
            }
            degradation = value;
        }
    }

    public double Hardness
    {
        get { return hardness; }
        set { hardness = value; }
    }


    public string Name
    {
        get { return name; }
        set { name = value; }
    }

}


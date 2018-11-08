using System;
using System.Collections.Generic;
using System.Text;


public abstract class Item
{
    private int weight;

    public Item(int weight)
    {
        this.Weight = weight;
    }

    public int Weight
    {
        get { return weight; }
        set { weight = value; }
    }

    public void AffectCharacter(Character character)
    {

    }

}


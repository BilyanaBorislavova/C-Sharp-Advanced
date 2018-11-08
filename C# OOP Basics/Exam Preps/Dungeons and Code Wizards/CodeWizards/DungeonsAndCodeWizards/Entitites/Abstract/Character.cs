using System;
using System.Collections.Generic;
using System.Text;


public abstract class Character
{
    private string name;
    private double baseHealth;
    private double health;
    private double baseArmour;
    private double armour;
    private double abilityPoints;
    private Bag bag;
    private Faction faction;
    private bool isAlive;
    private double restHealMultiplier;

    public Character(string name, double health, double armour, double abilityPoints, Bag bag, Faction faction)
    {
        this.Name = name;
        this.Health = health;
        this.Armour = armour;
        this.AbilityPoints = abilityPoints;
        this.Bag = bag;
        this.Faction = faction;
    }

    public double RestHealMultiplier
    {
        get { return restHealMultiplier; }
        set { restHealMultiplier = value; }
    }

    public bool IsAlive
    {
        get { return isAlive; }
        set { isAlive = value; }
    }


    public string Faction
    {
        get { return faction; }
        set { faction = value; }
    }


    public Bag Bag
    {
        get { return bag; }
        set { bag = value; }
    }


    public double AbilityPoints
    {
        get { return abilityPoints; }
        set { abilityPoints = value; }
    }


    public double Armour
    {
        get { return armour; }
        set { armour = value; }
    }


    public double BaseArmour
    {
        get { return baseArmour; }
        set { baseArmour = value; }
    }


    public double Health
    {
        get { return health; }
        set { health = value; }
    }
    public double BaseHealth
    {
        get { return baseHealth; }
        set { baseHealth = value; }
    }


    public string Name
    {
        get { return name; }
        set
        {
            if (String.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Name cannot be null or whitespace!");
            }
            name = value;
        }
    }

}


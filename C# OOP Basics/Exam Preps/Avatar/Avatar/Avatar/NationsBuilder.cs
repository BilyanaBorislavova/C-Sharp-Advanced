using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class NationsBuilder
{
    List<Bender> benders = new List<Bender>();
    List<Monument> monuments = new List<Monument>();

     public void AssignBender(List<string> benderArgs)
     {
        string type = benderArgs[0];
        string name = benderArgs[1];
        int power = int.Parse(benderArgs[2]);
        double secondaryParameter = double.Parse(benderArgs[3]);

        if(type == "Air")
        {
            AirBender airBender = new AirBender(name, power, secondaryParameter);
            benders.Add(airBender);
        }
        else if(type == "Water")
        {
            WaterBender waterBender = new WaterBender(name, power, secondaryParameter);
            benders.Add(waterBender);
        }
        else if(type == "Fire")
        {
            FireBender fireBender = new FireBender(name, power, secondaryParameter);
            benders.Add(fireBender);
        }
        else if(type == "Earth")
        {
            EarthBender earthBender = new EarthBender(name, power, secondaryParameter);
            benders.Add(earthBender);
        }
              
     }
     public void AssignMonument(List<string> monumentArgs)
     {
        string type = monumentArgs[0];
        string name = monumentArgs[1];
        int affinity = int.Parse(monumentArgs[2]);

        if(type == "Air")
        {
            AirMonument airMonument = new AirMonument(name, affinity);
            monuments.Add(airMonument);
        }
        else if(type == "Water")
        {
            WaterMonument waterMonument = new WaterMonument(name, affinity);
            monuments.Add(waterMonument);
        }
        else if(type == "Fire")
        {
            FireMonument fireMonument = new FireMonument(name, affinity);
            monuments.Add(fireMonument);
        }
        else if(type == "Earth")
        {
            EarthMonument earthMonument = new EarthMonument(name, affinity);
            monuments.Add(earthMonument);
        }
     }
     public string GetStatus(string nationsType)
     {
        Console.WriteLine($"{nationsType} Nation");
        if (nationsType == "Air")
        {
            if (benders.Where(a => a.GetType().Name == "AirBender").Count() == 0)
            {
                Console.WriteLine("Benders: None");
            }
            else
            {
                Console.WriteLine("Benders:");
                foreach (var b in benders.Where(a => a.GetType().Name == "AirBender"))
                {
                    Console.WriteLine(b.ToString());
                }
            }

            if(monuments.Where(a => a.GetType().Name == "AirMonument").Count() == 0)
            {
                Console.WriteLine("Monuments: None");
            }
            else
            {
                Console.WriteLine("Monuments:");
                foreach (var m in monuments.Where(a => a.GetType().Name == "AirMonument"))
                {
                    Console.WriteLine(m.ToString());
                }
            }
        }
        else if(nationsType == "Water")
        {
            if (benders.Where(a => a.GetType().Name == "WaterBender").Count() == 0)
            {
                Console.WriteLine("Benders: None");
            }
            else
            {
                Console.WriteLine("Benders:");
                foreach (var b in benders.Where(a => a.GetType().Name == "WaterBender"))
                {
                    Console.WriteLine(b.ToString());
                }
            }

            if (monuments.Where(a => a.GetType().Name == "WaterMonument").Count() == 0)
            {
                Console.WriteLine("Monuments: None");
            }
            else
            {
                Console.WriteLine("Monuments:");
                foreach (var m in monuments.Where(a => a.GetType().Name == "WaterMonument"))
                {
                    Console.WriteLine(m.ToString());
                }
            }
        }
        else if(nationsType == "Fire")
        {
            if (benders.Where(a => a.GetType().Name == "FireBender").Count() == 0)
            {
                Console.WriteLine("Benders: None");
            }
            else
            {
                Console.WriteLine("Benders:");
                foreach (var b in benders.Where(a => a.GetType().Name == "FireBender"))
                {
                    Console.WriteLine(b.ToString());
                }
            }

            if (monuments.Where(a => a.GetType().Name == "FireMonument").Count() == 0)
            {
                Console.WriteLine("Monuments: None");
            }
            else
            {
                Console.WriteLine("Monuments:");
                foreach (var m in monuments.Where(a => a.GetType().Name == "FireMonument"))
                {
                    Console.WriteLine(m.ToString());
                }
            }
        }
        else if(nationsType == "Earth")
        {
            if (benders.Where(a => a.GetType().Name == "EarthBender").Count() == 0)
            {
                Console.WriteLine("Benders: None");
            }
            else
            {
                Console.WriteLine("Benders:");
                foreach (var b in benders.Where(a => a.GetType().Name == "EarthBender"))
                {
                    Console.WriteLine(b.ToString());
                }
            }

            if (monuments.Where(a => a.GetType().Name == "EarthMonument").Count() == 0)
            {
                Console.WriteLine("Monuments: None");
            }
            else
            {
                Console.WriteLine("Monuments:");
                foreach (var m in monuments.Where(a => a.GetType().Name == "EarthMonument"))
                {
                    Console.WriteLine(m.ToString());
                }
            }
        }
        return "";
     }
     public void IssueWar(string nationsType)
     {
       
     }
     public string GetWarsRecord()
     {
        //TODO: Add some logic here … 
        return "";
     }

}
    

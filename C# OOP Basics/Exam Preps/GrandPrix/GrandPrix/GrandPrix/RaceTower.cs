using System;
using System.Collections.Generic;
using System.Text;


public class RaceTower
{
    List<Driver> drivers = new List<Driver>();
    public Track Track { get; set; }

    public void SetTrackInfo(int lapsNumber, int trackLength)
    {
        this.Track = new Track(lapsNumber, trackLength);
    }
    public void RegisterDriver(List<string> commandArgs)
    {
        try
        {
            string type = commandArgs[0];
            string name = commandArgs[1];
            int hp = int.Parse(commandArgs[2]);
            double fuelAmount = double.Parse(commandArgs[3]);
            string tyreType = commandArgs[4];
            double tyreHardness = double.Parse(commandArgs[5]);
           
            if (commandArgs.Count == 6)
            {
                Tyre hardTyre = new HardTyre(tyreHardness);
                Car car = new Car(hp, fuelAmount, hardTyre);

                if (type == "Aggressive")
                {
                    Driver aggressiveDriver = new AggressiveDriver(name, car);
                    drivers.Add(aggressiveDriver);
                }
                else if (type == "Endurance")
                {
                    Driver enduranceDriver = new EnduranceDriver(name, car);
                    drivers.Add(enduranceDriver); 
                }
            }
            else if (commandArgs.Count == 7)
            {
                double grip = double.Parse(commandArgs[6]);

                Tyre ultraSoftTyre = new UltrasoftTyre(tyreHardness, grip);
                Car car = new Car(hp, fuelAmount, ultraSoftTyre);

                if (type == "Aggressive")
                {
                    Driver aggressiveDriver = new AggressiveDriver(name, car);
                    drivers.Add(aggressiveDriver);
                }
                else if (type == "Endurance")
                {
                    Driver enduranceDriver = new EnduranceDriver(name, car);
                    drivers.Add(enduranceDriver);
                }
            }
        }
        catch (Exception e)
        {
            // FAK U 
        }
    }

    public void DriverBoxes(List<string> commandArgs)
    {
        //TODO: Add some logic here …
    }

    public string CompleteLaps(List<string> commandArgs)
    {
        int lap = int.Parse(commandArgs[1]);

        foreach (var driver in drivers)
        {

        }
        return "";
    }

    public string GetLeaderboard()
    {
        //TODO: Add some logic here …
        return "";
    }

    public void ChangeWeather(List<string> commandArgs)
    {
        string weather = commandArgs[1];
        if(weather == "Rainy" || weather == "Foggy" || weather == "Sunny")
        {
            this.Track.Weather = weather;   
        }
    }
}



using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _04._Movie_Time
{
    class MovieTime
    {
        static void Main(string[] args)
        {
            string favouriteGenre = Console.ReadLine();

            string movieDuaration = Console.ReadLine();

            string input = Console.ReadLine();

            Dictionary<string, Dictionary<string, TimeSpan>> moviesDict = new Dictionary<string, Dictionary<string, TimeSpan>>();
            List<TimeSpan> totalTime = new List<TimeSpan>();

            while (input != "POPCORN!")
            {
                string[] movieInfo = input.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                string name = movieInfo[0];
                string genre = movieInfo[1];
                TimeSpan duration = TimeSpan.ParseExact(movieInfo[2], @"hh\:mm\:ss", CultureInfo.InvariantCulture);

                if(!moviesDict.ContainsKey(genre))
                {
                    moviesDict.Add(genre, new Dictionary<string, TimeSpan>());
                }

                moviesDict[genre].Add(name, duration);
                totalTime.Add(duration);

                input = Console.ReadLine();
            }

            string noYes = Console.ReadLine();
            int counter = 1;

            while (noYes != "Yes")
            {
                counter++;
                noYes = Console.ReadLine();
            }

            string movieToWatch = "";
            string movieDuration = "";

            if(movieDuaration == "Long")
            {
                foreach (var movie in moviesDict[favouriteGenre].OrderByDescending(a => a.Value).ThenBy(a => a.Key).Take(counter))
                {
                    Console.WriteLine(movie.Key);
                    movieToWatch = movie.Key;
                    movieDuration = movie.Value.ToString();
                }
            }
            else
            {
                foreach (var movie in moviesDict[favouriteGenre].OrderBy(a => a.Value).ThenBy(a => a.Key).Take(counter))
                {
                    Console.WriteLine(movie.Key);
                    movieToWatch = movie.Key;
                    movieDuration = movie.Value.ToString();
                }
            }
            TimeSpan totalSpan = new TimeSpan(totalTime.Sum(r => r.Ticks));

            Console.WriteLine($"We're watching {movieToWatch} - {movieDuration}");
            Console.WriteLine($"Total Playlist Duration: {totalSpan}");
        }
    }
}

using OnlineRadioDatabase.Exceptions;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace OnlineRadioDatabase.Core
{
    public class Engine
    {
        public void Run()
        {
            int numOfSongsToAdd = int.Parse(Console.ReadLine());
            Songs songs = new Songs();
            List<TimeSpan> totalTime = new List<TimeSpan>();

            for (int i = 0; i < numOfSongsToAdd; i++)
            {
                string[] info = Console.ReadLine().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                try
                {
                    if(info.Length != 3)
                    {
                        throw new InvalidSongException();
                    }

                    string artist = info[0];
                    string songName = info[1];
                    string[] length = info[2].Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);

                    if(!Char.IsDigit(length[0][0]) || ! Char.IsDigit(length[1][0]))
                    {
                        throw new InvalidSongLengthException();
                    }

                    int minutes = int.Parse(length[0]);
                    int seconds = int.Parse(length[1]);

                    Song song = new Song(artist, songName, minutes, seconds);
                    songs.SongsPlaylist.Add(song);

                    if (length[0].Length == 1 && length[1].Length == 1)
                    {
                        TimeSpan duration = TimeSpan.ParseExact(info[2], @"m\:s", CultureInfo.InvariantCulture);
                        totalTime.Add(duration);
                    }
                    else if(length[0].Length == 2 && length[1].Length == 2)
                    {
                        TimeSpan duration = TimeSpan.ParseExact(info[2], @"mm\:ss", CultureInfo.InvariantCulture);
                        totalTime.Add(duration);
                    }
                    else if(length[0].Length == 1 && length[1].Length == 2)
                    {
                        TimeSpan duration = TimeSpan.ParseExact(info[2], @"m\:ss", CultureInfo.InvariantCulture);
                        totalTime.Add(duration);
                    }
                    else if(length[0].Length == 2 && length[1].Length == 1)
                    {
                        TimeSpan duration = TimeSpan.ParseExact(info[2], @"mm\:s", CultureInfo.InvariantCulture);
                        totalTime.Add(duration);
                    }
                    Console.WriteLine("Song added.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            TimeSpan totalSpan = new TimeSpan(totalTime.Sum(r => r.Ticks));

            Console.WriteLine($"Songs added: {songs.SongsPlaylist.Count}");
            Console.WriteLine($"Playlist length: {totalSpan.Hours}h {totalSpan.Minutes}m {totalSpan.Seconds}s");
        }
    }
}

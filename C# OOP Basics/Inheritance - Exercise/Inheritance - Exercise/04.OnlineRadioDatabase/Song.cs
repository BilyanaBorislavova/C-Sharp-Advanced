using OnlineRadioDatabase.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineRadioDatabase
{
    public class Song
    {
        private string artist;
        private string songName;
        private int minutes;
        private int seconds;

        public Song(string artist, string songName, int minutes, int seconds)
        {
            this.Artist = artist;
            this.SongName = songName;
            this.Minutes = minutes;
            this.Seconds = seconds;
        }

        public string Artist
        {
            get => this.artist;
            set
            {
                if(value.Length < 3 || value.Length > 20)
                {
                    throw new InvalidArtistNameException();
                }
                this.artist = value;
            }
        }

        public string SongName
        {
            get => this.songName;
            set
            {
                if(value.Length < 3 || value.Length > 30)
                {
                    throw new InvalidSongNameException();
                }
                this.songName = value;
            }
        }

        public int Minutes
        {
            get => this.minutes;
            set
            {
                if(value < 0 || value > 14)
                {
                    throw new InvalidSongMinutesException();
                }
                this.minutes = value;
            }
        }

        public int Seconds
        {
            get => this.seconds;
            set
            {
                if(value < 0 || value > 59)
                {
                    throw new InvalidSongSecondsException();
                }
                this.seconds = value;
            }
        }
    }
}

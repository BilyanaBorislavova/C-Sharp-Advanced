using OnlineRadioDatabase.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineRadioDatabase
{
    public class Songs
    {
        private List<Song> songsPlaylist;

        public Songs()
        {
            this.SongsPlaylist = new List<Song>();
        }
        public List<Song> SongsPlaylist
        {
            get => this.songsPlaylist;
            set
            {
                this.songsPlaylist = value;
            }
        }
    }
}

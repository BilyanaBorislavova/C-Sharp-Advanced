using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineRadioDatabase.Exceptions
{
    public class InvalidSongMinutesException : InvalidSongException
    {
        public override string Message => "Song minutes should be between 0 and 14.";
    }
}

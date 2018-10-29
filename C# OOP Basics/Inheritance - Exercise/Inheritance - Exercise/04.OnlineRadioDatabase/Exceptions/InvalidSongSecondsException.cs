﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineRadioDatabase.Exceptions
{
    class InvalidSongSecondsException : InvalidSongException
    {
        public override string Message => "Song seconds should be between 0 and 59.";
    }
}

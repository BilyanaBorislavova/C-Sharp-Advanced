using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony
{
    public class Smartphone : ICall, IBrowse
    {
        public string Browse()
        {
            return "Browsing: ";
        }

        public string Call()
        {
            return "Calling... ";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Ferrari
{
    public interface IFerrari
    {
        string Model { get; set; }
        string Driver { get; set; }

        string PushBrakes();
        string GasPedal();

    }
}

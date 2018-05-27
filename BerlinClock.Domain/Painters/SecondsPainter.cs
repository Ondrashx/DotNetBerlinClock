using BerlinClock.Domain.Helpers;
using BerlinClock.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock.Domain.Converters
{
    class SecondsPainter : IClockPainter
    {
        public string Paint(int turnedOnLeds)
        {
            return turnedOnLeds == 0 ? Constants.Color.None : Constants.Color.Yellow;
        }
    }
}

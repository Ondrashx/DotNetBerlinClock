using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock.Interfaces
{
    public interface IClockPainter
    {
        /// <summary>
        /// Paints a row of the clock based on the number of lights that should be lighted.
        /// </summary>
        /// <param name="turnedOnLeds">Number of lights to be turned on</param>
        /// <returns>A string representation of the lights on/off</returns>
        string Paint(int turnedOnLeds);
    }
}

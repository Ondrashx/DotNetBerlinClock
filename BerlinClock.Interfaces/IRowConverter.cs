using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock.Interfaces
{
    public interface IRowConverter
    {
        /// <summary>
        /// Converts a TimeSpan into a number representing the leds to be turned on in a specific row of the clock.
        /// </summary>
        /// <param name="time">The time</param>
        /// <returns>Number of leds to be turned on</returns>
        int Convert(TimeSpan time);
    }
}

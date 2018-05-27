using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock.Interfaces
{
    public interface ITimeSpanParser
    {
        /// <summary>
        /// Parses a string time and gets a TimeSpan.
        /// </summary>
        /// <param name="time">time in the format HH:mm:ss</param>
        /// <returns></returns>
        TimeSpan Parse(string time);
    }
}

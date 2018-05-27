using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock.Interfaces
{
    public interface ITimeSpanCoverter
    {
        /// <summary>
        /// Get a painted string representation of a TimeSpan
        /// </summary>
        /// <returns></returns>
        string Print(TimeSpan time);
    }
}

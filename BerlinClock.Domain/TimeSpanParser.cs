using BerlinClock.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace BerlinClock.Domain
{
    public class TimeSpanParser: ITimeSpanParser
    {
        public TimeSpan Parse(string time)
        {
            return DateTime.ParseExact(time, "HH:mm:ss", CultureInfo.InvariantCulture).TimeOfDay;
            //return TimeSpan.Parse(time, CultureInfo);
        }
    }
}

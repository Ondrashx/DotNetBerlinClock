using BerlinClock.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock.Domain.Converters
{
    class SecondsConverter : IRowConverter
    {
        public int Convert(TimeSpan time)
        {
            // Light open when pair seconds
            return time.Seconds % 2 == 0 ?
                1 : 0;
        }
    }
}

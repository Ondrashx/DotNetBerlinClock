using BerlinClock.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock.Domain.Converters
{
    class BottomHoursConverter : IRowConverter
    {
        public int Convert(TimeSpan time)
        {
            return time.Hours % 5;
        }
    }
}

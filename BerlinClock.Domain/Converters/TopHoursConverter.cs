using BerlinClock.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock.Domain.Converters
{
    class TopHoursConverter : IRowConverter
    {
        public int Convert(TimeSpan time)
        {
            return (int)Math.Floor((double)(time.Hours / 5));
        }
    }
}

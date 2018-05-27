using BerlinClock.Domain.Helpers;
using BerlinClock.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock.Domain.Converters
{
    class BottomMinutesPainter : IClockPainter
    {
        private static readonly int TotalLeds = 4;
        public string Paint(int turnedOnLeds)
        {
            var lights = Enumerable.Range(0, TotalLeds)
                .Select(pos => pos < turnedOnLeds ? Constants.Color.Yellow : Constants.Color.None);
            return string.Join("", lights);
        }
    }
}

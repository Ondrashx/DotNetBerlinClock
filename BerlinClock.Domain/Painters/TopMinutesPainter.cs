using BerlinClock.Domain.Helpers;
using BerlinClock.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock.Domain.Converters
{
    class TopMinutesPainter : IClockPainter
    {
        private static readonly int TotalLeds = 11;
        public string Paint(int turnedOnLeds)
        {
            var lights = Enumerable.Range(0, TotalLeds)
                .Select(pos => { 
                    if (pos < turnedOnLeds) {
                        // every 3rd light (15 min) there is a red light
                        if (pos % 3 == 2) return Constants.Color.Red;
                        return Constants.Color.Yellow;
                    } else {
                        return Constants.Color.None;
                    }
                });
            return string.Join("", lights);
        }
    }
}

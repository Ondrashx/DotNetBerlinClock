using BerlinClock.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BerlinClock.Domain
{
    public class TimeConverter : ITimeConverter
    {
        private ITimeSpanCoverter berlinClock;
        private ITimeSpanParser timeSpanParser;
        public TimeConverter(
            ITimeSpanCoverter berlinClock,
            ITimeSpanParser timeSpanParser)
        {
            this.berlinClock = berlinClock;
            this.timeSpanParser = timeSpanParser;
        }

        public string convertTime(string aTime)
        {
            // convert the string Time to TimeSpan
            var time = this.timeSpanParser.Parse(aTime);

            // use the berlinClock
            return this.berlinClock.Print(time);
        }
    }
}

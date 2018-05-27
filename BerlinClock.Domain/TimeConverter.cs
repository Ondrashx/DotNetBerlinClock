using BerlinClock.Domain.Helpers;
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
        private SpecialConverterFactory specialConverterFactory;
        public TimeConverter(
            ITimeSpanCoverter berlinClock,
            ITimeSpanParser timeSpanParser)
        {
            this.berlinClock = berlinClock;
            this.timeSpanParser = timeSpanParser;
            specialConverterFactory = new SpecialConverterFactory();
        }

        public string ConvertTime(string aTime)
        {
            var specialCoverter = specialConverterFactory.Create(aTime);
            if (specialCoverter != null)
            {
                return specialCoverter.ConvertTime(aTime);
            }

            return ConvertNormalTime(aTime);
        }

        private string ConvertNormalTime(string aTime) {
            // convert the string Time to TimeSpan
            var time = this.timeSpanParser.Parse(aTime);

            // use the berlinClock
            return this.berlinClock.Print(time);
        }
        
    }
}

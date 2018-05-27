using BerlinClock.Domain.Converters;
using BerlinClock.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock.Domain
{
    class BerlinClock : ITimeSpanCoverter
    {
        private IEnumerable<ITimeSpanCoverter> clockRows;

        public BerlinClock(IEnumerable<ITimeSpanCoverter> clockRows)
        {
            this.clockRows = clockRows;
        }


        public string Print(TimeSpan time)
        {
            var paintedClockRows = clockRows
                .Select(clockRow => clockRow.Print(time));

            // Append a line per every painted row
            return string.Join(Environment.NewLine, paintedClockRows);
        }
    }
}

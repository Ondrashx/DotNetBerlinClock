using BerlinClock.Domain.Converters;
using BerlinClock.Interfaces;
using BerlinClock.Interfaces.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock.Domain
{
    public class BerlinClockFactory : IBerlinClockFactory
    {
        public ITimeSpanCoverter Create()
        {
            // create the row converters
            var clockRows = new List<RowConverter>() {
                new RowConverter(new SecondsConverter(), new SecondsPainter()),
                new RowConverter(new TopHoursConverter(), new TopHoursPainter()),
                new RowConverter(new BottomHoursConverter(), new BottomHoursPainter()),
                new RowConverter(new TopMinutesConverter(), new TopMinutesPainter()),
                new RowConverter(new BottomMinutesConverter(), new BottomMinutesPainter()),
            };

            return new BerlinClock(clockRows.AsReadOnly());
        }
    }
}

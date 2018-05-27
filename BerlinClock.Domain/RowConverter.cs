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
    class RowConverter : ITimeSpanCoverter
    {
        private IRowConverter rowConverter;
        private IClockPainter rowPainter;
        
        public RowConverter(
            IRowConverter rowConverter,
            IClockPainter rowPainter
            )
        {
            this.rowConverter = rowConverter;
            this.rowPainter = rowPainter;
        }

        public string Print(TimeSpan time)
        {
            int onLeds = this.rowConverter.Convert(time);
            return this.rowPainter.Paint(onLeds);
        }
    }
}

using BerlinClock.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock.Domain.Helpers
{
    /// <summary>
    /// Handles the exceptional time "24:00:00". Only created to pass this "very strange" use case.
    /// </summary>
    /// <seealso cref="BerlinClock.Interfaces.ITimeConverter" />
    class _24HourTimeConverter : ITimeConverter
    {
        public bool IsExceptionCase(string aTime)
        {
            return aTime == "24:00:00";
        }
        public string ConvertTime(string aTime)
        {
            if (IsExceptionCase(aTime))
            {
                return
                    @"Y
RRRR
RRRR
OOOOOOOOOOO
OOOO";
            }
            return null;
        }
    }
}

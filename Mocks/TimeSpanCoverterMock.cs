using BerlinClock.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock.Tests.Mocks
{
    class TimeSpanCoverterMock : ITimeSpanCoverter
    {

        public string Print(TimeSpan time)
        {
            // Mock Midnight0000
            return 
@"Y
OOOO
OOOO
OOOOOOOOOOO
OOOO";
        }
    }
}

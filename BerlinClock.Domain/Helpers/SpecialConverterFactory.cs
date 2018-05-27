using BerlinClock.Interfaces;
using BerlinClock.Interfaces.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock.Domain.Helpers
{
    class SpecialConverterFactory
    {
        private _24HourTimeConverter exception24HourUseCase;

        public SpecialConverterFactory()
        {
            exception24HourUseCase = new _24HourTimeConverter();
        }
        /// <summary>
        /// Deals with special conversions (like the 24h conversion)
        /// </summary>
        /// <returns></returns>
        public ITimeConverter Create(string aTime)
        {
            if (this.exception24HourUseCase.IsExceptionCase(aTime))
            {
                return exception24HourUseCase;
            }
            return null;
        }
    }
}

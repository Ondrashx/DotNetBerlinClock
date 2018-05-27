using BerlinClock.Domain;
using BerlinClock.Domain.Converters;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock.Tests.UnitTests
{
    [TestClass]
    public class TimeSpanParserTests
    {
        private TimeSpanParser timeSpanParser;
        public TimeSpanParserTests()
        {
            this.timeSpanParser = new TimeSpanParser();
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void ConvertInvalidFormat_ExpectsAnException_NotTimeString()
        {
            // Arrange
            var sTime = "24:00:01";

            // Act
            var result = this.timeSpanParser.Parse(sTime);

            // Assert
            // Expected exception
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void ConvertInvalidFormat_ExpectsAnException_InvalidTime()
        {
            // Arrange
            var sTime = "AAAABBBB";

            // Act
            var result = this.timeSpanParser.Parse(sTime);

            // Assert
            // Expected exception
        }

    }
}

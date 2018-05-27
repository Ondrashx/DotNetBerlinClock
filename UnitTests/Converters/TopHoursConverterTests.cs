using BerlinClock.Domain.Converters;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock.Tests.UnitTests.Converters
{
    [TestClass]
    public class TopHoursConverterTests
    {
        private TopHoursConverter converter;
        public TopHoursConverterTests()
        {
            this.converter = new TopHoursConverter();
        }
        
        [TestMethod]
        public void TopHoursConverter_AllLedsOpen()
        {
            // Arrange
            var time = new TimeSpan(21, 0, 0);
            var expected = 4;

            // Act
            var result = converter.Convert(time);

            // Assert
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TopHoursConverter_AllLedsClosed()
        {
            // Arrange
            var time = new TimeSpan(0, 0, 0);
            var expected = 0;

            // Act
            var result = converter.Convert(time);

            // Assert
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TopHoursConverter_HalfOpen()
        {
            // Arrange
            var time = new TimeSpan(14, 0, 0);
            var expected = 2;

            // Act
            var result = converter.Convert(time);

            // Assert
            Assert.AreEqual(result, expected);
        }
    }
}

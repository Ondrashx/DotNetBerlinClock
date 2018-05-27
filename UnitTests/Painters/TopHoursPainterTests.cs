using BerlinClock.Domain.Converters;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock.Tests.UnitTests.Painters
{
    [TestClass]
    public class PainterTests
    {
        private TopHoursPainter painter;
        public PainterTests()
        {
            this.painter = new TopHoursPainter();
        }
        
        [TestMethod]
        public void TopHoursPaiter_AllLedsOpen()
        {
            // Arrange
            var leds = 4;
            var expected = "RRRR";

            // Act
            var result = painter.Paint(leds);

            // Assert
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TopHoursPaiter_AllLedsClosed()
        {
            // Arrange
            var leds = 0;
            var expected = "OOOO";

            // Act
            var result = painter.Paint(leds);

            // Assert
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TopHoursPaiter_HalfOpen()
        {
            // Arrange
            var leds = 2;
            var expected = "RROO";

            // Act
            var result = painter.Paint(leds);

            // Assert
            Assert.AreEqual(result, expected);
        }
    }
}

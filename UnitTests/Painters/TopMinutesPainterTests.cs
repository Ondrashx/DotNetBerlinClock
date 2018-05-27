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
    public class TopMinutesPainterTests
    {
        private TopMinutesPainter painter;
        public TopMinutesPainterTests()
        {
            this.painter = new TopMinutesPainter();
        }

        [TestMethod]
        public void TopMinutesPaiter_AllLedsOpen()
        {
            // Arrange
            var leds = 11;
            var expected = "YYRYYRYYRYY";

            // Act
            var result = painter.Paint(leds);

            // Assert
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TopMinutesPaiter_AllLedsClosed()
        {
            // Arrange
            var leds = 0;
            var expected = "OOOOOOOOOOO";

            // Act
            var result = painter.Paint(leds);

            // Assert
            Assert.AreEqual(result, expected);
        }
    }
}

using System;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using BerlinClock.Interfaces;
using BerlinClock.Domain;
using BerlinClock.Tests.Mocks;

namespace BerlinClock
{
    [Binding]
    public class TheBerlinClockSteps
    {
        private ITimeConverter berlinClock;
        private String theTime;

        public TheBerlinClockSteps() {
            berlinClock = new TimeConverter(
                //new TimeSpanCoverterMock(),
                new BerlinClockFactory().Create(), 
                new TimeSpanParser()
            );
        }

        
        [When(@"the time is ""(.*)""")]
        public void WhenTheTimeIs(string time)
        {
            theTime = time;
        }
        
        [Then(@"the clock should look like")]
        public void ThenTheClockShouldLookLike(string theExpectedBerlinClockOutput)
        {
            Assert.AreEqual(berlinClock.convertTime(theTime), theExpectedBerlinClockOutput);
        }

    }
}

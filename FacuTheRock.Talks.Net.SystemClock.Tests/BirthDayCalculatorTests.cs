using FacuTheRock.Talks.Net.SystemClock.API.Services;
using System;
using Xunit;

namespace FacuTheRock.Talks.Net.SystemClock.Tests
{
    public class BirthDayCalculatorTests
    {
        [Fact]
        public void CalculateNumberOfDays()
        {
            // Arrange
            var desiredDay = new DateTime(2021, 5, 26, 10, 0, 0);
            var fakeSystemClock = new FakeSystemClock(desiredDay);
            var sut = new BirthDayCalculator(fakeSystemClock);

            // Act
            var actualDays = sut.CalculateNextBirthDayInDays(
                month: 3,
                day: 13);

            // Assert
            Assert.Equal(290, actualDays);
        }
    }
}

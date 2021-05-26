using Microsoft.AspNetCore.Authentication;
using System;

namespace FacuTheRock.Talks.Net.SystemClock.Tests
{
    public class FakeSystemClock : ISystemClock
    {
        private readonly DateTime _desiredDay;

        public FakeSystemClock(DateTime desiredDay)
        {
            _desiredDay = desiredDay;
        }

        public DateTimeOffset UtcNow => _desiredDay;
    }
}

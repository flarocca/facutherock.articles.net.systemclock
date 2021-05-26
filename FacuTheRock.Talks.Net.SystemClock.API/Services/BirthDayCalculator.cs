using Microsoft.AspNetCore.Authentication;
using System;

namespace FacuTheRock.Talks.Net.SystemClock.API.Services
{
    public class BirthDayCalculator
    {
        private readonly ISystemClock _systemClock;

        public BirthDayCalculator(ISystemClock systemClock)
        {
            _systemClock = systemClock;
        }

        public int CalculateNextBirthDayInDays(
            int month,
            int day)
        {
            var today = _systemClock.UtcNow;
            var birthDay = new DateTime(today.Year, month, day);

            if (birthDay < today)
                birthDay = birthDay.AddYears(1);

            return (int)(birthDay - today).TotalDays;
        }
    }
}

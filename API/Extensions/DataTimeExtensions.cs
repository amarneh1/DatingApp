using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Extensions
{
    public static class DateTimeExtensions
    {
        public static int CalculateAge(this DateOnly dob)
        {
            // var today = DateOnly.FromDateTime(DateTime.Now);

            // var age = today.Year - dob.Year;

            // if (dob > today.AddYears(-age)) age--;

            // return age;

            var today = DateOnly.FromDateTime(DateTime.UtcNow);

            // Calculate the initial age in years
            var years = today.Year - dob.Year;

            // Adjust the age if the birth date has not occurred yet this year
            if (dob > today.AddYears(-years))
                years--;

            // Calculate the months and days
            var pastBirthdayThisYear = dob.AddYears(years);
            var months = today.Month - pastBirthdayThisYear.Month;
            if (months < 0)
            {
                months += 12;
                years--;
            }

            var days = today.Day - pastBirthdayThisYear.Day;
            if (days < 0)
            {
                var previousMonth = today.AddMonths(-1).Month;
                days += DateTime.DaysInMonth(today.Year, previousMonth);
                months--;
                if (months < 0)
                {
                    months += 12;
                    years--;
                }
            }

            // return (years, months, days);
            return (years);
        }
    }
}
using System;
namespace AOC.Domain.Models
{
    public class AvailableDay
    {
        public AvailableDay(int day)
        {
            this.Day = day;
        }

        public int Day { get; set; }

        public bool Part1Complete { get; set; }

        public bool Part2Complete { get; set; }
    }
}

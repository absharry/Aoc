using System;
using System.Collections.Generic;

namespace AOC.Domain.Models
{
    public class AvailableYear
    {
        public AvailableYear()
        {
            this.AvailableDays = new List<AvailableDay>();

            for (int i = 1; i < 26; i++)
            {
                this.AvailableDays.Add(new AvailableDay(i));
            }
        }

        public string Year { get; set; }
        public List<AvailableDay> AvailableDays { get; set; }
    }
}

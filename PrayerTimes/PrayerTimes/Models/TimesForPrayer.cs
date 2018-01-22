using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrayerTimes.Models
{
    public class TimesForPrayer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double PrayerTime { get; set; }
        public DateTime CurrentDate { get; set; }
        public DateTime CurrentTime { get; set; }

    }
}
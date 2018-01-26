using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrayerTimes.Models
{
    public class Ramadan
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string  Description { get; set; }
    }
}
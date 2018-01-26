using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrayerTimes.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DOB { get; set; }
        public string Phone { get; set; }
        public List<Hajj> Hajjs { get; set; }

        public List<Dua> Duas { get; set; }
    }
}
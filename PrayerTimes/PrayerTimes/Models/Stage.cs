using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrayerTimes.Models
{
    public class Stage
    {
        public int Id { get; set; }
        public string StageName { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
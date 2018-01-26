using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrayerTimes.Models
{
    public class Dua
    {
        public int Id { get; set; }

        public string DuaName { get; set; }

        public string DuaDescription { get; set; }

        
        public List<User> Users { get; set; }
    }
}
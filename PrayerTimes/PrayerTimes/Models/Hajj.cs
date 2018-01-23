using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrayerTimes.Models
{
    public class Hajj
    {
        public int Id { get; set; }
        public List<User> Users { get; set; }
        //public int MyProperty { get; set; }
    }
}
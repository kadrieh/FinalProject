using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PrayerTimes.Models
{
    public class TimesForPrayer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double PrayerTime { get; set; }
        //public DateTime CurrentDate { get; set; }
        public DateTime _currentTime { get; set; }
        private DateTime _returnDate = DateTime.MinValue;

        public string Date
        {
            get
            {
                return ReturnDate.ToString("d");
            }
        }

        public string Time
        {
            get
            {
                return ReturnDate.ToShortTimeString();
            }
        }
        public DateTime ReturnDate
        {
            get => (_returnDate == DateTime.MinValue) ? DateTime.Now : _returnDate;
            set { _returnDate = value; }
        }

    }
}
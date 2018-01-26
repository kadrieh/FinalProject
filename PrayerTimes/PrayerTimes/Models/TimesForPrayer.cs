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

        [Display(Name = "Prayer Name")]
        public string PrayerName { get; set; }

        [Display(Name = "Prayer Time")]
        public double PrayerTime { get; set; }

        //public DateTime CurrentDate { get; set; }
        [Display(Name = "Time")]
        public DateTime _currentTime { get; set; }

        [Display(Name ="Date")]
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
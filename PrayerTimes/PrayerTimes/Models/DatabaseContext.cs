using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PrayerTimes.Models
{
    public class DatabaseContext : DbContext
    {
        //public DatabaseContext() : base("name=MyDbConnection")
        //{
        //}

        public DbSet<TimesForPrayer> TimeForPrayers { get; set; }
        public DbSet<Stage> Stages { get; set; }
        public DbSet<Comment> Comments { get; set; }
        //public System.Data.Entity.DbSet<DotNetAppSqlDb.Models.Todo> Todoes { get; set; }

        public DatabaseContext()
            : base("name=DefaultConnection")
        { }
        
    }

}
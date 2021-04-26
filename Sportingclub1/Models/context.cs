using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;

namespace Sportingclub1.Models
{
    public class context : DbContext
    {
        public context() : base("name=SportingClub")
        {
        }
        public DbSet<Trainers> trainers { get; set; }
        public DbSet<trainees> trainees { get; set; }
        public DbSet<Sports> sports { get; set; }
        public DbSet<Account> Accounts { get; set; }
    }
}

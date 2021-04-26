using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sportingclub1.Models
{
    public class Trainers
    {
        [Key]
        public int ID
        {
            get; set;
        }
        public string name { get; set; }
        public string gender { get; set; }
        public double salary { get; set; }
        public int age { get; set; }
        public virtual Sports sport { set; get; }

        public virtual ICollection<trainees> Trainees { set; get; }
        public string Email { get; set; }
    }
}
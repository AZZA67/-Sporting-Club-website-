using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sportingclub1.Models
{
    public class Sports
    {
        [Key]
        public string ID { get; set;  }
        public string name { get; set;  }
        public virtual ICollection<trainees> Trainees { set; get; }
        public virtual ICollection<Trainers> Trainers{ set; get; }
       

    }
}
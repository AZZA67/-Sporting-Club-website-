using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Security.Cryptography;
using System.Web.Mvc;
using CompareAttribute = System.ComponentModel.DataAnnotations.CompareAttribute;

namespace Sportingclub1.Models
{
    public class trainees
    {
        [Key]
       public int ID
        {
            get; set;
        }

        [Required(ErrorMessage ="This Is Required Item")]
        [Display(Name ="Name")]
         public string name { get; set; }
        [Required(ErrorMessage = "This Is Required Item")]
        [Display(Name = "Gender")]
        public string gender {get; set; }

        [Required(ErrorMessage = "This Is Required Item")]
        [Display(Name = "Age")]
        public int age  { get; set; }
        [Required(ErrorMessage = "This Is Required Item")]
        [DataType(DataType.EmailAddress)]

        public string Email{ get; set; }
        [Required(ErrorMessage = "This Is Required Item")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Compare("Password")]
        [Required(ErrorMessage = "This Is Required Item")]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }
        //[Required(ErrorMessage = "This Is Required Item")]
        [Display(Name = "Sport Name")]
        public string Sport_Name  { get; set; }
        public enum sports {
            BasketBall,
            football,
            Swimming,
            Tennis,
            VolleyBall};
        [Display(Name = "Trainig Date")]
        public string Training_Date { get; set; }
        public virtual Sports sport{ set; get; }
         public virtual Trainers trainer { set; get; }
    }
}

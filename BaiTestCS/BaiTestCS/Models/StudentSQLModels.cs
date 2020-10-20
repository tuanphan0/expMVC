using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BaiTestCS.Models
{
    public class StudentSQLModels
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Get FullName")]
        [Display(Name = "FullName:")]
        public string FullName { get; set; }
        [Required(ErrorMessage = "Get Address")]
        [Display(Name = "Address:")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Get BirthDay")]
        [Display(Name = "BirthDay:")]
        public string BirthDay { get; set; }
        [Required(ErrorMessage = "Get Gender")]
        [Display(Name = "Gender:")]
        public string Gender { get; set; }

       
    }
}
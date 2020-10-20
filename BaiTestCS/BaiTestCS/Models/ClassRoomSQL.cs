using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BaiTestCS.Models
{
    public class ClassRoomSQL
    {
        public int IDKhoa { get; set; }

        [Required(ErrorMessage = "Get NameClass")]
        [Display(Name = "Name Class:")]
        public string NameClass { get; set; }

        [Required(ErrorMessage = "Get Room")]
        [Display(Name = "Name Room:")]
        public string Room { get; set; }
    }
}
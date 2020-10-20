using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BaiTestCS.Areas.Admin.Data
{
    public class LoginModels
    {
        [Required(ErrorMessage ="Moi Nhap Lai TK")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Moi Nhap Lai MK")]
        public string PassWord { get; set; }

        public string RememberMe { get; set; }
    }
}
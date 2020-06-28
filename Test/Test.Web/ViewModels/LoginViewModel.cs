using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Test.Web.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name="用户名")]
        public string UserName { get; set; }
        [Required]
        [Display(Name="密码")]
        public string Password { get; set; }
    }
}

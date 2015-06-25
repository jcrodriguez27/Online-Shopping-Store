using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineShoppingStore.WebUI.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage="Username Is Required.")]
        public string UserName { get; set; }
        [Required(ErrorMessage="Password Is Required.")]
        [StringLength(50, MinimumLength = 5)]
        public string Password { get; set; }
    }
}
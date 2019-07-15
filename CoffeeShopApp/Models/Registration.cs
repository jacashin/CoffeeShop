using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShopApp.Models
{
    public class Registration
    {
        [Required (ErrorMessage = "Please enter a name")]
        [MaxLength(24)]
        [MinLength(4)]
        public string UserName { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Please a valid email address")]
        public string email { get; set; }

        [Required]
        [MaxLength(24)]
        [MinLength(4)]
        public string Password { get; set; }

        [Required]
        [MaxLength(24)]
        [MinLength(4)]
        [Compare("Password")]
        public string Password2 { get; set; }
    }
}

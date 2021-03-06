using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FriendlyRS1.ViewModels
{
    public class ResendEmailVM
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}

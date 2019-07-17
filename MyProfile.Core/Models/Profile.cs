using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using MyShop.Core.Contracts;

namespace MyProfile.Core.Models
{
    public class Profile : BaseEntity
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [MaxLength(40, ErrorMessage = "Too Long")]
        public string PreferedName { get; set; }

        [Required(ErrorMessage = "Email address is required")]
        [EmailAddress]
        public string Email { get; set; }

        public string Image { get; set; }

        [MaxLength(300)]
        public string Description { get; set; }
        [STAThread]
        static void Main()
        {
        }
    }
}

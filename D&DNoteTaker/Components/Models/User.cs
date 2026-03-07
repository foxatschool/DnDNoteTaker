using D_DNoteTaker.Data;
using System.ComponentModel.DataAnnotations;

namespace D_DNoteTaker.Components.Models
{
    public class User : Document
    {
        [Required]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Usernames must be between 2 - 20 characters long")]
        public string UserName { get; set; }

        [Required]
        [StringLength(int.MaxValue, MinimumLength = 8, ErrorMessage = "Passwords must be at least 8 characters long")]
        public string Password { get; set; }

        public string[]? Campaigns { get; set; }
    }
}

using D_DNoteTaker.Data;
using System.ComponentModel.DataAnnotations;

namespace D_DNoteTaker.Components.Models
{
    public class User : Document
    {
        [Required (ErrorMessage = "You need a username")]
        public string UserName { get; set; }

        [Required (ErrorMessage = "You need a password")]
        public string Password { get; set; }
    }
}

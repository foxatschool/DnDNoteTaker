using D_DNoteTaker.Data.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace D_DNoteTaker.Components.Models
{
    public class User : IDocument
    {
        public string Id { get; set; }

        [Required (ErrorMessage = "You need a username")]
        public string UserName { get; set; }

        [Required (ErrorMessage = "You need a password")]
        public string Password { get; set; }
    }
}

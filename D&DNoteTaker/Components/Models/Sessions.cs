using D_DNoteTaker.Data;
using System.ComponentModel.DataAnnotations;

namespace D_DNoteTaker.Components.Models
{
    public class Sessions : Document
    {
        [Required]
        public int SessionNum { get; set; }

        [Required]
        public TextBox Summary { get; set; }

        [Required]
        public DateOnly DateOfSession { get; set; }

        public List<Location>? Locations { get; set; }

        public List<NPCs>? NPCs { get; set; }

    }
}

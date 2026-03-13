using D_DNoteTaker.Data;
using System.ComponentModel.DataAnnotations;

namespace D_DNoteTaker.Components.Models
{
    public class Sessions : Document
    {
        public string CampaginId { get; set; }
        [Required]
        public int SessionNum { get; set; }

        [Required]
        public TextBox Summary { get; set; }

        [Required]
        public DateOnly DateOfSession { get; set; }

        public List<Location>? Locations { get; set; } = new List<Location>();

        public List<NPCs>? NPCs { get; set; } = new List<NPCs>();

    }
}

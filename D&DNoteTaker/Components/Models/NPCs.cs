using System.ComponentModel.DataAnnotations;

namespace D_DNoteTaker.Components.Models
{
    public class NPCs
    {
        [Required]
        public string Name { get; set; }

        public TextBox? Description { get; set; }

        public string Gender { get; set; }

        [Required]
        public bool HasAids { get; set; }

        public int Age { get; set; }

        public string? JobType { get; set; }

        public string? Languages { get; set; }

    }
}

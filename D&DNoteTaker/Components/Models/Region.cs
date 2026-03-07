using D_DNoteTaker.Data;
using System.ComponentModel.DataAnnotations;

namespace D_DNoteTaker.Components.Models
{
    public class Region : Document
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public List<Location> Locations { get; set; }

        public TextBox Description { get; set; }
    }
}

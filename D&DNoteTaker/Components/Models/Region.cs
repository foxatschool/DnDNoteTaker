using D_DNoteTaker.Data;
using System.ComponentModel.DataAnnotations;

namespace D_DNoteTaker.Components.Models
{
    public class Region : Document
    {
        public string WorldBuildingId { get; set; }
        [Required]
        public string Name { get; set; }

        [Required]
        public List<Location> Locations { get; set; } = new List<Location>();

        public TextBox Description { get; set; } = new TextBox();
    }
}

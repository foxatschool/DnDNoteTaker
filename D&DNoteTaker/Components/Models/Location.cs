using D_DNoteTaker.Data;
using System.ComponentModel.DataAnnotations;

namespace D_DNoteTaker.Components.Models
{
    public class Location : Document
    {
        public string CampaginId { get; set; }
        public string RegionId { get; set; }
        [Required]
        public string Name { get; set; }

        [Required]
        public string Environment { get; set; }

        public List<string> POIs { get; set; } = new List<string> { };

        [Required]
        public string Climate { get; set; }

        public float? Population { get; set; }

        [Required]
        public TextBox Description { get; set; } = new TextBox();
    }
}

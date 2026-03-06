using D_DNoteTaker.Data;
using System.ComponentModel.DataAnnotations;

namespace D_DNoteTaker.Components.Models
{
    public class Worldbuilding : Document
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public TextBox History { get; set; }

        [Required]
        public List<Region> Regions { get; set; }
    }
}

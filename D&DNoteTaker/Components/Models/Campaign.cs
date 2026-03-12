using D_DNoteTaker.Data;
using System.ComponentModel.DataAnnotations;

namespace D_DNoteTaker.Components.Models
{
    public class Campaign : Document
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public List<string> DM { get; set; } = new List<string>();
        [Required]
        public List<string> Player { get; set; } = new List<string>();
        public List<TextBox>? Boxes { get; set; } = new List<TextBox>();

        [Required]
        public string WorldbuildingId { get; set; }

        [Required]
        public List<string> SessionIds {  get; set; }
    }
}

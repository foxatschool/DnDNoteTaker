using System.ComponentModel.DataAnnotations;

namespace D_DNoteTaker.Components.Models
{
    public class Campaign
    {
        [Required]
        string Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public List<string> DM { get; set; }
        [Required]
        public List<string> Player { get; set; }
        public List<TextBox>? Boxes { get; set; }
    }
}

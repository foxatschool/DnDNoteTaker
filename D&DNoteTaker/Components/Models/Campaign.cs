using System.ComponentModel.DataAnnotations;

namespace D_DNoteTaker.Components.Models
{
    public class Campaign
    {
        [Required]
        string Id { get; set; }

        [Required]
        string Name { get; set; }

        [Required]
        List<string> DM { get; set; }

        [Required]
        List<string> Player { get; set; }

        List<TextBox>? Boxes { get; set; }
    }
}

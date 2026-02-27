using System.ComponentModel.DataAnnotations;

namespace D_DNoteTaker.Components.Models
{
    public class Campaign
    {
        [Required]
        int Id { get; set; }
        [Required]
        string Name { get; set; }
        [Required]
        List<int> DM { get; set; }
        [Required]
        List<int> Player { get; set; }
        List<TextBox>? Boxes { get; set; }
    }
}

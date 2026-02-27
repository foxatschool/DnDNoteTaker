using System.ComponentModel.DataAnnotations;

namespace D_DNoteTaker.Components.Models
{
    public class Region
    {
        [Required]
        string Name { get; set; }
        [Required]
        List<Location> Regions { get; set; }
        TextBox? Description { get; set; }
    }
}

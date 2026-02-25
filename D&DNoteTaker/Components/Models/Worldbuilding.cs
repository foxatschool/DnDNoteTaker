using System.ComponentModel.DataAnnotations;

namespace D_DNoteTaker.Components.Models
{
    public class Worldbuilding
    {
        [Required]
        string Name { get; set; }
        [Required]
        TextBox History { get; set; }
        [Required]
        List<Region> Regions { get; set; }
    }
}

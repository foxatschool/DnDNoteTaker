using System.ComponentModel.DataAnnotations;

namespace D_DNoteTaker.Components.Models
{
    public class Location
    {
        [Required]
        string Name { get; set; }

        [Required]
        string Environment { get; set; }

        List<String>? POIs {  get; set; }

        [Required]
        string Climate { get; set; }

        float? Population { get; set; }

        [Required]
        TextBox Description { get; set; }
    }
}

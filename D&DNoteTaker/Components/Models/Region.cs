using D_DNoteTaker.Data;
using System.ComponentModel.DataAnnotations;

namespace D_DNoteTaker.Components.Models
{
    public class Region : Document
    {
        [Required]
        string Name { get; set; }

        [Required]
        List<Location> Locations { get; set; }

        TextBox Description { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace D_DNoteTaker.Components.Models
{
    public class Sessions
    {
        [Required]
        int SessionNum { get; set; }
        [Required]
        string Summary { get; set; }
        [Required]
        DateOnly DateOfSession { get; set; }
        List<Location>? Locations { get; set; }
        List<NPCs>? NPCs { get; set; }

    }
}

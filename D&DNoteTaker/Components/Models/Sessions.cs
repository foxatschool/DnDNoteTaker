using D_DNoteTaker.Data.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace D_DNoteTaker.Components.Models
{
    public class Sessions : IDocument
    {
        public string Id { get; set; }

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

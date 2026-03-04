using D_DNoteTaker.Data.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace D_DNoteTaker.Components.Models
{
    public class Region : IDocument
    {
        public string Id { get; set; }

        [Required]
        string Name { get; set; }

        [Required]
        List<Location> Regions { get; set; }

        TextBox? Description { get; set; }
    }
}

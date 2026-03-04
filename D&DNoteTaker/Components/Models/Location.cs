using D_DNoteTaker.Data.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace D_DNoteTaker.Components.Models
{
    public class Location : IDocument
    {
        public string Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Environment { get; set; }

        public List<String>? POIs {  get; set; }

        [Required]
        public string Climate { get; set; }

        public float? Population { get; set; }

        [Required]
        public TextBox Description { get; set; }
    }
}

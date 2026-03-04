using D_DNoteTaker.Data.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace D_DNoteTaker.Components.Models
{
    public class TextBox : IDocument
    {
        public string Id { get; set; }

        public string? name { get; set; }
        [Required]
        public string text { get; set; }

        public TextBox(string? name = null)
        {
            this.name = name;
            text = "";
        }
    }
}

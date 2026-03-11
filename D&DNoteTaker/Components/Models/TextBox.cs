using D_DNoteTaker.Data;
using System.ComponentModel.DataAnnotations;

namespace D_DNoteTaker.Components.Models
{
    public class TextBox : Document
    {
        public string? Name { get; set; }
        [Required]
        public string Text { get; set; }

        public TextBox(string? name = null)
        {
            this.Name = name;
            Text = "";
        }
    }
}

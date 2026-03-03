using System.ComponentModel.DataAnnotations;

namespace D_DNoteTaker.Components.Models
{
    public class TextBox
    {
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

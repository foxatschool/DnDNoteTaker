namespace D_DNoteTaker.Components.Models
{
    public class TextBox
    {
        string? name { get; set; }
        string text { get; set; }

        public TextBox(string? name = null)
        {
            this.name = name;
            text = "";
        }
    }
}

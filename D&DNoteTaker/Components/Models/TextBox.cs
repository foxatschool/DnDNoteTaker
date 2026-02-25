namespace D_DNoteTaker.Components.Models
{
    public class TextBox
    {
        string? name;
        string text;

        public TextBox(string? name = null)
        {
            this.name = name;
            text = "";
        }
    }
}

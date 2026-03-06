using D_DNoteTaker.Data;
using D_DNoteTaker.Data.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace D_DNoteTaker.Components.Objects
{
    public class Testing : Document
    {
        [Required (ErrorMessage = "Must have a name")]
        public string Name { get; set; }

        [Required, Range(0, int.MaxValue, ErrorMessage = "You must be at least born to use this site")]
        public int Age { get; set; }

        [Required (ErrorMessage = "You must either be dead or alive") ]
        public bool IsAlive { get; set; }
    }
}

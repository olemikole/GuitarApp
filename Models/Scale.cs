using System.Collections.Generic;

namespace GuitarApp.Models
{

    public class Scale
    {
        public List<Note.NoteEnum> ScaleNotes {get;set;}
        
        public string Name { get; set; }

        
    }
}
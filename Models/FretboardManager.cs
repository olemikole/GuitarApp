using System;
using System.Collections.Generic;
using GuitarApp.Models;

namespace GuitarApp.Models
{
    public class FretboardManager
    {
        const int NUMBER_OF_FRETS=12;
        public Note[,] AllNotes = new Note[Note.GuitarStrings.Length,NUMBER_OF_FRETS];
        public List<Note.NoteEnum> CurrentScale=new List<Note.NoteEnum>(){Note.NoteEnum.C};
        public Note.NoteEnum? CurrentKey=null;
        public int CurrentMode;
        public Note.NoteEnum CurrentChord;
        
        public FretboardManager()
        {

            for(int i = 0; i < 6; i++)
            {
                for(int j = 0; j < 12;j++)
                {
                    AllNotes[i,j]=new Note(j,i);
                }
            }
        }

   



        public void UpdateNotes()
        {
            List<Note.NoteEnum> scaleNotes = new List<Note.NoteEnum>();
            if(CurrentKey!=null)
            {
                Console.WriteLine("Yes");
                foreach(var note in CurrentScale)
                {
                    scaleNotes.Add( (Note.NoteEnum)(( (int) note + (int) CurrentKey + (12-(int)CurrentScale[CurrentMode]))%12) );
                } 
            }
            foreach(var note in AllNotes){
                
                if(scaleNotes.Contains(note.NoteValue))
                {
                    note.color = (note.NoteValue == CurrentKey) ? "red" : "#0066FF"; 
                    
                }
                else
                {
                    note.color="transparent";
                }
            }
        }
    }
}
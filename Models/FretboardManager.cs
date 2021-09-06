using System;
using System.Collections.Generic;
using GuitarApp.Models;

namespace GuitarApp.Models
{
    public class FretboardManager
    {
        
        public Note[,] allNotes = new Note[6,12];
        public List<Note.NoteEnum> currentScale=new List<Note.NoteEnum>(){Note.NoteEnum.C};
        public Note.NoteEnum? currentKey=null;
        public int currentMode;
        public Note.NoteEnum currentChord;
        
        public FretboardManager()
        {

            for(int i = 0; i < 6; i++)
            {
                for(int j = 0; j < 12;j++)
                {
                    allNotes[i,j]=new Note(j,i);
                }
            }
        }

   



        public void UpdateNotes()
        {
            List<Note.NoteEnum> scaleNotes = new List<Note.NoteEnum>();
            if(currentKey!=null)
            {
                Console.WriteLine("Yes");
                foreach(var note in currentScale)
                {
                    Console.WriteLine($"{note} {currentKey} {currentScale[currentMode]}");
                    scaleNotes.Add( (Note.NoteEnum)(( (int) note + (int) currentKey + (12-(int)currentScale[currentMode]))%12) );
                    Console.WriteLine( (Note.NoteEnum)(( (int) note + (int) currentKey + (12-(int)currentScale[currentMode]))%12) );
                } 
            }
            foreach(var note in allNotes){
                
                if(scaleNotes.Contains(note.NoteValue))
                {
                    if(note.NoteValue==currentKey)
                    {
                        note.color="red";
                    }
                    else
                    {
                        note.color="#0066FF";
                    }
                    
                }
                else
                {
                    note.color="transparent";
                }
            }
        
        }
    }
}
using System;

namespace GuitarApp.Models
{


    public class Note
    {
        public string color {get;set;}
        public int GuitarFret {get;set;}
        public int GuitarString {get;set;}
        public NoteEnum NoteValue { get; set; }
        public int Octave {get;set;}

        public Note(int guitarFret,int guitarString)
        {
            this.GuitarFret = guitarFret;
            this.GuitarString = guitarString;
            int tmp = (int)GuitarStrings[guitarString].note + guitarFret; // 4+3 = 7

            Octave = GuitarStrings[guitarString].octave + tmp/12; // 4+0 = 4
            NoteValue = (NoteEnum)(tmp%12);                   // 7%6 = 1

        }

            public static (Note.NoteEnum note,int octave)[] GuitarStrings =
            {
                (Note.NoteEnum.E,4),
                (Note.NoteEnum.A,4),
                (Note.NoteEnum.D,5),
                (Note.NoteEnum.G,5),
                (Note.NoteEnum.B,5),
                (Note.NoteEnum.E,6)
            };
        public enum NoteEnum{
            C,Cs,D,Ds,E,F,Fs,G,Gs,A,As,B
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MusikDotNET.Note;

namespace MusikDotNET
{
    public class Sheet
    {
        public List<Note> Notes;
        private string[] noteNames = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24" };
        
        public Sheet(List<string> data)
        {
            Notes = new List<Note>();
            for (int i = 0; i < 6; i++)
            {
                string l = data[i];
                foreach (string note in noteNames)
                {
                    List<int> poss = l.AllIndexesOf(note);
                    foreach (int pos in poss)
                        this.Notes.Add(new Note(note, new GuitarPos(i, pos)));
                }
            }
        }
    }
}

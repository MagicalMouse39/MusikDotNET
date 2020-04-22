using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MusikDotNET
{
    public static class MusicUtils
    {
        public static string[] itChords = new[] { "DO", "DO7", "DO7+", "DO4", "DO7/4", "DO6", "DOm", "DOm7", "DOm6", "DOm7/5b", "DO5+", "DOdim", "DO#", "REb", "DO#7", "REb7", "DO#7+", "REb7+", "DO#4", "REb4", "DO#7/4", "REb7/4", "DO#6", "DO#m", "REbm", "DO#m7", "REbm7", "DO#m6", "REbm6", "DO#m7/5b", "REbm7/5b", "DO#5+", "DO#dim", "REbdim", "RE", "RE7", "RE7+", "RE4", "RE7/4", "RE6", "REm", "REm7", "REm6", "REm7/5b", "RE5+", "REdim", "RE#", "RE#7", "RE#7+", "RE#4", "MIb4", "RE#7/4", "MIb7/4", "RE#6", "RE#m", "MIbm", "RE#m7", "MIbm7", "RE#m6", "MIbm6", "RE#m7/5b", "MIbm7/5b", "RE#5+", "RE#dim", "MIbdim", "MI", "MI7", "MI7+", "MI4", "MI7/4", "MI6", "MIm", "MIm7", "MIm6", "MIm7/5b", "MI5+", "MIdim", "FA", "FA7", "FA7+", "FA4", "FA7/4", "FA6", "FAm", "FAm7", "FAm6", "FAm7/5b", "FA5+", "FAdim", "FA#", "SOLb", "FA#7", "SOLb7", "FA#7+", "SOLb7+", "FA#4", "SOLb4", "FA#7/4", "SOLb7/4", "FA#6", "SOLb6", "FA#m", "SOLbm", "FA#m7", "SOLbm7", "FA#m6", "SOLbm6", "FA#m7/5b", "SOLbm7/5b", "FA#5+", "FA#dim", "SOL", "SOL7", "SOL7+", "SOL4", "SOL7/4", "SOL6", "SOLm", "SOLm7", "SOLm6", "SOLm7/5b", "SOL5+", "SOLdim", "SOL#", "LAb", "SOL#7", "LAb7", "SOL#7+", "SOL#4", "LAb4", "SOL#7/4", "SOL#6", "LAb6", "SOL#m", "LAbm", "SOL#m7", "LAbm7", "SOL#m6", "LAbm6", "SOL#m7/5b", "LAbm7/5b", "SOL#5+", "SOL# dim", "LAbdim", "LA", "LA7", "LA7+", "LA4", "LA7/4", "LA6", "LAm", "LAm7", "LAm6", "LAm7/5b", "LA5+", "LAdim", "LA#", "SIb", "LA#7", "SIb7", "LA#7+", "SIb7+", "LA#4", "SIb4", "LA#7/4", "SIb7/4", "LA#6", "SIb6", "LA#m", "SIbm", "LA#m7", "SIbm7", "LA#m6", "SIbm6", "LA#m7/5b", "SIbm7/5b", "LA#5+", "SIb5+", "LA#dim", "SIbdim", "SI", "SI7", "SI7+", "SI4", "SI7/4", "SI6", "SIm", "SIm7", "SIm6", "SIm7/5b", "SI5+", "SIdim" };
        public static string[] enChords = new[] { "C", "C7", "C7+", "C4", "C7/4", "C6", "Cm", "Cm7", "Cm6", "Cm7/5b", "C5+", "Cdim", "C#", "Db", "C#7", "Db7", "C#7+", "Db7+", "C#4", "Db4", "C#7/4", "Db7/4", "C#6", "C#m", "Dbm", "C#m7", "Dbm7", "C#m6", "Dbm6", "C#m7/5b", "Dbm7/5b", "C#5+", "C#dim", "Dbdim", "D", "D7", "D7+", "D4", "D7/4", "D6", "Dm", "Dm7", "Dm6", "Dm7/5b", "D5+", "Ddim", "D#", "D#7", "D#7+", "D#4", "Eb4", "D#7/4", "Eb7/4", "D#6", "D#m", "Ebm", "D#m7", "Ebm7", "D#m6", "Ebm6", "D#m7/5b", "Ebm7/5b", "D#5+", "D#dim", "Ebdim", "E", "E7", "E7+", "E4", "E7/4", "E6", "Em", "Em7", "Em6", "Em7/5b", "E5+", "Edim", "F", "F7", "F7+", "F4", "F7/4", "F6", "Fm", "Fm7", "Fm6", "Fm7/5b", "F5+", "Fdim", "F#", "F#7", "Gb7", "F#7+", "Gb7+", "F#4", "Gb4", "F#7/4", "Gb7/4", "F#6", "Gb6", "F#m", "Gbm", "F#m7", "Gbm7", "F#m6", "Gbm6", "F#m7/5b", "Gbm7/5b", "F#5+", "F#dim", "Gb", "G", "G7", "G7+", "G4", "G7/4", "G6", "Gm", "Gm7", "Gm6", "Gm7/5b", "G5+", "Gdim", "G#", "Ab", "G#7", "Ab7", "G#7+", "G#4", "Ab4", "G#7/4", "G#6", "Ab6", "G#m", "Abm", "G#m7", "Abm7", "G#m6", "Abm6", "G#m7/5b", "Abm7/5b", "G#5+", "G# dim", "Abdim", "A", "A7", "A7+", "A4", "A7/4", "A6", "Am", "Am7", "Am6", "Am7/5b", "A5+", "Adim", "A#", "Bb", "A#7", "Bb7", "A#7+", "Bb7+", "A#4", "Bb4", "A#7/4", "Bb7/4", "A#6", "Bb6", "A#m", "Bbm", "A#m7", "Bbm7", "A#m6", "Bbm6", "A#m7/5b", "Bbm7/5b", "A#5+", "Bb5+", "A#dim", "Bbdim", "B", "B7", "B7+", "B4", "B7/4", "B6", "Bm", "Bm7", "Bm6", "Bm7/5b", "B5+", "Bdim" };

        public static Dictionary<string, string> Notes = new Dictionary<string, string>();
        public static void InitNotesDict()
        {
            for (int i = 0; i < itChords.Length; i++)
                Notes.Add(itChords[i], enChords[i]);
        }

        public static void ITtoENG(ref Note note)
        {
            Notes.TryGetValue(note.Name, out note.Name);
        }

        public static void ENGtoIT(ref Note note)
        {
            for (int i = 0; i < itChords.Length; i++)
                if (note.Name == Notes.Values.ToArray()[i])
                    note.Name = Notes.Keys.ToArray()[i];
        }

        public static void Translate(ref Note note, NoteLayout layout)
        {
            if (layout == NoteLayout.Italian)
                ENGtoIT(ref note);
            else if (layout == NoteLayout.English)
                ITtoENG(ref note);
        }

        public static void TranspUp(ref Note note, NoteLayout layout)
        {
            switch (layout)
            {
                case NoteLayout.Italian:
                    {
                        if (note.Name.StartsWith("DO") && !note.Name.Contains("#"))
                            note.Name = "DO#" + note.Name.Substring(2);
                        else if (note.Name.StartsWith("DO#"))
                            note.Name = "RE" + note.Name.Substring(3);
                        else if (note.Name.StartsWith("RE") && !note.Name.Contains("#"))
                            note.Name = "RE#" + note.Name.Substring(2);
                        else if (note.Name.StartsWith("RE#"))
                            note.Name = "MI" + note.Name.Substring(3);
                        else if (note.Name.StartsWith("MI") && !note.Name.Contains("#"))
                            note.Name = "FA" + note.Name.Substring(2);
                        else if (note.Name.StartsWith("FA") && !note.Name.Contains("#"))
                            note.Name = "FA#" + note.Name.Substring(2);
                        else if (note.Name.StartsWith("FA#"))
                            note.Name = "SOL" + note.Name.Substring(3);
                        else if (note.Name.StartsWith("SOL") && !note.Name.Contains("#"))
                            note.Name = "SOL#" + note.Name.Substring(3);
                        else if (note.Name.StartsWith("SOL#"))
                            note.Name = "LA" + note.Name.Substring(4);
                        else if (note.Name.StartsWith("LA") && !note.Name.Contains("#"))
                            note.Name = "LA#" + note.Name.Substring(2);
                        else if (note.Name.StartsWith("LA#"))
                            note.Name = "SI" + note.Name.Substring(3);
                        else if (note.Name.StartsWith("SI") && !note.Name.Contains("#"))
                            note.Name = "DO" + note.Name.Substring(2);
                    }
                    break;
                case NoteLayout.English:
                    {
                        if (note.Name.StartsWith("C") && !note.Name.Contains("#"))
                            note.Name = "C#" + note.Name.Substring(1);
                        else if (note.Name.StartsWith("C#"))
                            note.Name = "D" + note.Name.Substring(2);
                        else if (note.Name.StartsWith("D") && !note.Name.Contains("#"))
                            note.Name = "D#" + note.Name.Substring(1);
                        else if (note.Name.StartsWith("D#"))
                            note.Name = "E" + note.Name.Substring(2);
                        else if (note.Name.StartsWith("E") && !note.Name.Contains("#"))
                            note.Name = "F" + note.Name.Substring(1);
                        else if (note.Name.StartsWith("F") && !note.Name.Contains("#"))
                            note.Name = "F#" + note.Name.Substring(1);
                        else if (note.Name.StartsWith("F#"))
                            note.Name = "G" + note.Name.Substring(2);
                        else if (note.Name.StartsWith("G") && !note.Name.Contains("#"))
                            note.Name = "G#" + note.Name.Substring(1);
                        else if (note.Name.StartsWith("G#"))
                            note.Name = "A" + note.Name.Substring(2);
                        else if (note.Name.StartsWith("A") && !note.Name.Contains("#"))
                            note.Name = "A#" + note.Name.Substring(1);
                        else if (note.Name.StartsWith("A#"))
                            note.Name = "B" + note.Name.Substring(2);
                        else if (note.Name.StartsWith("B") && !note.Name.Contains("#"))
                            note.Name = "C" + note.Name.Substring(1);
                    }
                    break;
            }
        }

        public static void TranspDown(ref Note note, NoteLayout layout)
        {
            switch (layout)
            {
                case NoteLayout.Italian:
                    {
                        if (note.Name.StartsWith("DO") && !note.Name.Contains("#"))
                            note.Name = "SI" + note.Name.Substring(2);
                        else if (note.Name.StartsWith("DO#"))
                            note.Name = "DO" + note.Name.Substring(3);
                        else if (note.Name.StartsWith("RE") && !note.Name.Contains("#"))
                            note.Name = "DO#" + note.Name.Substring(2);
                        else if (note.Name.StartsWith("RE#"))
                            note.Name = "RE" + note.Name.Substring(3);
                        else if (note.Name.StartsWith("MI") && !note.Name.Contains("#"))
                            note.Name = "RE#" + note.Name.Substring(2);
                        else if (note.Name.StartsWith("FA") && !note.Name.Contains("#"))
                            note.Name = "MI" + note.Name.Substring(2);
                        else if (note.Name.StartsWith("FA#"))
                            note.Name = "FA" + note.Name.Substring(3);
                        else if (note.Name.StartsWith("SOL") && !note.Name.Contains("#"))
                            note.Name = "FA#" + note.Name.Substring(3);
                        else if (note.Name.StartsWith("SOL#"))
                            note.Name = "SOL" + note.Name.Substring(4);
                        else if (note.Name.StartsWith("LA") && !note.Name.Contains("#"))
                            note.Name = "SOL#" + note.Name.Substring(2);
                        else if (note.Name.StartsWith("LA#"))
                            note.Name = "LA" + note.Name.Substring(3);
                        else if (note.Name.StartsWith("SI") && !note.Name.Contains("#"))
                            note.Name = "LA#" + note.Name.Substring(2);
                    }
                    break;
                case NoteLayout.English:
                    {
                        if (note.Name.StartsWith("C") && !note.Name.Contains("#"))
                            note.Name = "B" + note.Name.Substring(1);
                        else if (note.Name.StartsWith("C#"))
                            note.Name = "C" + note.Name.Substring(2);
                        else if (note.Name.StartsWith("D") && !note.Name.Contains("#"))
                            note.Name = "C#" + note.Name.Substring(1);
                        else if (note.Name.StartsWith("D#"))
                            note.Name = "D" + note.Name.Substring(2);
                        else if (note.Name.StartsWith("E") && !note.Name.Contains("#"))
                            note.Name = "D#" + note.Name.Substring(1);
                        else if (note.Name.StartsWith("F") && !note.Name.Contains("#"))
                            note.Name = "E" + note.Name.Substring(1);
                        else if (note.Name.StartsWith("F#"))
                            note.Name = "F" + note.Name.Substring(2);
                        else if (note.Name.StartsWith("G") && !note.Name.Contains("#"))
                            note.Name = "F#" + note.Name.Substring(1);
                        else if (note.Name.StartsWith("G#"))
                            note.Name = "G" + note.Name.Substring(2);
                        else if (note.Name.StartsWith("A") && !note.Name.Contains("#"))
                            note.Name = "G#" + note.Name.Substring(1);
                        else if (note.Name.StartsWith("A#"))
                            note.Name = "A" + note.Name.Substring(2);
                        else if (note.Name.StartsWith("B") && !note.Name.Contains("#"))
                            note.Name = "A#" + note.Name.Substring(1);
                    }
                    break;
            }
        }
    }
}

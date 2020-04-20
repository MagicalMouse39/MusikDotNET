using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusikDotNET
{
    public static class MusicUtils
    {
        public static void ITtoENG(ref Note note)
        {
            switch (note.Name)
            {
                case "DO":
                    note.Name = "C";
                    break;
                case "RE":
                    note.Name = "D";
                    break;
                case "MI":
                    note.Name = "E";
                    break;
                case "FA":
                    note.Name = "F";
                    break;
                case "SOL":
                    note.Name = "G";
                    break;
                case "LA":
                    note.Name = "A";
                    break;
                case "SI":
                    note.Name = "B";
                    break;
            }
        }

        public static void ENGtoIT(ref Note note)
        {
            switch (note.Name)
            {
                case "C":
                    note.Name = "DO";
                    break;
                case "D":
                    note.Name = "RE";
                    break;
                case "E":
                    note.Name = "MI";
                    break;
                case "F":
                    note.Name = "FA";
                    break;
                case "G":
                    note.Name = "SOL";
                    break;
                case "A":
                    note.Name = "LA";
                    break;
                case "B":
                    note.Name = "SI";
                    break;
            }
        }


    }
}

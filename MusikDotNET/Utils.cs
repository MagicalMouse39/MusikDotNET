using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MusikDotNET.Note;

namespace MusikDotNET
{
    static class Utils
    {
        public static List<int> AllIndexesOf(this string str, string value)
        {
            if (String.IsNullOrEmpty(value))
                throw new ArgumentException("the string to find may not be empty", "value");
            List<int> indexes = new List<int>();
            for (int index = 0; ; index += value.Length)
            {
                index = str.IndexOf(value, index);
                if (index == -1)
                    return indexes;
                indexes.Add(index);
            }
        }
        
        public static float MeasureText(this string text, string font, double fontSize)
        {
            Image img = new Bitmap(1, 1);
            Graphics g = Graphics.FromImage(img);
            Font ffont = new Font(font, (float)fontSize);
            SizeF size = g.MeasureString(text, ffont);
            return size.Width;
        }

        public static bool ContainsNoteByPos(this List<Note> list, GuitarPos pos)
        {
            foreach (var n in list)
                if (n.GuitarPosition == pos)
                    return true;
            return false;
        }

        public static Note GetNoteByPos(this List<Note> list, GuitarPos pos)
        {
            foreach (var n in list)
                if (n.GuitarPosition == pos)
                    return n;
            return default(Note);
        }

        public static void RemoveNoteByPos(this List<Note> list, GuitarPos pos)
        {
            list.Remove(list.GetNoteByPos(pos));
        }

        public static int HowMany(this List<Note> list, string index)
        {
            var g = list.GroupBy(i => i);
            foreach (var ge in g)
                if (ge.Key.Name == index)
                    return ge.Count();
            return 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusikDotNET
{
    public struct Note
    {
        public struct GuitarPos
        {
            public int String, Pos;

            public static bool operator ==(GuitarPos pos1, GuitarPos pos2)
            {
                return pos1.Pos == pos2.Pos && pos1.String == pos2.String;
            }

            public static bool operator !=(GuitarPos pos1, GuitarPos pos2)
            {
                return pos1.Pos != pos2.Pos || pos1.String != pos2.String;
            }

            public GuitarPos(int String, int Pos)
            {
                this.String = String;
                this.Pos = Pos;
            }
        }

        public struct FlutePos
        {
            public int Pos;

            public FlutePos(int Pos)
            {
                this.Pos = Pos;
            }
        }

        public GuitarPos GuitarPosition;
        public FlutePos FlutePosition;

        public string Name;

        public Note(string name, GuitarPos guitarPos = new GuitarPos(), FlutePos flutePos = new FlutePos())
        {
            this.Name = name;
            this.GuitarPosition = guitarPos;
            this.FlutePosition = flutePos;
        }
    }
}

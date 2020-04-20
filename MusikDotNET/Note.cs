using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusikDotNET
{
    public struct Note
    {
        public string Name;

        private bool isFlat;
        public bool IsFlat
        {
            get
            {
                return this.isFlat;
            }
            set
            {
                if (value)
                    this.isSharp = false;
                this.isFlat = value;
            }
        }

        private bool isSharp;
        public bool IsSharp
        {
            get
            {
                return this.isSharp;
            }
            set
            {
                if (value)
                    this.isFlat = false;
                this.isSharp = value;
            }
        }
        
        public Note(string name, bool isFlat = false, bool isSharp = false)
        {
            this.Name = name;
            this.isFlat = isFlat;
            this.isSharp = isSharp;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MidiKeyBard
{
    class NoteEvent
    {
        public byte Note{get; set;}
        public bool IsOn { get; set; }
        public NoteEvent(byte note, bool isOn)
        {
            Note = note;
            IsOn = isOn;
        }
    }
}

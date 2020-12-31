using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace MidiKeyBard
{
    class DebugLog
    {
        public static void WriteLine(string message,
            bool condition = true,
            [CallerLineNumber] int lineNumber = 0,
            [CallerMemberName] string memberName = "")
        {
#if DEBUG
            if (condition)
            {
                string text = String.Format("{0}\t{1}\t({2}:{3})", DateTime.Now.ToString("HH:mm:ss.fff"), message, memberName, lineNumber);
                System.Diagnostics.Debug.WriteLine(text);
            }
#endif
        }

        internal static void WriteNoteEvent(NoteEvent note,
            bool condition = true,
            [CallerLineNumber] int lineNumber = 0,
            [CallerMemberName] string memberName = "")
        {
#if DEBUG
            if (condition)
            {
                string text = String.Format("N{0} {1}",note.Note, note.IsOn);
                WriteLine(text, condition, lineNumber, memberName);
            }
#endif
        }
    }
}

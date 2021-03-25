using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiKeyBard
{
    class ProcessCatcher
    {

        public static List<System.Diagnostics.Process> GetWindowProcess()
        {
            var processInfo = new List<System.Diagnostics.Process>();
            foreach (var p in System.Diagnostics.Process.GetProcesses())
            {
                if (p.MainWindowTitle != "")
                {
                    processInfo.Add(p);
                    //new ProcessInfo(p.MainWindowTitle, p.MainWindowHandle)
                }
            }

            return processInfo;
        }
    }



    public class ProcessItem
    {
        private System.Diagnostics.Process _process;
        private int _index = 0;

        public ProcessItem(System.Diagnostics.Process process, int index = 0)
        {
            _process = process;
            _index = index;
        }

        public System.Diagnostics.Process Process
        {
            get
            {
                return _process;
            }
        }

        public string GetWindowTitleWithIndex()
        {
            if (_index > 0)
            {
                return string.Format("{0} - {1}", _process.MainWindowTitle, _index + 1);
            }
            else
            {
                return string.Format("{0}", _process.MainWindowTitle);
            }
        }

        public override string ToString()
        {
            if (_process == null)
            {
                return "None";
            }

            return string.Format("<{0}>{1}[{2}]", _process.MainWindowHandle, GetWindowTitleWithIndex(),_process.ProcessName);
        }
    }
}

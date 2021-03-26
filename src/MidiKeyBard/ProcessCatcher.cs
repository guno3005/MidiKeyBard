using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MidiKeyBard
{
    class ProcessCatcher
    {
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool IsIconic(IntPtr hWnd);


        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        const int SW_SHOWNORMAL = 1;

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

        internal static void PopupWindowProcess(IntPtr targetHandle)
        {
            if(targetHandle == IntPtr.Zero)
            {
                return;
            }

            if (IsIconic(targetHandle))
            {
                // ウィンドウが最小化されていた場合
                ShowWindow(targetHandle, SW_SHOWNORMAL);
            }
            else
            {
                SetForegroundWindow(targetHandle);
            }

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
                return string.Format("{0}({1})", _process.MainWindowTitle, _index + 1);
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

            return string.Format("<{0}>{1}", _process.MainWindowHandle, GetWindowTitleWithIndex());
        }
    }
}

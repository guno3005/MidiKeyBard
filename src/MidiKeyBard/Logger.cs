using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiKeyBard
{
    public class Logger
    {
        private static Logger _instance = null;
        private string _path = null;
        public static Logger GetInstance()
        {
            if(_instance == null)
            {
                _instance = new Logger();
            }
            return _instance;
        }

        private Logger()
        {
            _path = System.Windows.Forms.Application.StartupPath;
        }

        const string ErrorLogFile = "ErrLog.txt";
        public void WriteEx(Exception ex)
        {
            string sLogFile = System.IO.Path.Combine(_path, ErrorLogFile);
            using (System.IO.StreamWriter oLogFile = new System.IO.StreamWriter(sLogFile, true, System.Text.Encoding.UTF8))
            {
                oLogFile.WriteLine(String.Format("[{0:yyyy/MM/dd HH:mm:ss}]", DateTime.Now));
                oLogFile.WriteLine("<Message>" + ex.ToString());
                oLogFile.WriteLine("<Source>" + ex.Source);
                oLogFile.WriteLine();
            }
        }

    }
}

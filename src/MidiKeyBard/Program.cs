using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidiKeyBard
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            System.Threading.Thread.GetDomain().UnhandledException += new UnhandledExceptionEventHandler(GetDomain_UnhandledException);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        private static void GetDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Exception ex = (Exception)e.ExceptionObject;
            OutputLog(ex, "UnhandledException");
        }

        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            var ex = e.Exception;
            OutputLog(ex, "ThreadException");
        }

        private static void OutputLog(Exception ex, string title)
        {
            string sLogFile = System.IO.Path.Combine(Application.StartupPath, "ErrLog.txt");
            using (System.IO.StreamWriter oLogFile = new System.IO.StreamWriter(sLogFile, true, System.Text.Encoding.UTF8))
            {
                oLogFile.WriteLine(String.Format("[{0:yyyy/MM/dd HH:mm:ss}]", DateTime.Now));
                oLogFile.WriteLine("<Message>" + ex.ToString());
                oLogFile.WriteLine("<Source>" + ex.Source);
                oLogFile.WriteLine();
            }

            MessageBox.Show("プログラム中で補足されなかったエラーが発生しました。詳細はエラーログをごらん下さい", title);
        }
    }

}

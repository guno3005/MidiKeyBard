using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace MidiKeyBard
{
    class InifileUtils
    {
        private String filePath { get; set; } 

       [DllImport("KERNEL32.DLL")]
        private static extern uint
            GetPrivateProfileString(string lpAppName,
            string lpKeyName, string lpDefault,
            StringBuilder lpReturnedString, uint nSize,
            string lpFileName);

        [DllImport("KERNEL32.DLL")]
        private static extern uint
            GetPrivateProfileInt(string lpAppName,
            string lpKeyName, int nDefault, string lpFileName);

        [DllImport("kernel32.dll")]
        private static extern int WritePrivateProfileString(
            string lpApplicationName,
            string lpKeyName,
            string lpstring,
            string lpFileName);

        public InifileUtils(string path)
        {
            filePath = path;
        }


        /// <summary>
        /// iniファイル中のセクションのキーを指定して、文字列を返す
        /// </summary>
        /// <param name="section"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public String getValueString(String section, String key)
        {
            StringBuilder sb = new StringBuilder(1024);

            GetPrivateProfileString(
                section,
                key,
                "",
                sb,
                Convert.ToUInt32(sb.Capacity),
                filePath);

            return sb.ToString();
        }

        /// <summary>
        /// iniファイル中のセクションのキーを指定して、整数値を返す
        /// </summary>
        /// <param name="section"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public int getValueInt(String section, String key, int defaultValue = 0)
        {
            return (int)GetPrivateProfileInt(section, key, defaultValue, filePath);
        }

        /// <summary>
        /// iniファイル中のセクションのキーを指定して、Bool値を返す
        /// </summary>
        /// <param name="section"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public bool getValueBool(String section, String key)
        {
            int valInt = (int)GetPrivateProfileInt(section, key, 0, filePath);
            return (valInt != 0);
        }

        /// <summary>
        /// 指定したセクション、キーに数値を書き込む
        /// </summary>
        /// <param name="section"></param>
        /// <param name="key"></param>
        /// <param name="val"></param>
        public void setValue(String section, String key, int val)
        {
            setValue(section, key, val.ToString());
        }

        /// <summary>
        /// 指定したセクション、キーに文字列を書き込む
        /// </summary>
        /// <param name="section"></param>
        /// <param name="key"></param>
        /// <param name="val"></param>
        public void setValue(String section, String key, String val)
        {
            WritePrivateProfileString(section, key, val, filePath);
        }
    
        /// <summary>
        /// 指定したセクション、キーに文字列を書き込む
        /// </summary>
        /// <param name="section"></param>
        /// <param name="key"></param>
        /// <param name="val"></param>
        public void setValue(String section, String key, bool valBool)
        {
            string val;
            if (valBool == true)
            {
                val = "1";
            }
            else
            {
                val = "0";
            }

            WritePrivateProfileString(section, key, val, filePath);
        }
    }
}

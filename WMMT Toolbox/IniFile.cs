using System.IO;
using System.Runtime.InteropServices;
using System.Text
    ;
namespace WMMT_Toolbox
{
    public class IniFile
    {
        private string filePath;

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

        public IniFile(string filePath)
        {
            this.filePath = filePath;
        }

        public void WriteValue(string section, string key, string value)
        {
            WritePrivateProfileString(section, key, value, this.filePath);
        }

        public string ReadValue(string section, string key)
        {
            StringBuilder retVal = new StringBuilder(255);
            GetPrivateProfileString(section, key, "", retVal, 255, this.filePath);
            return retVal.ToString();
        }
    }
}
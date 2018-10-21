using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AttendanceDataProcessing.Classes.Globals;

namespace AttendanceDataProcessing.Classes.Globals
{
    class Enums
    {
        // MySQL Connection
        public string Server = "localhost";
        public string UserDB = "root";
        public string PwDB = "MTIzNA==";
        public string PortDB = "3306";
        public string DBName = "absensi";

        public const string tbluser = "tbluser";
        public const string tblkaryawan = "tblkaryawan";
        public const string tbljamkerja = "tbljamkerja";
        public const string tblharikerja = "tblharikerja";




        // Message Titles
        public const string Warning = "Warning";
        public const string Error = "Error";
        public const string Information = "Information";
        public const string Confirmation = "Confirmation";

        // Messages
        public const string BlankField = "Fill The Blank Field";
        public const string WrongUserPw = "Username / Password Salah";
        public const string ExitConfirm = "Exit Program ?";

        public string DateTimeFormat = "dd MMM yyyy HH:mm:ss";

        public string Copyright = "Attendance Data Processing Software © Institut Teknologi Adhi Tama Surabaya " + DateTime.Now.ToString("yyyy") + " All Right Reserved.";
    }
}

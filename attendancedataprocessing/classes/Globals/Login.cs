using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AttendanceDataProcessing.Classes.Globals;
using MySql.Data.MySqlClient;
using System.Data;

namespace AttendanceDataProcessing.Classes.Globals
{
    class Login
    {
        GlobalFunctions FGlobal = new GlobalFunctions();

        string tablename = Enums.tbluser;
        List<string> fieldname = new List<string>(new string[] {
                                "username","password"
                                });
        List<string> value = new List<string>();

        public bool CheckLogin(string username, string password)
        {
            bool result = false;

            value.Clear();
            value.Add(username);
            value.Add(password);

            DataSet record = FGlobal.Select(tablename,fieldname, value);
            
            if (record.Tables[0].Rows.Count > 0)
            {
                result = true;
            }
            return result;
        }
    }
}

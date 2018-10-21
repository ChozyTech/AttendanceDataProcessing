using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AttendanceDataProcessing.Forms.Globals;
using MySql.Data.MySqlClient;
using System.Data;
using System.Globalization;

namespace AttendanceDataProcessing.Classes.Globals
{
    class GlobalFunctions
    {
        MySqlConnection conn = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();
        Enums Const = new Enums();
        public void SelectAllText(object sender)
        {
            ((TextBox)sender).SelectAll();
        }

        public void SetFocusEnter(object sender, KeyEventArgs e)
        {
            Control obj = (Control)sender;
            if (e.KeyCode == Keys.Enter)
            {
                obj.Focus();
            }
        }

        public bool ValidateBlankField(List<object> sender)
        {
            var result = true;
            foreach (object obj in sender)
            {
                if (((TextBox)obj).Text == "")
                {  
                    result = false;
                }
            }

                    return result;
        }

        public void Logout(Form FrmMain) 
        {
            foreach (Form frm in FrmMain.MdiChildren)
            {
                frm.Dispose();
                frm.Close();
            }
            FrmLogin FrmLogin = new FrmLogin();
            FrmMain.Dispose();
            FrmLogin.Show();
        }

        public void ShowChild(Form Parent, Form Child)
        {
            Child.MdiParent = Parent;
            Child.Show();
        }
        public void Close(Form Frm)
        {
            Frm.Dispose();
            Frm.Close();
        }
        public string GetDateTime()
        {
            return DateTime.Now.ToString(Const.DateTimeFormat);
        }
        public string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }
        public string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }

        public void GetConnection()
        {
            string koneksi = "Server=" + Const.Server + ";Port="+ Const.PortDB + ";Database=" + Const.DBName +
                                   ";Uid=" + Const.UserDB + ";Pwd=" +
                                    Encoding.UTF8.GetString(Convert.FromBase64String(Const.PwDB)) + ";";
            conn.ConnectionString = koneksi;
        }

        public DataSet Select(string tablename, List<string> fieldname, List<string> value)
        {
            GetConnection();
            cmd = conn.CreateCommand();
            string Query = "SELECT * FROM " + tablename;
            if (value.Count > 0)
            {
                Query = Query + " WHERE ";
                for (int i = 0; i < fieldname.Count; i++)
                {
                    if (i == fieldname.Count - 1)
                    {
                        Query = Query + fieldname[i] + " = " + "'" + value[i] + "'";
                    }
                    else
                    {
                        Query = Query + fieldname[i] + " = " + "'" + value[i] + "'" + " AND ";
                    }
                }
            }
            cmd.CommandText = Query;
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            return ds;
        }

        public void Insert(string tablename, List<string> fieldname, List<string> Data)
        {
            GetConnection();
            string Query = "INSERT INTO " + tablename;
            Query = Query + " (";
            for(int i = 0; i < fieldname.Count(); i++)
            {
                if (i == fieldname.Count - 1)
                {
                    Query = Query + fieldname[i] + ")";
                }
                else
                {
                    Query = Query + fieldname[i] + ",";
                }
            }
            Query = Query + " VALUES (";
            for (int j = 0; j < Data.Count(); j++)
            {
                if (j == Data.Count - 1)
                {
                    Query = Query +  "'" +Data[j] + "')";
                }
                else
                {
                    Query = Query + "'" + Data[j] + "',";
                }
            }
            conn.Open();
            cmd = new MySqlCommand(Query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public List<string> CastType(List<object> Data)
        {
            List<string> DataNew = new List<string>();

            foreach (var item in Data)
            {
                if (item.GetType() == typeof(TextBox))
                {
                    DataNew.Add(((TextBox)item).Text);
                }
                else if(item.GetType() == typeof(ComboBox))
                {
                    DataNew.Add(((ComboBox)item).Text);
                }
                else if (item.GetType() == typeof(DateTimePicker))
                {
                    DataNew.Add(DateTime.ParseExact(((DateTimePicker)item).Text, "dd/MM/yyyy",
                                  CultureInfo.InvariantCulture).ToString("yyyy-MM-dd"));
                }
            }

            return DataNew;
        }
    }
}

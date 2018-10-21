using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AttendanceDataProcessing.Classes.Globals;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace AttendanceDataProcessing.Classes.Masters
{
    class MasterKaryawan
    {
        GlobalFunctions FGlobal = new GlobalFunctions();

        string tablename = Enums.tblkaryawan;
        List<string> fieldname = new List<string>(new string[] {
                                "kode","nama","alamat", "ttl", "notelp", "jamkerja","email", "tglmasuk","tglkeluar", "keterangan"
                                });
        List<string> value = new List<string>();

        public DataSet GetAllData()
        {
            value.Clear();

            DataSet record = FGlobal.Select(tablename, fieldname, value);

            return record;
        }

        public void Insert(List<object> Data)
        {
            value.Clear();
            List<string> temp = FGlobal.CastType(Data);
            List<string> DataInserted = new List<string>();
            int i = 0;
            foreach (var item in temp)
            {
                if (i ==3  && i != 4)
                {
                    DataInserted.Add(temp[i] + "," + temp[i + 1]);
                }
                else if (i != 4)
                {
                    DataInserted.Add(item);
                }
                i++;
            }
            FGlobal.Insert(tablename, fieldname, DataInserted);
        }
    }
}

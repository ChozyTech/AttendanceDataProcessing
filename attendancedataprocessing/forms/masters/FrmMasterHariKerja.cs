using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using AttendanceDataProcessing.Classes.Globals;
using AttendanceDataProcessing.Classes.Masters;

namespace AttendanceDataProcessing.Forms.Masters
{
    public partial class FrmMasterHariKerja : DevExpress.XtraEditors.XtraForm
    {
        MasterHariKerja FMasterHariKerja = new MasterHariKerja();
        GlobalFunctions FGlobal = new GlobalFunctions();
        public FrmMasterHariKerja()
        {
            InitializeComponent();
            DataSet ds = FMasterHariKerja.GetAllData();
            dgData.DataSource = ds.Tables[0].DefaultView;
        }

        private void btnew_Click(object sender, EventArgs e)
        {
            FrmInputMasterHariKerja input = new FrmInputMasterHariKerja();
            input.ShowDialog();
            refresh();
        }

        private void btclose_Click(object sender, EventArgs e)
        {
            FGlobal.Close(this);
        }
        private void refresh()
        {
            dgData.DataSource = null;
            DataSet ds = FMasterHariKerja.GetAllData();
            dgData.DataSource = ds.Tables[0].DefaultView;
        }
        private void dgData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
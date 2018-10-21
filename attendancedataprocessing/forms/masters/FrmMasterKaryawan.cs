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
    public partial class FrmMasterKaryawan : DevExpress.XtraEditors.XtraForm
    {
        MasterKaryawan FMasterKaryawan = new MasterKaryawan();
        GlobalFunctions FGlobal = new GlobalFunctions();
        public FrmMasterKaryawan()
        {
            InitializeComponent();
            DataSet ds = FMasterKaryawan.GetAllData();
            dgData.DataSource = ds.Tables[0].DefaultView;
        }

        private void btnew_Click(object sender, EventArgs e)
        {
            FrmInputMasterKaryawan input = new FrmInputMasterKaryawan();
            input.ShowDialog();
            refresh();

        }

        private void btclose_Click(object sender, EventArgs e)
        {
            FGlobal.Close(this);
        }

        private void dgData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void refresh()
        {
            dgData.DataSource = null;
            DataSet ds = FMasterKaryawan.GetAllData();
            dgData.DataSource = ds.Tables[0].DefaultView;
        }

        private void PnlOperations_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
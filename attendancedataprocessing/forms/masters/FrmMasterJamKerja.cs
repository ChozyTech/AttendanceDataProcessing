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
    public partial class FrmMasterJamKerja : DevExpress.XtraEditors.XtraForm
    {
        MasterJamKerja FMasterJamKerja = new MasterJamKerja();
        GlobalFunctions FGlobal = new GlobalFunctions();
        public FrmMasterJamKerja()
        {
            InitializeComponent();
            DataSet ds = FMasterJamKerja.GetAllData();
            dgData.DataSource = ds.Tables[0].DefaultView;
        }

        private void btnew_Click(object sender, EventArgs e)
        {
            FrmInputMasterJamKerja input = new FrmInputMasterJamKerja();
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
            DataSet ds = FMasterJamKerja.GetAllData();
            dgData.DataSource = ds.Tables[0].DefaultView;
        }

        private void PnlOperations_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
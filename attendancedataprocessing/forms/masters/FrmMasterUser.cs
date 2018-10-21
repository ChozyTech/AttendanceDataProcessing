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

namespace AttendanceDataProcessing.Forms.Masters
{
    public partial class FrmMasterUser : DevExpress.XtraEditors.XtraForm
    {
        GlobalFunctions FGlobal = new GlobalFunctions();
        public FrmMasterUser()
        {
            InitializeComponent();
        }

        private void btnew_Click(object sender, EventArgs e)
        {
            FrmInputMasterUser input = new FrmInputMasterUser();
            input.ShowDialog();
        }

        private void btclose_Click(object sender, EventArgs e)
        {
            FGlobal.Close(this);
        }
    }
}
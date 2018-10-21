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
    public partial class FrmInputMasterUser : DevExpress.XtraEditors.XtraForm
    {
        GlobalFunctions FGlobal = new GlobalFunctions();
        public FrmInputMasterUser()
        {
            InitializeComponent();
        }

        private void btcancel_Click(object sender, EventArgs e)
        {
            FGlobal.Close(this);
        }
    }
}
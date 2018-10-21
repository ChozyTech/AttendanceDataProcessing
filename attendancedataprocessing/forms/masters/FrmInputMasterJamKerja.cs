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
    public partial class FrmInputMasterJamKerja : DevExpress.XtraEditors.XtraForm
    {
        MasterJamKerja FMasterJamKerja = new MasterJamKerja();
        GlobalFunctions FGlobal = new GlobalFunctions();
        public FrmInputMasterJamKerja()
        {
            InitializeComponent();
        }

        private void btcancel_Click(object sender, EventArgs e)
        {
            FGlobal.Close(this);
        }

        private void btsave_Click(object sender, EventArgs e)
        {
            List<object> obj = new List<object>(new object[] {
                                txtkode,txtnama
                                });
            var result = FGlobal.ValidateBlankField(obj);
            if (result)
            {
                List<object> objInserted = new List<object>(new object[] {
                                txtkode, txtnama, txtketerangan, chkaktif
                                });
                try
                {
                    FMasterJamKerja.Insert(objInserted);
                    MessageBox.Show("Data Inserted", Enums.Information, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                    this.Close();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Enums.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
           }
            else
            {
                MessageBox.Show(Enums.BlankField, Enums.Warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FrmInputMasterJamKerja_Load(object sender, EventArgs e)
        {

        }
    }
}
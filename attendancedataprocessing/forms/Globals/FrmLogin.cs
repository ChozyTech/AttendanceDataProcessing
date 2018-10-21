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

namespace AttendanceDataProcessing.Forms.Globals
{
    public partial class FrmLogin : DevExpress.XtraEditors.XtraForm
    {
        GlobalFunctions FGlobal = new GlobalFunctions();
        Login Flogin = new Login();
        public FrmLogin()
        {
            InitializeComponent();
        }
#region ----- Key Down Event -----
        private void txtusername_KeyDown(object sender, KeyEventArgs e)
        {
            FGlobal.SetFocusEnter(txtpassword, e);
        }

        private void txtpassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btlogin_Click(sender, e);
            }
        }
#endregion

#region ----- Enter Event -----
        private void txtusername_Enter(object sender, EventArgs e)
        {
            FGlobal.SelectAllText(sender);
        }

        private void txtpassword_Enter(object sender, EventArgs e)
        {
            FGlobal.SelectAllText(sender);
        }
        #endregion

        #region ----- Click Event -----
        private void btlogin_Click(object sender, EventArgs e)
        {
            List<object> obj = new List<object>(new object[] {
                                txtusername,
                                txtpassword
                                });
            var result = FGlobal.ValidateBlankField(obj);

            if (result)
            {
                result = Flogin.CheckLogin(txtusername.Text, FGlobal.Base64Encode(txtpassword.Text));
                if (result)
                {
                    this.Hide();
                    var FrmMain = new FrmMain();
                    FrmMain.user = txtusername.Text;
                   // FrmMain.Closed += (s, args) =>e?


                    FrmMain.Show();
                }
                else
                {
                    MessageBox.Show(Enums.WrongUserPw, Enums.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else { 
                MessageBox.Show(Enums.BlankField, Enums.Warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using AttendanceDataProcessing.Forms.Masters;
using AttendanceDataProcessing.Classes.Globals;

namespace AttendanceDataProcessing
{
    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public string user;
        GlobalFunctions FGlobal = new GlobalFunctions();
        Enums Enum = new Enums();

        #region ----- Initialize -----
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            barStatisUser.Caption = barStatisUser.Caption + user;
            barStatisCopyright.Caption = Enum.Copyright;
            TmrTime.Enabled = true;
        }

        #endregion

        #region ----- Menu Click -----
        private void btmenuMasterKaryawan_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmMasterKaryawan FrmMaster = new FrmMasterKaryawan();
            FGlobal.ShowChild(this, FrmMaster);
        }
        private void btmenuMasterJamKerja_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmMasterJamKerja FrmMaster = new FrmMasterJamKerja();
            FGlobal.ShowChild(this, FrmMaster);
        }

        private void btmenuMasterHariKerja_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmMasterHariKerja FrmMaster = new FrmMasterHariKerja();
            FGlobal.ShowChild(this, FrmMaster);
        }

        private void btmenuMasterUser_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmMasterUser FrmMaster = new FrmMasterUser();
            FGlobal.ShowChild(this, FrmMaster);
        }

        #endregion

        #region ----- Logout & Exit Program -----
        private void btmenuLogout_ItemClick(object sender, ItemClickEventArgs e)
        {
            FGlobal.Logout(this);
        }

        private void btmenuExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region ----- Timer Action -----
        private void TmrTime_Tick(object sender, EventArgs e)
        {
            barStaticTime.Caption = FGlobal.GetDateTime();
        }
        #endregion

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
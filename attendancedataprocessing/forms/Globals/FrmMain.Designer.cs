namespace AttendanceDataProcessing
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.imageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.btmenuMasterKaryawan = new DevExpress.XtraBars.BarButtonItem();
            this.btmenuMasterJamKerja = new DevExpress.XtraBars.BarButtonItem();
            this.btmenuMasterHariKerja = new DevExpress.XtraBars.BarButtonItem();
            this.btmenuInputWaktuKerja = new DevExpress.XtraBars.BarButtonItem();
            this.btmenuImportDataAttendance = new DevExpress.XtraBars.BarButtonItem();
            this.btmenuLaporanKehadiran = new DevExpress.XtraBars.BarButtonItem();
            this.btmenuRekapKehadiran = new DevExpress.XtraBars.BarButtonItem();
            this.btmenuPeringkatKehadiran = new DevExpress.XtraBars.BarButtonItem();
            this.btmenuMasterUser = new DevExpress.XtraBars.BarButtonItem();
            this.btmenuLevelManager = new DevExpress.XtraBars.BarButtonItem();
            this.btmenuHelp = new DevExpress.XtraBars.BarButtonItem();
            this.btmenuAbout = new DevExpress.XtraBars.BarButtonItem();
            this.btmenuLogout = new DevExpress.XtraBars.BarButtonItem();
            this.btmenuExit = new DevExpress.XtraBars.BarButtonItem();
            this.barStatisUser = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticTime = new DevExpress.XtraBars.BarStaticItem();
            this.barStatisCopyright = new DevExpress.XtraBars.BarStaticItem();
            this.PageGeneral = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.PageGroupGeneral = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.PageMaster = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.PageGroupMaster = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.PageTransaksi = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.PageGroupTransaksi = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.PageReport = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.PageGroupReport = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.PageSettings = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.PageGroupSettings = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.PageHelp = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.PageGroupHelp = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.documentManager = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.themes = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.TmrTime = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.AllowMinimizeRibbon = false;
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Images = this.imageCollection;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btmenuMasterKaryawan,
            this.btmenuMasterJamKerja,
            this.btmenuMasterHariKerja,
            this.btmenuInputWaktuKerja,
            this.btmenuImportDataAttendance,
            this.btmenuLaporanKehadiran,
            this.btmenuRekapKehadiran,
            this.btmenuPeringkatKehadiran,
            this.btmenuMasterUser,
            this.btmenuLevelManager,
            this.btmenuHelp,
            this.btmenuAbout,
            this.btmenuLogout,
            this.btmenuExit,
            this.barStatisUser,
            this.barStaticTime,
            this.barStatisCopyright});
            this.ribbon.LargeImages = this.imageCollection;
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 23;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.PageGeneral,
            this.PageMaster,
            this.PageTransaksi,
            this.PageReport,
            this.PageSettings,
            this.PageHelp});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowQatLocationSelector = false;
            this.ribbon.ShowToolbarCustomizeItem = false;
            this.ribbon.Size = new System.Drawing.Size(1022, 147);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            this.ribbon.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // imageCollection
            // 
            this.imageCollection.ImageSize = new System.Drawing.Size(32, 32);
            this.imageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection.ImageStream")));
            this.imageCollection.Images.SetKeyName(0, "About.png");
            this.imageCollection.Images.SetKeyName(1, "Back.png");
            this.imageCollection.Images.SetKeyName(2, "Close.png");
            this.imageCollection.Images.SetKeyName(3, "Delete.png");
            this.imageCollection.Images.SetKeyName(4, "Edit.png");
            this.imageCollection.Images.SetKeyName(5, "Exit.png");
            this.imageCollection.Images.SetKeyName(6, "Help.png");
            this.imageCollection.Images.SetKeyName(7, "Help2.png");
            this.imageCollection.Images.SetKeyName(8, "ImportDataAttendance.png");
            this.imageCollection.Images.SetKeyName(9, "InputWaktuKerja.png");
            this.imageCollection.Images.SetKeyName(10, "LaporanKehadiran.png");
            this.imageCollection.Images.SetKeyName(11, "left-1 - Copy.png");
            this.imageCollection.Images.SetKeyName(12, "left-1.png");
            this.imageCollection.Images.SetKeyName(13, "LevelManager.png");
            this.imageCollection.Images.SetKeyName(14, "Logout.png");
            this.imageCollection.Images.SetKeyName(15, "MasterHAriKerja.png");
            this.imageCollection.Images.SetKeyName(16, "MasterJamKerja.png");
            this.imageCollection.Images.SetKeyName(17, "MasterKaryawan.png");
            this.imageCollection.Images.SetKeyName(18, "MasterUser.png");
            this.imageCollection.Images.SetKeyName(19, "New.png");
            this.imageCollection.Images.SetKeyName(20, "Next.png");
            this.imageCollection.Images.SetKeyName(21, "PeringkatKehadiran.png");
            this.imageCollection.Images.SetKeyName(22, "PeringkatKehadiran2 (2).png");
            this.imageCollection.Images.SetKeyName(23, "RekapKehadiran.png");
            this.imageCollection.Images.SetKeyName(24, "Save.png");
            // 
            // btmenuMasterKaryawan
            // 
            this.btmenuMasterKaryawan.Caption = "Master Karyawan";
            this.btmenuMasterKaryawan.Id = 1;
            this.btmenuMasterKaryawan.ImageOptions.LargeImageIndex = 17;
            this.btmenuMasterKaryawan.Name = "btmenuMasterKaryawan";
            this.btmenuMasterKaryawan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btmenuMasterKaryawan_ItemClick);
            // 
            // btmenuMasterJamKerja
            // 
            this.btmenuMasterJamKerja.Caption = "Master Jam Kerja";
            this.btmenuMasterJamKerja.Id = 2;
            this.btmenuMasterJamKerja.ImageOptions.LargeImageIndex = 16;
            this.btmenuMasterJamKerja.Name = "btmenuMasterJamKerja";
            this.btmenuMasterJamKerja.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btmenuMasterJamKerja_ItemClick);
            // 
            // btmenuMasterHariKerja
            // 
            this.btmenuMasterHariKerja.Caption = "Master Hari Kerja";
            this.btmenuMasterHariKerja.Id = 3;
            this.btmenuMasterHariKerja.ImageOptions.LargeImageIndex = 15;
            this.btmenuMasterHariKerja.Name = "btmenuMasterHariKerja";
            this.btmenuMasterHariKerja.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btmenuMasterHariKerja_ItemClick);
            // 
            // btmenuInputWaktuKerja
            // 
            this.btmenuInputWaktuKerja.Caption = "Input Waktu Kerja";
            this.btmenuInputWaktuKerja.Id = 6;
            this.btmenuInputWaktuKerja.ImageOptions.LargeImageIndex = 9;
            this.btmenuInputWaktuKerja.Name = "btmenuInputWaktuKerja";
            // 
            // btmenuImportDataAttendance
            // 
            this.btmenuImportDataAttendance.Caption = "Import Data Attendance";
            this.btmenuImportDataAttendance.Id = 7;
            this.btmenuImportDataAttendance.ImageOptions.LargeImageIndex = 8;
            this.btmenuImportDataAttendance.Name = "btmenuImportDataAttendance";
            // 
            // btmenuLaporanKehadiran
            // 
            this.btmenuLaporanKehadiran.Caption = "Laporan Kehadiran";
            this.btmenuLaporanKehadiran.Id = 8;
            this.btmenuLaporanKehadiran.ImageOptions.LargeImageIndex = 10;
            this.btmenuLaporanKehadiran.Name = "btmenuLaporanKehadiran";
            // 
            // btmenuRekapKehadiran
            // 
            this.btmenuRekapKehadiran.Caption = "Rekap Kehadiran";
            this.btmenuRekapKehadiran.Id = 9;
            this.btmenuRekapKehadiran.ImageOptions.LargeImageIndex = 23;
            this.btmenuRekapKehadiran.Name = "btmenuRekapKehadiran";
            // 
            // btmenuPeringkatKehadiran
            // 
            this.btmenuPeringkatKehadiran.Caption = "Peringkat Kehadiran";
            this.btmenuPeringkatKehadiran.Id = 10;
            this.btmenuPeringkatKehadiran.ImageOptions.LargeImageIndex = 21;
            this.btmenuPeringkatKehadiran.Name = "btmenuPeringkatKehadiran";
            // 
            // btmenuMasterUser
            // 
            this.btmenuMasterUser.Caption = "Master User";
            this.btmenuMasterUser.Id = 11;
            this.btmenuMasterUser.ImageOptions.LargeImageIndex = 18;
            this.btmenuMasterUser.Name = "btmenuMasterUser";
            this.btmenuMasterUser.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btmenuMasterUser_ItemClick);
            // 
            // btmenuLevelManager
            // 
            this.btmenuLevelManager.Caption = "Level Manager";
            this.btmenuLevelManager.Id = 12;
            this.btmenuLevelManager.ImageOptions.LargeImageIndex = 13;
            this.btmenuLevelManager.Name = "btmenuLevelManager";
            // 
            // btmenuHelp
            // 
            this.btmenuHelp.Caption = "Help";
            this.btmenuHelp.Id = 13;
            this.btmenuHelp.ImageOptions.LargeImageIndex = 6;
            this.btmenuHelp.Name = "btmenuHelp";
            // 
            // btmenuAbout
            // 
            this.btmenuAbout.Caption = "About";
            this.btmenuAbout.Id = 14;
            this.btmenuAbout.ImageOptions.LargeImageIndex = 0;
            this.btmenuAbout.Name = "btmenuAbout";
            // 
            // btmenuLogout
            // 
            this.btmenuLogout.Caption = "Logout";
            this.btmenuLogout.Id = 15;
            this.btmenuLogout.ImageOptions.LargeImageIndex = 14;
            this.btmenuLogout.Name = "btmenuLogout";
            this.btmenuLogout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btmenuLogout_ItemClick);
            // 
            // btmenuExit
            // 
            this.btmenuExit.Caption = "Exit";
            this.btmenuExit.Id = 16;
            this.btmenuExit.ImageOptions.LargeImageIndex = 5;
            this.btmenuExit.Name = "btmenuExit";
            this.btmenuExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btmenuExit_ItemClick);
            // 
            // barStatisUser
            // 
            this.barStatisUser.Caption = "| User : ";
            this.barStatisUser.Id = 20;
            this.barStatisUser.Name = "barStatisUser";
            // 
            // barStaticTime
            // 
            this.barStaticTime.Caption = "-";
            this.barStaticTime.Id = 21;
            this.barStaticTime.Name = "barStaticTime";
            // 
            // barStatisCopyright
            // 
            this.barStatisCopyright.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barStatisCopyright.Caption = "-";
            this.barStatisCopyright.Id = 22;
            this.barStatisCopyright.Name = "barStatisCopyright";
            // 
            // PageGeneral
            // 
            this.PageGeneral.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.PageGroupGeneral});
            this.PageGeneral.Name = "PageGeneral";
            this.PageGeneral.Text = "General";
            // 
            // PageGroupGeneral
            // 
            this.PageGroupGeneral.ItemLinks.Add(this.btmenuLogout, true);
            this.PageGroupGeneral.ItemLinks.Add(this.btmenuExit, true);
            this.PageGroupGeneral.Name = "PageGroupGeneral";
            this.PageGroupGeneral.Text = "General";
            // 
            // PageMaster
            // 
            this.PageMaster.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.PageGroupMaster});
            this.PageMaster.Name = "PageMaster";
            this.PageMaster.Text = "Master";
            // 
            // PageGroupMaster
            // 
            this.PageGroupMaster.ItemLinks.Add(this.btmenuMasterKaryawan, true);
            this.PageGroupMaster.ItemLinks.Add(this.btmenuMasterJamKerja, true);
            this.PageGroupMaster.ItemLinks.Add(this.btmenuMasterHariKerja, true);
            this.PageGroupMaster.Name = "PageGroupMaster";
            this.PageGroupMaster.Text = "Master Data";
            // 
            // PageTransaksi
            // 
            this.PageTransaksi.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.PageGroupTransaksi});
            this.PageTransaksi.Name = "PageTransaksi";
            this.PageTransaksi.Text = "Transaksi";
            // 
            // PageGroupTransaksi
            // 
            this.PageGroupTransaksi.ItemLinks.Add(this.btmenuInputWaktuKerja, true);
            this.PageGroupTransaksi.ItemLinks.Add(this.btmenuImportDataAttendance, true);
            this.PageGroupTransaksi.Name = "PageGroupTransaksi";
            this.PageGroupTransaksi.Text = "Transaksi";
            // 
            // PageReport
            // 
            this.PageReport.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.PageGroupReport});
            this.PageReport.Name = "PageReport";
            this.PageReport.Text = "Laporan";
            // 
            // PageGroupReport
            // 
            this.PageGroupReport.ItemLinks.Add(this.btmenuLaporanKehadiran, true);
            this.PageGroupReport.ItemLinks.Add(this.btmenuRekapKehadiran, true);
            this.PageGroupReport.ItemLinks.Add(this.btmenuPeringkatKehadiran, true);
            this.PageGroupReport.Name = "PageGroupReport";
            this.PageGroupReport.Text = "Laporan";
            // 
            // PageSettings
            // 
            this.PageSettings.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.PageGroupSettings});
            this.PageSettings.Name = "PageSettings";
            this.PageSettings.Text = "Settings";
            // 
            // PageGroupSettings
            // 
            this.PageGroupSettings.ItemLinks.Add(this.btmenuMasterUser, true);
            this.PageGroupSettings.ItemLinks.Add(this.btmenuLevelManager, true);
            this.PageGroupSettings.Name = "PageGroupSettings";
            this.PageGroupSettings.Text = "Settings";
            // 
            // PageHelp
            // 
            this.PageHelp.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.PageGroupHelp});
            this.PageHelp.Name = "PageHelp";
            this.PageHelp.Text = "Help";
            // 
            // PageGroupHelp
            // 
            this.PageGroupHelp.ItemLinks.Add(this.btmenuHelp, true);
            this.PageGroupHelp.ItemLinks.Add(this.btmenuAbout, true);
            this.PageGroupHelp.Name = "PageGroupHelp";
            this.PageGroupHelp.Text = "Help";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.barStaticTime);
            this.ribbonStatusBar.ItemLinks.Add(this.barStatisUser);
            this.ribbonStatusBar.ItemLinks.Add(this.barStatisCopyright);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 744);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1022, 23);
            // 
            // documentManager
            // 
            this.documentManager.MdiParent = this;
            this.documentManager.MenuManager = this.ribbon;
            this.documentManager.View = this.tabbedView;
            this.documentManager.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView});
            // 
            // themes
            // 
            this.themes.LookAndFeel.SkinName = "Office 2013";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // TmrTime
            // 
            this.TmrTime.Interval = 1000;
            this.TmrTime.Tick += new System.EventHandler(this.TmrTime_Tick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 767);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FrmMain";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Attendance Data Processing Software";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage PageMaster;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup PageGroupMaster;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btmenuMasterKaryawan;
        private DevExpress.XtraBars.BarButtonItem btmenuMasterJamKerja;
        private DevExpress.XtraBars.BarButtonItem btmenuMasterHariKerja;
        private DevExpress.Utils.ImageCollection imageCollection;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView;
        private DevExpress.LookAndFeel.DefaultLookAndFeel themes;
        private DevExpress.XtraBars.BarButtonItem btmenuInputWaktuKerja;
        private DevExpress.XtraBars.BarButtonItem btmenuImportDataAttendance;
        private DevExpress.XtraBars.BarButtonItem btmenuLaporanKehadiran;
        private DevExpress.XtraBars.BarButtonItem btmenuRekapKehadiran;
        private DevExpress.XtraBars.BarButtonItem btmenuPeringkatKehadiran;
        private DevExpress.XtraBars.Ribbon.RibbonPage PageTransaksi;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup PageGroupTransaksi;
        private DevExpress.XtraBars.Ribbon.RibbonPage PageReport;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup PageGroupReport;
        private DevExpress.XtraBars.Ribbon.RibbonPage PageSettings;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup PageGroupSettings;
        private DevExpress.XtraBars.Ribbon.RibbonPage PageHelp;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup PageGroupHelp;
        private DevExpress.XtraBars.BarButtonItem btmenuMasterUser;
        private DevExpress.XtraBars.BarButtonItem btmenuLevelManager;
        private DevExpress.XtraBars.BarButtonItem btmenuHelp;
        private DevExpress.XtraBars.BarButtonItem btmenuAbout;
        private DevExpress.XtraBars.BarButtonItem btmenuLogout;
        private DevExpress.XtraBars.BarButtonItem btmenuExit;
        private DevExpress.XtraBars.Ribbon.RibbonPage PageGeneral;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup PageGroupGeneral;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.BarStaticItem barStatisUser;
        private DevExpress.XtraBars.BarStaticItem barStaticTime;
        private System.Windows.Forms.Timer TmrTime;
        private DevExpress.XtraBars.BarStaticItem barStatisCopyright;
    }
}
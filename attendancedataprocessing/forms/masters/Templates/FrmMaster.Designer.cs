namespace AttendanceDataProcessing.Forms.Masters.Templates
{
    partial class FrmMaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMaster));
            this.PnlOperations = new DevExpress.XtraEditors.PanelControl();
            this.btfirst = new DevExpress.XtraEditors.SimpleButton();
            this.imageCollection = new DevExpress.Utils.ImageCollection();
            this.btprev = new DevExpress.XtraEditors.SimpleButton();
            this.btnext = new DevExpress.XtraEditors.SimpleButton();
            this.btend = new DevExpress.XtraEditors.SimpleButton();
            this.btnew = new DevExpress.XtraEditors.SimpleButton();
            this.btedit = new DevExpress.XtraEditors.SimpleButton();
            this.btdelete = new DevExpress.XtraEditors.SimpleButton();
            this.btclose = new DevExpress.XtraEditors.SimpleButton();
            this.dgData = new System.Windows.Forms.DataGridView();
            this.PnlSearch = new DevExpress.XtraEditors.PanelControl();
            this.lblrecordcount = new System.Windows.Forms.Label();
            this.lblrecordfound = new System.Windows.Forms.Label();
            this.cbsort = new System.Windows.Forms.ComboBox();
            this.txtsearch2 = new System.Windows.Forms.TextBox();
            this.txtsearch1 = new System.Windows.Forms.TextBox();
            this.cbfilter2 = new System.Windows.Forms.ComboBox();
            this.cblogic = new System.Windows.Forms.ComboBox();
            this.cbfilter1 = new System.Windows.Forms.ComboBox();
            this.themes = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            ((System.ComponentModel.ISupportInitialize)(this.PnlOperations)).BeginInit();
            this.PnlOperations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PnlSearch)).BeginInit();
            this.PnlSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlOperations
            // 
            this.PnlOperations.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.PnlOperations.Appearance.Options.UseBackColor = true;
            this.PnlOperations.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.PnlOperations.Controls.Add(this.btfirst);
            this.PnlOperations.Controls.Add(this.btprev);
            this.PnlOperations.Controls.Add(this.btnext);
            this.PnlOperations.Controls.Add(this.btend);
            this.PnlOperations.Controls.Add(this.btnew);
            this.PnlOperations.Controls.Add(this.btedit);
            this.PnlOperations.Controls.Add(this.btdelete);
            this.PnlOperations.Controls.Add(this.btclose);
            this.PnlOperations.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlOperations.Location = new System.Drawing.Point(0, 0);
            this.PnlOperations.Name = "PnlOperations";
            this.PnlOperations.Size = new System.Drawing.Size(784, 81);
            this.PnlOperations.TabIndex = 0;
            // 
            // btfirst
            // 
            this.btfirst.AppearanceHovered.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btfirst.AppearanceHovered.Options.UseBackColor = true;
            this.btfirst.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btfirst.ImageOptions.ImageIndex = 12;
            this.btfirst.ImageOptions.ImageList = this.imageCollection;
            this.btfirst.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btfirst.Location = new System.Drawing.Point(12, 12);
            this.btfirst.LookAndFeel.SkinName = "Office 2013";
            this.btfirst.Name = "btfirst";
            this.btfirst.Size = new System.Drawing.Size(64, 52);
            this.btfirst.TabIndex = 15;
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
            // btprev
            // 
            this.btprev.AppearanceHovered.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btprev.AppearanceHovered.Options.UseBackColor = true;
            this.btprev.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btprev.ImageOptions.ImageIndex = 1;
            this.btprev.ImageOptions.ImageList = this.imageCollection;
            this.btprev.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btprev.Location = new System.Drawing.Point(82, 12);
            this.btprev.LookAndFeel.SkinName = "Office 2013";
            this.btprev.Name = "btprev";
            this.btprev.Size = new System.Drawing.Size(64, 52);
            this.btprev.TabIndex = 16;
            // 
            // btnext
            // 
            this.btnext.AppearanceHovered.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnext.AppearanceHovered.Options.UseBackColor = true;
            this.btnext.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnext.ImageOptions.ImageIndex = 20;
            this.btnext.ImageOptions.ImageList = this.imageCollection;
            this.btnext.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnext.Location = new System.Drawing.Point(152, 12);
            this.btnext.LookAndFeel.SkinName = "Office 2013";
            this.btnext.Name = "btnext";
            this.btnext.Size = new System.Drawing.Size(64, 52);
            this.btnext.TabIndex = 17;
            // 
            // btend
            // 
            this.btend.AppearanceHovered.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btend.AppearanceHovered.Options.UseBackColor = true;
            this.btend.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btend.ImageOptions.ImageIndex = 11;
            this.btend.ImageOptions.ImageList = this.imageCollection;
            this.btend.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btend.Location = new System.Drawing.Point(222, 12);
            this.btend.LookAndFeel.SkinName = "Office 2013";
            this.btend.Name = "btend";
            this.btend.Size = new System.Drawing.Size(64, 52);
            this.btend.TabIndex = 18;
            // 
            // btnew
            // 
            this.btnew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnew.AppearanceHovered.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnew.AppearanceHovered.Options.UseBackColor = true;
            this.btnew.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnew.ImageOptions.ImageIndex = 19;
            this.btnew.ImageOptions.ImageList = this.imageCollection;
            this.btnew.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnew.Location = new System.Drawing.Point(498, 12);
            this.btnew.LookAndFeel.SkinName = "Office 2013";
            this.btnew.Name = "btnew";
            this.btnew.Size = new System.Drawing.Size(64, 52);
            this.btnew.TabIndex = 1;
            this.btnew.Text = "New";
            this.btnew.Click += new System.EventHandler(this.btnew_Click);
            // 
            // btedit
            // 
            this.btedit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btedit.AppearanceHovered.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btedit.AppearanceHovered.Options.UseBackColor = true;
            this.btedit.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btedit.ImageOptions.ImageIndex = 4;
            this.btedit.ImageOptions.ImageList = this.imageCollection;
            this.btedit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btedit.Location = new System.Drawing.Point(568, 12);
            this.btedit.LookAndFeel.SkinName = "Office 2013";
            this.btedit.Name = "btedit";
            this.btedit.Size = new System.Drawing.Size(64, 52);
            this.btedit.TabIndex = 2;
            this.btedit.Text = "Edit";
            // 
            // btdelete
            // 
            this.btdelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btdelete.AppearanceHovered.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btdelete.AppearanceHovered.Options.UseBackColor = true;
            this.btdelete.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btdelete.ImageOptions.ImageIndex = 3;
            this.btdelete.ImageOptions.ImageList = this.imageCollection;
            this.btdelete.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btdelete.Location = new System.Drawing.Point(638, 12);
            this.btdelete.LookAndFeel.SkinName = "Office 2013";
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(64, 52);
            this.btdelete.TabIndex = 3;
            this.btdelete.Text = "Delete";
            // 
            // btclose
            // 
            this.btclose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btclose.AppearanceHovered.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btclose.AppearanceHovered.Options.UseBackColor = true;
            this.btclose.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btclose.ImageOptions.ImageIndex = 2;
            this.btclose.ImageOptions.ImageList = this.imageCollection;
            this.btclose.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btclose.Location = new System.Drawing.Point(708, 12);
            this.btclose.LookAndFeel.SkinName = "Office 2013";
            this.btclose.Name = "btclose";
            this.btclose.Size = new System.Drawing.Size(64, 52);
            this.btclose.TabIndex = 4;
            this.btclose.Text = "Close";
            this.btclose.Click += new System.EventHandler(this.btclose_Click);
            // 
            // dgData
            // 
            this.dgData.AllowUserToAddRows = false;
            this.dgData.AllowUserToDeleteRows = false;
            this.dgData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgData.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgData.Location = new System.Drawing.Point(0, 81);
            this.dgData.Name = "dgData";
            this.dgData.ReadOnly = true;
            this.dgData.Size = new System.Drawing.Size(784, 398);
            this.dgData.TabIndex = 5;
            // 
            // PnlSearch
            // 
            this.PnlSearch.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.PnlSearch.Appearance.Options.UseBackColor = true;
            this.PnlSearch.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.PnlSearch.Controls.Add(this.lblrecordcount);
            this.PnlSearch.Controls.Add(this.lblrecordfound);
            this.PnlSearch.Controls.Add(this.cbsort);
            this.PnlSearch.Controls.Add(this.txtsearch2);
            this.PnlSearch.Controls.Add(this.txtsearch1);
            this.PnlSearch.Controls.Add(this.cbfilter2);
            this.PnlSearch.Controls.Add(this.cblogic);
            this.PnlSearch.Controls.Add(this.cbfilter1);
            this.PnlSearch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlSearch.Location = new System.Drawing.Point(0, 478);
            this.PnlSearch.Name = "PnlSearch";
            this.PnlSearch.ScrollBarSmallChange = 6;
            this.PnlSearch.Size = new System.Drawing.Size(784, 83);
            this.PnlSearch.TabIndex = 3;
            // 
            // lblrecordcount
            // 
            this.lblrecordcount.AutoSize = true;
            this.lblrecordcount.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblrecordcount.Location = new System.Drawing.Point(110, 57);
            this.lblrecordcount.Name = "lblrecordcount";
            this.lblrecordcount.Size = new System.Drawing.Size(16, 17);
            this.lblrecordcount.TabIndex = 14;
            this.lblrecordcount.Text = "0";
            // 
            // lblrecordfound
            // 
            this.lblrecordfound.AutoSize = true;
            this.lblrecordfound.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblrecordfound.Location = new System.Drawing.Point(9, 57);
            this.lblrecordfound.Name = "lblrecordfound";
            this.lblrecordfound.Size = new System.Drawing.Size(104, 17);
            this.lblrecordfound.TabIndex = 13;
            this.lblrecordfound.Text = "Record Found :";
            // 
            // cbsort
            // 
            this.cbsort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbsort.FormattingEnabled = true;
            this.cbsort.Location = new System.Drawing.Point(12, 33);
            this.cbsort.Name = "cbsort";
            this.cbsort.Size = new System.Drawing.Size(55, 21);
            this.cbsort.TabIndex = 10;
            // 
            // txtsearch2
            // 
            this.txtsearch2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtsearch2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtsearch2.Location = new System.Drawing.Point(200, 30);
            this.txtsearch2.Name = "txtsearch2";
            this.txtsearch2.Size = new System.Drawing.Size(579, 24);
            this.txtsearch2.TabIndex = 12;
            // 
            // txtsearch1
            // 
            this.txtsearch1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtsearch1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtsearch1.Location = new System.Drawing.Point(200, 5);
            this.txtsearch1.Name = "txtsearch1";
            this.txtsearch1.Size = new System.Drawing.Size(579, 24);
            this.txtsearch1.TabIndex = 9;
            // 
            // cbfilter2
            // 
            this.cbfilter2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbfilter2.FormattingEnabled = true;
            this.cbfilter2.Location = new System.Drawing.Point(73, 33);
            this.cbfilter2.Name = "cbfilter2";
            this.cbfilter2.Size = new System.Drawing.Size(121, 21);
            this.cbfilter2.TabIndex = 11;
            // 
            // cblogic
            // 
            this.cblogic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cblogic.FormattingEnabled = true;
            this.cblogic.Location = new System.Drawing.Point(12, 7);
            this.cblogic.Name = "cblogic";
            this.cblogic.Size = new System.Drawing.Size(55, 21);
            this.cblogic.TabIndex = 7;
            // 
            // cbfilter1
            // 
            this.cbfilter1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbfilter1.FormattingEnabled = true;
            this.cbfilter1.Location = new System.Drawing.Point(73, 7);
            this.cbfilter1.Name = "cbfilter1";
            this.cbfilter1.Size = new System.Drawing.Size(121, 21);
            this.cbfilter1.TabIndex = 8;
            // 
            // themes
            // 
            this.themes.LookAndFeel.SkinName = "Office 2013";
            // 
            // FrmMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.PnlSearch);
            this.Controls.Add(this.dgData);
            this.Controls.Add(this.PnlOperations);
            this.LookAndFeel.SkinName = "Office 2013";
            this.Name = "FrmMaster";
            this.Text = "Form Title";
            ((System.ComponentModel.ISupportInitialize)(this.PnlOperations)).EndInit();
            this.PnlOperations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PnlSearch)).EndInit();
            this.PnlSearch.ResumeLayout(false);
            this.PnlSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl PnlOperations;
        private DevExpress.XtraEditors.SimpleButton btdelete;
        private DevExpress.XtraEditors.SimpleButton btclose;
        private DevExpress.XtraEditors.SimpleButton btnew;
        private DevExpress.XtraEditors.SimpleButton btedit;
        private DevExpress.XtraEditors.SimpleButton btfirst;
        private DevExpress.XtraEditors.SimpleButton btprev;
        private DevExpress.XtraEditors.SimpleButton btnext;
        private DevExpress.XtraEditors.SimpleButton btend;
        private System.Windows.Forms.DataGridView dgData;
        private DevExpress.XtraEditors.PanelControl PnlSearch;
        private System.Windows.Forms.Label lblrecordcount;
        private System.Windows.Forms.Label lblrecordfound;
        private System.Windows.Forms.ComboBox cbsort;
        private System.Windows.Forms.TextBox txtsearch2;
        private System.Windows.Forms.TextBox txtsearch1;
        private System.Windows.Forms.ComboBox cbfilter2;
        private System.Windows.Forms.ComboBox cblogic;
        private System.Windows.Forms.ComboBox cbfilter1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel themes;
        private DevExpress.Utils.ImageCollection imageCollection;
    }
}
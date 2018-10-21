namespace AttendanceDataProcessing.Forms.Masters
{
    partial class FrmInputMasterUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInputMasterUser));
            this.PnlOperations = new DevExpress.XtraEditors.PanelControl();
            this.btsave = new DevExpress.XtraEditors.SimpleButton();
            this.imageCollection = new DevExpress.Utils.ImageCollection();
            this.btcancel = new DevExpress.XtraEditors.SimpleButton();
            this.txtnama = new System.Windows.Forms.TextBox();
            this.txtkode = new System.Windows.Forms.TextBox();
            this.lblnama = new DevExpress.XtraEditors.LabelControl();
            this.lblkode = new DevExpress.XtraEditors.LabelControl();
            this.txtketerangan = new System.Windows.Forms.TextBox();
            this.lblketerangan = new DevExpress.XtraEditors.LabelControl();
            this.chkaktif = new System.Windows.Forms.CheckBox();
            this.themes = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lbllastupdate = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblmandatory1 = new System.Windows.Forms.Label();
            this.lblmandatory2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PnlOperations)).BeginInit();
            this.PnlOperations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlOperations
            // 
            this.PnlOperations.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.PnlOperations.Appearance.Options.UseBackColor = true;
            this.PnlOperations.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.PnlOperations.Controls.Add(this.btsave);
            this.PnlOperations.Controls.Add(this.btcancel);
            this.PnlOperations.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlOperations.Location = new System.Drawing.Point(0, 0);
            this.PnlOperations.Name = "PnlOperations";
            this.PnlOperations.Size = new System.Drawing.Size(361, 81);
            this.PnlOperations.TabIndex = 4;
            // 
            // btsave
            // 
            this.btsave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btsave.AppearanceHovered.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btsave.AppearanceHovered.Options.UseBackColor = true;
            this.btsave.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btsave.ImageOptions.ImageIndex = 24;
            this.btsave.ImageOptions.ImageList = this.imageCollection;
            this.btsave.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btsave.Location = new System.Drawing.Point(212, 12);
            this.btsave.LookAndFeel.SkinName = "Office 2013";
            this.btsave.Name = "btsave";
            this.btsave.Size = new System.Drawing.Size(64, 52);
            this.btsave.TabIndex = 5;
            this.btsave.Text = "Save";
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
            // btcancel
            // 
            this.btcancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btcancel.AppearanceHovered.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btcancel.AppearanceHovered.Options.UseBackColor = true;
            this.btcancel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btcancel.ImageOptions.ImageIndex = 2;
            this.btcancel.ImageOptions.ImageList = this.imageCollection;
            this.btcancel.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btcancel.Location = new System.Drawing.Point(282, 12);
            this.btcancel.LookAndFeel.SkinName = "Office 2013";
            this.btcancel.Name = "btcancel";
            this.btcancel.Size = new System.Drawing.Size(64, 52);
            this.btcancel.TabIndex = 6;
            this.btcancel.Text = "Cancel";
            this.btcancel.Click += new System.EventHandler(this.btcancel_Click);
            // 
            // txtnama
            // 
            this.txtnama.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtnama.Location = new System.Drawing.Point(97, 124);
            this.txtnama.Name = "txtnama";
            this.txtnama.PasswordChar = '*';
            this.txtnama.Size = new System.Drawing.Size(237, 24);
            this.txtnama.TabIndex = 1;
            // 
            // txtkode
            // 
            this.txtkode.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtkode.Location = new System.Drawing.Point(97, 96);
            this.txtkode.Name = "txtkode";
            this.txtkode.Size = new System.Drawing.Size(237, 24);
            this.txtkode.TabIndex = 0;
            // 
            // lblnama
            // 
            this.lblnama.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblnama.Appearance.Options.UseFont = true;
            this.lblnama.Appearance.Options.UseTextOptions = true;
            this.lblnama.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lblnama.Location = new System.Drawing.Point(49, 127);
            this.lblnama.LookAndFeel.SkinName = "Office 2013";
            this.lblnama.Name = "lblnama";
            this.lblnama.Size = new System.Drawing.Size(42, 16);
            this.lblnama.TabIndex = 8;
            this.lblnama.Text = "Nama :";
            // 
            // lblkode
            // 
            this.lblkode.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblkode.Appearance.Options.UseFont = true;
            this.lblkode.Appearance.Options.UseTextOptions = true;
            this.lblkode.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lblkode.Location = new System.Drawing.Point(54, 99);
            this.lblkode.LookAndFeel.SkinName = "Office 2013";
            this.lblkode.Name = "lblkode";
            this.lblkode.Size = new System.Drawing.Size(37, 16);
            this.lblkode.TabIndex = 7;
            this.lblkode.Text = "Kode :";
            // 
            // txtketerangan
            // 
            this.txtketerangan.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtketerangan.Location = new System.Drawing.Point(97, 153);
            this.txtketerangan.Multiline = true;
            this.txtketerangan.Name = "txtketerangan";
            this.txtketerangan.PasswordChar = '*';
            this.txtketerangan.Size = new System.Drawing.Size(237, 128);
            this.txtketerangan.TabIndex = 2;
            // 
            // lblketerangan
            // 
            this.lblketerangan.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblketerangan.Appearance.Options.UseFont = true;
            this.lblketerangan.Appearance.Options.UseTextOptions = true;
            this.lblketerangan.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lblketerangan.Location = new System.Drawing.Point(17, 156);
            this.lblketerangan.LookAndFeel.SkinName = "Office 2013";
            this.lblketerangan.Name = "lblketerangan";
            this.lblketerangan.Size = new System.Drawing.Size(74, 16);
            this.lblketerangan.TabIndex = 9;
            this.lblketerangan.Text = "Keterangan :";
            // 
            // chkaktif
            // 
            this.chkaktif.AutoSize = true;
            this.chkaktif.Checked = true;
            this.chkaktif.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkaktif.Font = new System.Drawing.Font("Tahoma", 10F);
            this.chkaktif.Location = new System.Drawing.Point(281, 287);
            this.chkaktif.Name = "chkaktif";
            this.chkaktif.Size = new System.Drawing.Size(53, 21);
            this.chkaktif.TabIndex = 3;
            this.chkaktif.Text = "Aktif";
            this.chkaktif.UseVisualStyleBackColor = true;
            // 
            // themes
            // 
            this.themes.LookAndFeel.SkinName = "Office 2013";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbllastupdate});
            this.statusStrip.Location = new System.Drawing.Point(0, 307);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip.Size = new System.Drawing.Size(361, 22);
            this.statusStrip.TabIndex = 10;
            this.statusStrip.Text = "statusStrip1";
            // 
            // lbllastupdate
            // 
            this.lbllastupdate.Name = "lbllastupdate";
            this.lbllastupdate.Size = new System.Drawing.Size(12, 17);
            this.lbllastupdate.Text = "-";
            // 
            // lblmandatory1
            // 
            this.lblmandatory1.AutoSize = true;
            this.lblmandatory1.ForeColor = System.Drawing.Color.Red;
            this.lblmandatory1.Location = new System.Drawing.Point(336, 96);
            this.lblmandatory1.Name = "lblmandatory1";
            this.lblmandatory1.Size = new System.Drawing.Size(13, 13);
            this.lblmandatory1.TabIndex = 11;
            this.lblmandatory1.Text = "*";
            // 
            // lblmandatory2
            // 
            this.lblmandatory2.AutoSize = true;
            this.lblmandatory2.ForeColor = System.Drawing.Color.Red;
            this.lblmandatory2.Location = new System.Drawing.Point(336, 124);
            this.lblmandatory2.Name = "lblmandatory2";
            this.lblmandatory2.Size = new System.Drawing.Size(13, 13);
            this.lblmandatory2.TabIndex = 12;
            this.lblmandatory2.Text = "*";
            // 
            // FrmInputMasterUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 329);
            this.Controls.Add(this.lblmandatory2);
            this.Controls.Add(this.lblmandatory1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.chkaktif);
            this.Controls.Add(this.txtketerangan);
            this.Controls.Add(this.lblketerangan);
            this.Controls.Add(this.txtnama);
            this.Controls.Add(this.txtkode);
            this.Controls.Add(this.lblnama);
            this.Controls.Add(this.lblkode);
            this.Controls.Add(this.PnlOperations);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.LookAndFeel.SkinName = "Office 2013";
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmInputMasterUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Input Master User";
            ((System.ComponentModel.ISupportInitialize)(this.PnlOperations)).EndInit();
            this.PnlOperations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl PnlOperations;
        private DevExpress.XtraEditors.SimpleButton btsave;
        private DevExpress.XtraEditors.SimpleButton btcancel;
        private System.Windows.Forms.TextBox txtnama;
        private System.Windows.Forms.TextBox txtkode;
        private DevExpress.XtraEditors.LabelControl lblnama;
        private DevExpress.XtraEditors.LabelControl lblkode;
        private System.Windows.Forms.TextBox txtketerangan;
        private DevExpress.XtraEditors.LabelControl lblketerangan;
        private System.Windows.Forms.CheckBox chkaktif;
        private DevExpress.LookAndFeel.DefaultLookAndFeel themes;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lbllastupdate;
        private System.Windows.Forms.Label lblmandatory1;
        private System.Windows.Forms.Label lblmandatory2;
        private DevExpress.Utils.ImageCollection imageCollection;
    }
}
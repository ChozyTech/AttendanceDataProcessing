namespace AttendanceDataProcessing.Forms.Masters
{
    partial class FrmInputMasterKaryawan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInputMasterKaryawan));
            this.PnlOperations = new DevExpress.XtraEditors.PanelControl();
            this.btsave = new DevExpress.XtraEditors.SimpleButton();
            this.imageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.btcancel = new DevExpress.XtraEditors.SimpleButton();
            this.txtnama = new System.Windows.Forms.TextBox();
            this.txtkode = new System.Windows.Forms.TextBox();
            this.lblnama = new DevExpress.XtraEditors.LabelControl();
            this.lblkode = new DevExpress.XtraEditors.LabelControl();
            this.txtketerangan = new System.Windows.Forms.TextBox();
            this.lblketerangan = new DevExpress.XtraEditors.LabelControl();
            this.chkaktif = new System.Windows.Forms.CheckBox();
            this.themes = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.txtalamat = new System.Windows.Forms.TextBox();
            this.lblalamat = new DevExpress.XtraEditors.LabelControl();
            this.txttempatlahir = new System.Windows.Forms.TextBox();
            this.lbltempatlahir = new DevExpress.XtraEditors.LabelControl();
            this.lbltgllahir = new DevExpress.XtraEditors.LabelControl();
            this.txttgllahir = new System.Windows.Forms.DateTimePicker();
            this.txtnotelp = new System.Windows.Forms.TextBox();
            this.lblnotelp = new DevExpress.XtraEditors.LabelControl();
            this.lbljamkerja = new DevExpress.XtraEditors.LabelControl();
            this.cmbjamkerja = new System.Windows.Forms.ComboBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lbllastupdate = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.lblemail = new DevExpress.XtraEditors.LabelControl();
            this.tbltglmasuk = new DevExpress.XtraEditors.LabelControl();
            this.lbltglkeluar = new DevExpress.XtraEditors.LabelControl();
            this.lblmandatory2 = new System.Windows.Forms.Label();
            this.lblmandatory1 = new System.Windows.Forms.Label();
            this.dttglmasuk = new System.Windows.Forms.DateTimePicker();
            this.dttglkeluar = new System.Windows.Forms.DateTimePicker();
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
            this.PnlOperations.Size = new System.Drawing.Size(372, 81);
            this.PnlOperations.TabIndex = 23;
            this.PnlOperations.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlOperations_Paint);
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
            this.btsave.Location = new System.Drawing.Point(223, 12);
            this.btsave.LookAndFeel.SkinName = "Office 2013";
            this.btsave.Name = "btsave";
            this.btsave.Size = new System.Drawing.Size(64, 52);
            this.btsave.TabIndex = 24;
            this.btsave.Text = "Save";
            this.btsave.Click += new System.EventHandler(this.btsave_Click);
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
            this.btcancel.Location = new System.Drawing.Point(293, 12);
            this.btcancel.LookAndFeel.SkinName = "Office 2013";
            this.btcancel.Name = "btcancel";
            this.btcancel.Size = new System.Drawing.Size(64, 52);
            this.btcancel.TabIndex = 25;
            this.btcancel.Text = "Cancel";
            this.btcancel.Click += new System.EventHandler(this.btcancel_Click);
            // 
            // txtnama
            // 
            this.txtnama.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtnama.Location = new System.Drawing.Point(109, 112);
            this.txtnama.Name = "txtnama";
            this.txtnama.Size = new System.Drawing.Size(237, 24);
            this.txtnama.TabIndex = 3;
            // 
            // txtkode
            // 
            this.txtkode.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtkode.Location = new System.Drawing.Point(109, 84);
            this.txtkode.Name = "txtkode";
            this.txtkode.Size = new System.Drawing.Size(237, 24);
            this.txtkode.TabIndex = 1;
            // 
            // lblnama
            // 
            this.lblnama.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblnama.Appearance.Options.UseFont = true;
            this.lblnama.Appearance.Options.UseTextOptions = true;
            this.lblnama.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lblnama.Location = new System.Drawing.Point(61, 115);
            this.lblnama.LookAndFeel.SkinName = "Office 2013";
            this.lblnama.Name = "lblnama";
            this.lblnama.Size = new System.Drawing.Size(42, 16);
            this.lblnama.TabIndex = 2;
            this.lblnama.Text = "Nama :";
            // 
            // lblkode
            // 
            this.lblkode.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblkode.Appearance.Options.UseFont = true;
            this.lblkode.Appearance.Options.UseTextOptions = true;
            this.lblkode.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lblkode.Location = new System.Drawing.Point(66, 87);
            this.lblkode.LookAndFeel.SkinName = "Office 2013";
            this.lblkode.Name = "lblkode";
            this.lblkode.Size = new System.Drawing.Size(37, 16);
            this.lblkode.TabIndex = 0;
            this.lblkode.Text = "Kode :";
            // 
            // txtketerangan
            // 
            this.txtketerangan.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtketerangan.Location = new System.Drawing.Point(109, 361);
            this.txtketerangan.Multiline = true;
            this.txtketerangan.Name = "txtketerangan";
            this.txtketerangan.Size = new System.Drawing.Size(237, 128);
            this.txtketerangan.TabIndex = 21;
            // 
            // lblketerangan
            // 
            this.lblketerangan.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblketerangan.Appearance.Options.UseFont = true;
            this.lblketerangan.Appearance.Options.UseTextOptions = true;
            this.lblketerangan.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lblketerangan.Location = new System.Drawing.Point(29, 364);
            this.lblketerangan.LookAndFeel.SkinName = "Office 2013";
            this.lblketerangan.Name = "lblketerangan";
            this.lblketerangan.Size = new System.Drawing.Size(74, 16);
            this.lblketerangan.TabIndex = 20;
            this.lblketerangan.Text = "Keterangan :";
            // 
            // chkaktif
            // 
            this.chkaktif.AutoSize = true;
            this.chkaktif.Checked = true;
            this.chkaktif.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkaktif.Font = new System.Drawing.Font("Tahoma", 10F);
            this.chkaktif.Location = new System.Drawing.Point(293, 495);
            this.chkaktif.Name = "chkaktif";
            this.chkaktif.Size = new System.Drawing.Size(53, 21);
            this.chkaktif.TabIndex = 22;
            this.chkaktif.Text = "Aktif";
            this.chkaktif.UseVisualStyleBackColor = true;
            // 
            // themes
            // 
            this.themes.LookAndFeel.SkinName = "Office 2013";
            // 
            // txtalamat
            // 
            this.txtalamat.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtalamat.Location = new System.Drawing.Point(109, 141);
            this.txtalamat.Multiline = true;
            this.txtalamat.Name = "txtalamat";
            this.txtalamat.Size = new System.Drawing.Size(237, 46);
            this.txtalamat.TabIndex = 5;
            // 
            // lblalamat
            // 
            this.lblalamat.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblalamat.Appearance.Options.UseFont = true;
            this.lblalamat.Appearance.Options.UseTextOptions = true;
            this.lblalamat.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lblalamat.Location = new System.Drawing.Point(54, 137);
            this.lblalamat.LookAndFeel.SkinName = "Office 2013";
            this.lblalamat.Name = "lblalamat";
            this.lblalamat.Size = new System.Drawing.Size(49, 16);
            this.lblalamat.TabIndex = 4;
            this.lblalamat.Text = "Alamat :";
            // 
            // txttempatlahir
            // 
            this.txttempatlahir.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txttempatlahir.Location = new System.Drawing.Point(109, 192);
            this.txttempatlahir.Name = "txttempatlahir";
            this.txttempatlahir.Size = new System.Drawing.Size(237, 24);
            this.txttempatlahir.TabIndex = 7;
            // 
            // lbltempatlahir
            // 
            this.lbltempatlahir.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lbltempatlahir.Appearance.Options.UseFont = true;
            this.lbltempatlahir.Appearance.Options.UseTextOptions = true;
            this.lbltempatlahir.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lbltempatlahir.Location = new System.Drawing.Point(18, 195);
            this.lbltempatlahir.LookAndFeel.SkinName = "Office 2013";
            this.lbltempatlahir.Name = "lbltempatlahir";
            this.lbltempatlahir.Size = new System.Drawing.Size(85, 16);
            this.lbltempatlahir.TabIndex = 6;
            this.lbltempatlahir.Text = "Tempat Lahir :";
            // 
            // lbltgllahir
            // 
            this.lbltgllahir.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lbltgllahir.Appearance.Options.UseFont = true;
            this.lbltgllahir.Appearance.Options.UseTextOptions = true;
            this.lbltgllahir.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lbltgllahir.Location = new System.Drawing.Point(44, 222);
            this.lbltgllahir.LookAndFeel.SkinName = "Office 2013";
            this.lbltgllahir.Name = "lbltgllahir";
            this.lbltgllahir.Size = new System.Drawing.Size(59, 16);
            this.lbltgllahir.TabIndex = 8;
            this.lbltgllahir.Text = "Tgl Lahir :";
            // 
            // txttgllahir
            // 
            this.txttgllahir.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txttgllahir.Location = new System.Drawing.Point(109, 221);
            this.txttgllahir.Name = "txttgllahir";
            this.txttgllahir.Size = new System.Drawing.Size(237, 21);
            this.txttgllahir.TabIndex = 9;
            // 
            // txtnotelp
            // 
            this.txtnotelp.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtnotelp.Location = new System.Drawing.Point(109, 247);
            this.txtnotelp.Name = "txtnotelp";
            this.txtnotelp.Size = new System.Drawing.Size(237, 24);
            this.txtnotelp.TabIndex = 11;
            // 
            // lblnotelp
            // 
            this.lblnotelp.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblnotelp.Appearance.Options.UseFont = true;
            this.lblnotelp.Appearance.Options.UseTextOptions = true;
            this.lblnotelp.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lblnotelp.Location = new System.Drawing.Point(46, 250);
            this.lblnotelp.LookAndFeel.SkinName = "Office 2013";
            this.lblnotelp.Name = "lblnotelp";
            this.lblnotelp.Size = new System.Drawing.Size(57, 16);
            this.lblnotelp.TabIndex = 10;
            this.lblnotelp.Text = "No. Telp :";
            // 
            // lbljamkerja
            // 
            this.lbljamkerja.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lbljamkerja.Appearance.Options.UseFont = true;
            this.lbljamkerja.Appearance.Options.UseTextOptions = true;
            this.lbljamkerja.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lbljamkerja.Location = new System.Drawing.Point(37, 277);
            this.lbljamkerja.LookAndFeel.SkinName = "Office 2013";
            this.lbljamkerja.Name = "lbljamkerja";
            this.lbljamkerja.Size = new System.Drawing.Size(66, 16);
            this.lbljamkerja.TabIndex = 12;
            this.lbljamkerja.Text = "Jam Kerja :";
            // 
            // cmbjamkerja
            // 
            this.cmbjamkerja.FormattingEnabled = true;
            this.cmbjamkerja.Location = new System.Drawing.Point(109, 276);
            this.cmbjamkerja.Name = "cmbjamkerja";
            this.cmbjamkerja.Size = new System.Drawing.Size(237, 21);
            this.cmbjamkerja.TabIndex = 13;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbllastupdate});
            this.statusStrip.Location = new System.Drawing.Point(0, 518);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip.Size = new System.Drawing.Size(372, 22);
            this.statusStrip.TabIndex = 20;
            this.statusStrip.Text = "statusStrip1";
            // 
            // lbllastupdate
            // 
            this.lbllastupdate.Name = "lbllastupdate";
            this.lbllastupdate.Size = new System.Drawing.Size(12, 17);
            this.lbllastupdate.Text = "-";
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtemail.Location = new System.Drawing.Point(109, 303);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(237, 24);
            this.txtemail.TabIndex = 15;
            // 
            // lblemail
            // 
            this.lblemail.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblemail.Appearance.Options.UseFont = true;
            this.lblemail.Appearance.Options.UseTextOptions = true;
            this.lblemail.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lblemail.Location = new System.Drawing.Point(63, 306);
            this.lblemail.LookAndFeel.SkinName = "Office 2013";
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(40, 16);
            this.lblemail.TabIndex = 14;
            this.lblemail.Text = "Email :";
            // 
            // tbltglmasuk
            // 
            this.tbltglmasuk.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tbltglmasuk.Appearance.Options.UseFont = true;
            this.tbltglmasuk.Appearance.Options.UseTextOptions = true;
            this.tbltglmasuk.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.tbltglmasuk.Location = new System.Drawing.Point(37, 334);
            this.tbltglmasuk.LookAndFeel.SkinName = "Office 2013";
            this.tbltglmasuk.Name = "tbltglmasuk";
            this.tbltglmasuk.Size = new System.Drawing.Size(67, 16);
            this.tbltglmasuk.TabIndex = 16;
            this.tbltglmasuk.Text = "Tgl Masuk :";
            // 
            // lbltglkeluar
            // 
            this.lbltglkeluar.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lbltglkeluar.Appearance.Options.UseFont = true;
            this.lbltglkeluar.Appearance.Options.UseTextOptions = true;
            this.lbltglkeluar.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lbltglkeluar.Location = new System.Drawing.Point(202, 335);
            this.lbltglkeluar.LookAndFeel.SkinName = "Office 2013";
            this.lbltglkeluar.Name = "lbltglkeluar";
            this.lbltglkeluar.Size = new System.Drawing.Size(67, 16);
            this.lbltglkeluar.TabIndex = 18;
            this.lbltglkeluar.Text = "Tgl Keluar :";
            // 
            // lblmandatory2
            // 
            this.lblmandatory2.AutoSize = true;
            this.lblmandatory2.ForeColor = System.Drawing.Color.Red;
            this.lblmandatory2.Location = new System.Drawing.Point(348, 112);
            this.lblmandatory2.Name = "lblmandatory2";
            this.lblmandatory2.Size = new System.Drawing.Size(13, 13);
            this.lblmandatory2.TabIndex = 28;
            this.lblmandatory2.Text = "*";
            // 
            // lblmandatory1
            // 
            this.lblmandatory1.AutoSize = true;
            this.lblmandatory1.ForeColor = System.Drawing.Color.Red;
            this.lblmandatory1.Location = new System.Drawing.Point(348, 84);
            this.lblmandatory1.Name = "lblmandatory1";
            this.lblmandatory1.Size = new System.Drawing.Size(13, 13);
            this.lblmandatory1.TabIndex = 27;
            this.lblmandatory1.Text = "*";
            // 
            // dttglmasuk
            // 
            this.dttglmasuk.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dttglmasuk.Location = new System.Drawing.Point(110, 333);
            this.dttglmasuk.Name = "dttglmasuk";
            this.dttglmasuk.Size = new System.Drawing.Size(76, 21);
            this.dttglmasuk.TabIndex = 17;
            // 
            // dttglkeluar
            // 
            this.dttglkeluar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dttglkeluar.Location = new System.Drawing.Point(270, 333);
            this.dttglkeluar.Name = "dttglkeluar";
            this.dttglkeluar.Size = new System.Drawing.Size(76, 21);
            this.dttglkeluar.TabIndex = 19;
            // 
            // FrmInputMasterKaryawan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 540);
            this.Controls.Add(this.dttglkeluar);
            this.Controls.Add(this.dttglmasuk);
            this.Controls.Add(this.lblmandatory2);
            this.Controls.Add(this.lblmandatory1);
            this.Controls.Add(this.lbltglkeluar);
            this.Controls.Add(this.tbltglmasuk);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.cmbjamkerja);
            this.Controls.Add(this.lbljamkerja);
            this.Controls.Add(this.txtnotelp);
            this.Controls.Add(this.lblnotelp);
            this.Controls.Add(this.txttgllahir);
            this.Controls.Add(this.lbltgllahir);
            this.Controls.Add(this.txttempatlahir);
            this.Controls.Add(this.lbltempatlahir);
            this.Controls.Add(this.txtalamat);
            this.Controls.Add(this.lblalamat);
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
            this.Name = "FrmInputMasterKaryawan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Input Master Karyawan";
            this.Load += new System.EventHandler(this.FrmInputMasterKaryawan_Load);
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
        private System.Windows.Forms.TextBox txtalamat;
        private DevExpress.XtraEditors.LabelControl lblalamat;
        private System.Windows.Forms.TextBox txttempatlahir;
        private DevExpress.XtraEditors.LabelControl lbltempatlahir;
        private DevExpress.XtraEditors.LabelControl lbltgllahir;
        private System.Windows.Forms.DateTimePicker txttgllahir;
        private System.Windows.Forms.TextBox txtnotelp;
        private DevExpress.XtraEditors.LabelControl lblnotelp;
        private DevExpress.XtraEditors.LabelControl lbljamkerja;
        private System.Windows.Forms.ComboBox cmbjamkerja;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lbllastupdate;
        private System.Windows.Forms.TextBox txtemail;
        private DevExpress.XtraEditors.LabelControl lblemail;
        private DevExpress.XtraEditors.LabelControl tbltglmasuk;
        private DevExpress.XtraEditors.LabelControl lbltglkeluar;
        private System.Windows.Forms.Label lblmandatory2;
        private System.Windows.Forms.Label lblmandatory1;
        private System.Windows.Forms.DateTimePicker dttglmasuk;
        private System.Windows.Forms.DateTimePicker dttglkeluar;
        private DevExpress.Utils.ImageCollection imageCollection;
    }
}
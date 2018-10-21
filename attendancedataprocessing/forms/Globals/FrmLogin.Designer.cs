namespace AttendanceDataProcessing.Forms.Globals
{
    partial class FrmLogin
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
            this.lblusername = new DevExpress.XtraEditors.LabelControl();
            this.lblpassword = new DevExpress.XtraEditors.LabelControl();
            this.btlogin = new DevExpress.XtraEditors.SimpleButton();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.themes = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.SuspendLayout();
            // 
            // lblusername
            // 
            this.lblusername.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblusername.Appearance.Options.UseFont = true;
            this.lblusername.Appearance.Options.UseTextOptions = true;
            this.lblusername.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lblusername.Location = new System.Drawing.Point(32, 21);
            this.lblusername.LookAndFeel.SkinName = "Office 2013";
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(67, 16);
            this.lblusername.TabIndex = 0;
            this.lblusername.Text = "Username :";
            // 
            // lblpassword
            // 
            this.lblpassword.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblpassword.Appearance.Options.UseFont = true;
            this.lblpassword.Appearance.Options.UseTextOptions = true;
            this.lblpassword.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lblpassword.Location = new System.Drawing.Point(34, 51);
            this.lblpassword.LookAndFeel.SkinName = "Office 2013";
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(64, 16);
            this.lblpassword.TabIndex = 2;
            this.lblpassword.Text = "Password :";
            // 
            // btlogin
            // 
            this.btlogin.AppearanceHovered.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btlogin.AppearanceHovered.Options.UseBackColor = true;
            this.btlogin.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btlogin.Location = new System.Drawing.Point(90, 89);
            this.btlogin.LookAndFeel.SkinName = "Office 2013";
            this.btlogin.Name = "btlogin";
            this.btlogin.Size = new System.Drawing.Size(75, 23);
            this.btlogin.TabIndex = 4;
            this.btlogin.Text = "Login";
            this.btlogin.Click += new System.EventHandler(this.btlogin_Click);
            // 
            // txtusername
            // 
            this.txtusername.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtusername.Location = new System.Drawing.Point(105, 18);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(121, 24);
            this.txtusername.TabIndex = 1;
            this.txtusername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtusername.Enter += new System.EventHandler(this.txtusername_Enter);
            this.txtusername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtpassword_KeyDown);
            // 
            // txtpassword
            // 
            this.txtpassword.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtpassword.Location = new System.Drawing.Point(105, 48);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(121, 24);
            this.txtpassword.TabIndex = 3;
            this.txtpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtpassword.Enter += new System.EventHandler(this.txtpassword_Enter);
            this.txtpassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtpassword_KeyDown);
            // 
            // themes
            // 
            this.themes.LookAndFeel.SkinName = "Office 2013";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 124);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.btlogin);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lblusername);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.LookAndFeel.SkinName = "Office 2013";
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmLogin_FormClosing);
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl lblusername;
        private DevExpress.XtraEditors.LabelControl lblpassword;
        private DevExpress.XtraEditors.SimpleButton btlogin;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtpassword;
        private DevExpress.LookAndFeel.DefaultLookAndFeel themes;
    }
}
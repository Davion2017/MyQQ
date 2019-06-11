namespace MyQQ
{
    partial class FrmRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegister));
            this.txtboxPwd1 = new System.Windows.Forms.TextBox();
            this.txtboxSign = new System.Windows.Forms.TextBox();
            this.txtboxName = new System.Windows.Forms.TextBox();
            this.dtpBirth = new System.Windows.Forms.DateTimePicker();
            this.imgboxHeader = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnHeader = new System.Windows.Forms.Button();
            this.txtboxPwd2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.labelNameTip = new System.Windows.Forms.Label();
            this.labelPwd1Tip = new System.Windows.Forms.Label();
            this.labelPwd2Tip = new System.Windows.Forms.Label();
            this.labelSignTip = new System.Windows.Forms.Label();
            this.labelBirthTip = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgboxHeader)).BeginInit();
            this.SuspendLayout();
            // 
            // txtboxPwd1
            // 
            this.txtboxPwd1.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.txtboxPwd1, "txtboxPwd1");
            this.txtboxPwd1.Name = "txtboxPwd1";
            this.txtboxPwd1.TextChanged += new System.EventHandler(this.TxtboxPwd1_TextChanged);
            this.txtboxPwd1.Enter += new System.EventHandler(this.txtboxPwd1_Enter);
            this.txtboxPwd1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtboxPwd1_KeyPress);
            // 
            // txtboxSign
            // 
            resources.ApplyResources(this.txtboxSign, "txtboxSign");
            this.txtboxSign.Name = "txtboxSign";
            this.txtboxSign.TextChanged += new System.EventHandler(this.TxtboxSign_TextChanged);
            this.txtboxSign.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtboxSign_KeyPress);
            // 
            // txtboxName
            // 
            resources.ApplyResources(this.txtboxName, "txtboxName");
            this.txtboxName.Name = "txtboxName";
            this.txtboxName.TextChanged += new System.EventHandler(this.TxtboxName_TextChanged);
            this.txtboxName.Enter += new System.EventHandler(this.TxtboxName_Enter);
            this.txtboxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtboxName_KeyPress);
            this.txtboxName.Leave += new System.EventHandler(this.TxtboxName_Leave);
            // 
            // dtpBirth
            // 
            this.dtpBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            resources.ApplyResources(this.dtpBirth, "dtpBirth");
            this.dtpBirth.Name = "dtpBirth";
            this.dtpBirth.ValueChanged += new System.EventHandler(this.DtpBirth_ValueChanged);
            this.dtpBirth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DtpBirth_KeyPress);
            // 
            // imgboxHeader
            // 
            resources.ApplyResources(this.imgboxHeader, "imgboxHeader");
            this.imgboxHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgboxHeader.Image = global::MyQQ.Properties.Resources.QQ标志;
            this.imgboxHeader.Name = "imgboxHeader";
            this.imgboxHeader.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnHeader
            // 
            this.btnHeader.BackColor = System.Drawing.SystemColors.ControlLight;
            resources.ApplyResources(this.btnHeader, "btnHeader");
            this.btnHeader.Name = "btnHeader";
            this.btnHeader.UseVisualStyleBackColor = false;
            this.btnHeader.Click += new System.EventHandler(this.BtnHeader_Click);
            // 
            // txtboxPwd2
            // 
            resources.ApplyResources(this.txtboxPwd2, "txtboxPwd2");
            this.txtboxPwd2.Name = "txtboxPwd2";
            this.txtboxPwd2.TextChanged += new System.EventHandler(this.TxtboxPwd2_TextChanged);
            this.txtboxPwd2.Enter += new System.EventHandler(this.TxtboxPwd2_Enter);
            this.txtboxPwd2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtboxPwd2_KeyPress);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // rbtnMale
            // 
            resources.ApplyResources(this.rbtnMale, "rbtnMale");
            this.rbtnMale.Checked = true;
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.TabStop = true;
            this.rbtnMale.Tag = "1";
            this.rbtnMale.UseVisualStyleBackColor = true;
            // 
            // rbtnFemale
            // 
            resources.ApplyResources(this.rbtnFemale, "rbtnFemale");
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // labelNameTip
            // 
            resources.ApplyResources(this.labelNameTip, "labelNameTip");
            this.labelNameTip.ForeColor = System.Drawing.Color.Red;
            this.labelNameTip.Name = "labelNameTip";
            // 
            // labelPwd1Tip
            // 
            resources.ApplyResources(this.labelPwd1Tip, "labelPwd1Tip");
            this.labelPwd1Tip.BackColor = System.Drawing.Color.Transparent;
            this.labelPwd1Tip.ForeColor = System.Drawing.Color.Red;
            this.labelPwd1Tip.Name = "labelPwd1Tip";
            // 
            // labelPwd2Tip
            // 
            resources.ApplyResources(this.labelPwd2Tip, "labelPwd2Tip");
            this.labelPwd2Tip.ForeColor = System.Drawing.Color.Red;
            this.labelPwd2Tip.Name = "labelPwd2Tip";
            // 
            // labelSignTip
            // 
            resources.ApplyResources(this.labelSignTip, "labelSignTip");
            this.labelSignTip.ForeColor = System.Drawing.Color.Red;
            this.labelSignTip.Name = "labelSignTip";
            // 
            // labelBirthTip
            // 
            resources.ApplyResources(this.labelBirthTip, "labelBirthTip");
            this.labelBirthTip.ForeColor = System.Drawing.Color.Red;
            this.labelBirthTip.Name = "labelBirthTip";
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRegister.BackgroundImage = global::MyQQ.Properties.Resources.复选标记;
            resources.ApplyResources(this.btnRegister, "btnRegister");
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.Register_btn_Click);
            // 
            // FrmRegister
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::MyQQ.Properties.Resources.注册背景;
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.labelBirthTip);
            this.Controls.Add(this.labelSignTip);
            this.Controls.Add(this.labelPwd2Tip);
            this.Controls.Add(this.labelPwd1Tip);
            this.Controls.Add(this.labelNameTip);
            this.Controls.Add(this.rbtnFemale);
            this.Controls.Add(this.rbtnMale);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtboxPwd2);
            this.Controls.Add(this.btnHeader);
            this.Controls.Add(this.imgboxHeader);
            this.Controls.Add(this.dtpBirth);
            this.Controls.Add(this.txtboxName);
            this.Controls.Add(this.txtboxSign);
            this.Controls.Add(this.txtboxPwd1);
            this.Controls.Add(this.label7);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmRegister";
            this.Activated += new System.EventHandler(this.FrmRegister_Activated);
            this.Load += new System.EventHandler(this.FrmRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgboxHeader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxPwd1;
        private System.Windows.Forms.TextBox txtboxSign;
        private System.Windows.Forms.TextBox txtboxName;
        private System.Windows.Forms.DateTimePicker dtpBirth;
        private System.Windows.Forms.PictureBox imgboxHeader;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnHeader;
        private System.Windows.Forms.TextBox txtboxPwd2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbtnMale;
        private System.Windows.Forms.RadioButton rbtnFemale;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelNameTip;
        private System.Windows.Forms.Label labelPwd1Tip;
        private System.Windows.Forms.Label labelPwd2Tip;
        private System.Windows.Forms.Label labelSignTip;
        private System.Windows.Forms.Label labelBirthTip;
        private System.Windows.Forms.Button btnRegister;
    }
}
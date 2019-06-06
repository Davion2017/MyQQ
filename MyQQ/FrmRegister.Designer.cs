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
            this.pwd_box = new System.Windows.Forms.TextBox();
            this.sign_box = new System.Windows.Forms.TextBox();
            this.name_box = new System.Windows.Forms.TextBox();
            this.birtf_datetimepick = new System.Windows.Forms.DateTimePicker();
            this.head_Img_box = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.header__btn = new System.Windows.Forms.Button();
            this.rpwd_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.register_btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.head_Img_box)).BeginInit();
            this.SuspendLayout();
            // 
            // pwd_box
            // 
            resources.ApplyResources(this.pwd_box, "pwd_box");
            this.pwd_box.Name = "pwd_box";
            // 
            // sign_box
            // 
            resources.ApplyResources(this.sign_box, "sign_box");
            this.sign_box.Name = "sign_box";
            // 
            // name_box
            // 
            resources.ApplyResources(this.name_box, "name_box");
            this.name_box.Name = "name_box";
            this.name_box.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
            // 
            // birtf_datetimepick
            // 
            resources.ApplyResources(this.birtf_datetimepick, "birtf_datetimepick");
            this.birtf_datetimepick.Name = "birtf_datetimepick";
            // 
            // head_Img_box
            // 
            resources.ApplyResources(this.head_Img_box, "head_Img_box");
            this.head_Img_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.head_Img_box.Image = global::MyQQ.Properties.Resources.QQ标志;
            this.head_Img_box.Name = "head_Img_box";
            this.head_Img_box.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // header__btn
            // 
            this.header__btn.BackColor = System.Drawing.SystemColors.ControlLight;
            resources.ApplyResources(this.header__btn, "header__btn");
            this.header__btn.Name = "header__btn";
            this.header__btn.UseVisualStyleBackColor = false;
            this.header__btn.Click += new System.EventHandler(this.Button1_Click);
            // 
            // rpwd_box
            // 
            resources.ApplyResources(this.rpwd_box, "rpwd_box");
            this.rpwd_box.Name = "rpwd_box";
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
            // register_btn
            // 
            this.register_btn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.register_btn.BackgroundImage = global::MyQQ.Properties.Resources.复选标记;
            resources.ApplyResources(this.register_btn, "register_btn");
            this.register_btn.Cursor = System.Windows.Forms.Cursors.Default;
            this.register_btn.Name = "register_btn";
            this.register_btn.UseVisualStyleBackColor = false;
            this.register_btn.Click += new System.EventHandler(this.Register_btn_Click);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // radioButton1
            // 
            resources.ApplyResources(this.radioButton1, "radioButton1");
            this.radioButton1.Checked = true;
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            resources.ApplyResources(this.radioButton2, "radioButton2");
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // name_label
            // 
            resources.ApplyResources(this.name_label, "name_label");
            this.name_label.ForeColor = System.Drawing.Color.Red;
            this.name_label.Name = "name_label";
            // 
            // FrmRegister
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::MyQQ.Properties.Resources.注册背景;
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.register_btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rpwd_box);
            this.Controls.Add(this.header__btn);
            this.Controls.Add(this.head_Img_box);
            this.Controls.Add(this.birtf_datetimepick);
            this.Controls.Add(this.name_box);
            this.Controls.Add(this.sign_box);
            this.Controls.Add(this.pwd_box);
            this.Controls.Add(this.label7);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRegister";
            this.Load += new System.EventHandler(this.FrmRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.head_Img_box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pwd_box;
        private System.Windows.Forms.TextBox sign_box;
        private System.Windows.Forms.TextBox name_box;
        private System.Windows.Forms.DateTimePicker birtf_datetimepick;
        private System.Windows.Forms.PictureBox head_Img_box;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button header__btn;
        private System.Windows.Forms.TextBox rpwd_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button register_btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label name_label;
    }
}
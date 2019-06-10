namespace MyQQ
{
    partial class FrmChat
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
            this.rtxtMsgShow = new System.Windows.Forms.RichTextBox();
            this.rtxtMsgEdite = new System.Windows.Forms.RichTextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.labTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtxtMsgShow
            // 
            this.rtxtMsgShow.Font = new System.Drawing.Font("宋体", 16F);
            this.rtxtMsgShow.Location = new System.Drawing.Point(13, 46);
            this.rtxtMsgShow.Name = "rtxtMsgShow";
            this.rtxtMsgShow.Size = new System.Drawing.Size(676, 243);
            this.rtxtMsgShow.TabIndex = 0;
            this.rtxtMsgShow.Text = "";
            // 
            // rtxtMsgEdite
            // 
            this.rtxtMsgEdite.Font = new System.Drawing.Font("黑体", 16F);
            this.rtxtMsgEdite.Location = new System.Drawing.Point(12, 310);
            this.rtxtMsgEdite.Name = "rtxtMsgEdite";
            this.rtxtMsgEdite.Size = new System.Drawing.Size(677, 96);
            this.rtxtMsgEdite.TabIndex = 1;
            this.rtxtMsgEdite.Text = "";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(500, 415);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "关闭";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(614, 415);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "发送";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // labTitle
            // 
            this.labTitle.AutoSize = true;
            this.labTitle.Font = new System.Drawing.Font("华文行楷", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labTitle.Location = new System.Drawing.Point(297, 9);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(70, 30);
            this.labTitle.TabIndex = 4;
            this.labTitle.Text = "label1";
            // 
            // FrmChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 450);
            this.Controls.Add(this.labTitle);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.rtxtMsgEdite);
            this.Controls.Add(this.rtxtMsgShow);
            this.Name = "FrmChat";
            this.Text = "";
            this.Load += new System.EventHandler(this.FrmChat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtMsgShow;
        private System.Windows.Forms.RichTextBox rtxtMsgEdite;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label labTitle;
    }
}
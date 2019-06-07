namespace MyQQ
{
    partial class FrmAdd
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.labTip = new System.Windows.Forms.Label();
            this.rbtnAccount = new System.Windows.Forms.RadioButton();
            this.rbtnName = new System.Windows.Forms.RadioButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvAccountList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountList)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(13, 36);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(268, 21);
            this.txtSearch.TabIndex = 0;
            // 
            // labTip
            // 
            this.labTip.AutoSize = true;
            this.labTip.Location = new System.Drawing.Point(13, 13);
            this.labTip.Name = "labTip";
            this.labTip.Size = new System.Drawing.Size(149, 12);
            this.labTip.TabIndex = 1;
            this.labTip.Text = "请输入要查找的昵称或账号";
            // 
            // rbtnAccount
            // 
            this.rbtnAccount.AutoSize = true;
            this.rbtnAccount.Checked = true;
            this.rbtnAccount.Location = new System.Drawing.Point(15, 73);
            this.rbtnAccount.Name = "rbtnAccount";
            this.rbtnAccount.Size = new System.Drawing.Size(83, 16);
            this.rbtnAccount.TabIndex = 2;
            this.rbtnAccount.TabStop = true;
            this.rbtnAccount.Text = "按账号查找";
            this.rbtnAccount.UseVisualStyleBackColor = true;
            // 
            // rbtnName
            // 
            this.rbtnName.AutoSize = true;
            this.rbtnName.Location = new System.Drawing.Point(198, 73);
            this.rbtnName.Name = "rbtnName";
            this.rbtnName.Size = new System.Drawing.Size(83, 16);
            this.rbtnName.TabIndex = 3;
            this.rbtnName.Text = "按昵称查找";
            this.rbtnName.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(328, 34);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(98, 55);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "查找";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // dgvAccountList
            // 
            this.dgvAccountList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAccountList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccountList.Location = new System.Drawing.Point(12, 140);
            this.dgvAccountList.Name = "dgvAccountList";
            this.dgvAccountList.RowTemplate.Height = 23;
            this.dgvAccountList.Size = new System.Drawing.Size(427, 298);
            this.dgvAccountList.TabIndex = 5;
            this.dgvAccountList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvAccountList_CellClick);
            // 
            // FrmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 450);
            this.Controls.Add(this.dgvAccountList);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.rbtnName);
            this.Controls.Add(this.rbtnAccount);
            this.Controls.Add(this.labTip);
            this.Controls.Add(this.txtSearch);
            this.Name = "FrmAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加好友";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label labTip;
        private System.Windows.Forms.RadioButton rbtnAccount;
        private System.Windows.Forms.RadioButton rbtnName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvAccountList;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MyQQ
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private Point mousePoint = new Point();

        private void Panel_title_MouseDown(object sender, MouseEventArgs e)
        {
            base.OnMouseDown(e);
            this.mousePoint.X = e.X;
            this.mousePoint.Y = e.Y;
        }

        private void Panel_title_MouseMove(object sender, MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if(e.Button == MouseButtons.Left)
            {
                this.Left = Control.MousePosition.X - mousePoint.X;
                this.Top = Control.MousePosition.Y - mousePoint.Y;
            }
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            string sql = "select account from users order by last_login desc;";
            SqlDataReader sqlData = DBHelper.GetDataReader(sql);
            for (int i = 0; i <= sqlData.FieldCount; i++)
            {
                sqlData.Read();
                cbxAccount.Items.Add(sqlData[0]);
            }
            cbxAccount.SelectedIndex = 0;
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            string account = cbxAccount.Text;
            string passwd = txtPassword.Text;
            SqlDataReader dataReader =  DBHelper.GetDataReader("select * from users where account='" + account + "' and passwd='" + passwd + "';");
            if(dataReader.HasRows)
            {
                DateTime date = DateTime.Now;
                string sql = "update users set last_login='" + date.ToString() + "' where account='" + account + "';";
                DBHelper.GetExcuteNonQuery(sql);
                if(checkRemember.Checked == true)
                {
                    sql = "update users set isRemember='" + 1 + "' where account='" + account + "';";
                }
                else
                {
                    sql = "update users set isRemember='" + 0 + "' where account='" + account + "';";
                }
                DBHelper.GetExcuteNonQuery(sql);
                this.Hide();
                FrmMain frmMain = new FrmMain(cbxAccount.Text);
                frmMain.Show();
            }
            else
            {
                MessageBox.Show("登录失败");
                txtPassword.Clear();
            }
        }

        private void CbxAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "select account, passwd, isRemember from users where account='" + cbxAccount.Text + "'order by last_login desc;";
            SqlDataReader sqlData = DBHelper.GetDataReader(sql);
            try
            {
                sqlData.Read();
                if (sqlData[2].ToString() == "1")
                {
                    txtPassword.Text = sqlData[1].ToString();
                    checkRemember.Checked = true;
                }
                else
                {
                    txtPassword.Clear();
                    checkRemember.Checked = false;
                }
            }
            catch { }
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            FrmRegister frm_reg = new FrmRegister();
            frm_reg.Show();
            
        }
    }
}

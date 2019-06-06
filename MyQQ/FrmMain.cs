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
    /// <summary>
    /// MyQQ登录后主页面
    /// </summary>
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        string account;
        public FrmMain(string account)
        {
            InitializeComponent();
            this.account = account;
        }

        /// <summary>
        /// 添加自定义panel实现窗体拖动及其窗体的关闭操作
        /// </summary>
        private Point mousePoint = new Point();

        private void PanelTitle_MouseMove(object sender, MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (e.Button == MouseButtons.Left)
            {
                this.Left = Control.MousePosition.X - mousePoint.X;
                this.Top = Control.MousePosition.Y - mousePoint.Y;
            }
        }

        private void PanelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            base.OnMouseDown(e);
            this.mousePoint.X = e.X;
            this.mousePoint.Y = e.Y;
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_Load(object sender, EventArgs e)
        {
            string sql = "select * from users where account='" + this.account + "';";
            SqlDataReader sqlData = DBHelper.GetDataReader(sql);
            sqlData.Read();
            this.labUserName.Text = sqlData["name"].ToString();
            this.labSignature.Text = sqlData["signature"].ToString();
        }
    }
}

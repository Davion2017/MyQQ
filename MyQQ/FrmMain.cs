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
        /// <summary>
        /// 当前用户账号
        /// </summary>
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
            UserInfo_Init();
            FriendList_Init();
        }

        private void UserInfo_Init()
        {
            string sql = "select * from users where account='" + this.account + "';";
            SqlDataReader sqlData = DBHelper.GetDataReader(sql);
            sqlData.Read();
            this.labUserName.Text = sqlData["name"].ToString();
            this.labSignature.Text = sqlData["signature"].ToString();
            this.picHead.Image = Image.FromFile("../../../img/beautify_face.png");
        }

        private void FriendList_Init()
        {
            string sql = "select name as '昵称', account as '账号' from users where account in (select friend from friendsList where myAccount='" + this.account + "');";
            SqlDataReader sqlData = DBHelper.GetDataReader(sql);
            DataTable DT = new DataTable();
            DT.Load(sqlData);
            dgvFriendList.DataSource = DT;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            FrmAdd frmAdd = new FrmAdd(this.account);
            frmAdd.Show();
            FriendList_Init();
        }

        private void CheckResquests()
        {
            string sql = "SELECT name, account from users where account=(select DISTINCT From_account from ConfirmationRequest where To_account='" + this.account + "');";
            SqlDataReader sqlData = DBHelper.GetDataReader(sql);
            try
            {
                if (sqlData.HasRows)
                {
                    while (sqlData.Read())
                    {
                        string tips = sqlData["name"].ToString() + "请求加你为好友，是否同意？";
                        DialogResult result = MessageBox.Show(tips, "提醒", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            sql = "insert into friendsList(myAccount, friend) values('" + this.account + "', '" + sqlData["account"] + "');";
                            DBHelper.GetExcuteNonQuery(sql);
                            sql = "insert into friendsList(myAccount, friend) values('" + sqlData["account"] + "', '" + this.account + "');";
                            DBHelper.GetExcuteNonQuery(sql);
                        }
                    }
                }
            }
            catch { }
            finally
            {
                sql = "DELETE FROM ConfirmationRequest WHERE To_account='" + this.account + "';";
                DBHelper.GetExcuteNonQuery(sql);
            }
        }

        private void FrmMain_Activated(object sender, EventArgs e)
        {
            CheckResquests();
            FriendList_Init();
        }
    }
}

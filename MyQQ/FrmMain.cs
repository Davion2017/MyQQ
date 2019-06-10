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
            this.dgvFriendList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void UserInfo_Init()
        {
            string sql = "select * from users where account='" + this.account + "';";
            SqlDataReader sqlData = DBHelper.GetDataReader(sql);
            sqlData.Read();
            this.labUserName.Text = sqlData["name"].ToString();
            this.labSignature.Text = sqlData["signature"].ToString();
            this.picHead.BackgroundImage = Image.FromFile(Application.StartupPath.Replace("MyQQ\\bin\\Debug", "") + sqlData["icon"]);
            this.picHead.BackgroundImageLayout = ImageLayout.Zoom;
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

        private void DgvFriendList_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                dgvFriendList.ClearSelection();
                dgvFriendList.Rows[e.RowIndex].Selected = true;
                dgvFriendList.CurrentCell = dgvFriendList.Rows[e.RowIndex].Cells[e.ColumnIndex];
                ctmsFriendList.Show(MousePosition.X, MousePosition.Y);
            }
        }

        private void Chat()
        {
            FrmChat frmChat = new FrmChat(this.account, dgvFriendList.CurrentRow.Cells["账号"].Value.ToString());
            frmChat.Show();
        }

        private void 删除好友ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string num = dgvFriendList.CurrentRow.Cells["账号"].Value.ToString();
            DialogResult result = MessageBox.Show("是否删除该好友？", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if(result == DialogResult.OK)
            {
                string sql = "delete from friendsList where myAccount='" + this.account + "' and friend='" + num + "';";
                DBHelper.GetExcuteNonQuery(sql);
                sql = "delete from friendsList where myAccount='" + num + "' and friend='" + this.account + "';";
                DBHelper.GetExcuteNonQuery(sql);
            }
            FriendList_Init();
        }

        private void 和TA聊天ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Chat();
        }

        private void Timer_CheckMsg_Tick(object sender, EventArgs e)
        {
            FrmChat[] frmChats = new FrmChat[100];
            int i = 0;
            string sql = "select DISTINCT send_From from msg where send_To='" + this.account + "' and state='1';";
            SqlDataReader sqlData = DBHelper.GetDataReader(sql);
            sql = "UPDATE msg SET state='0' WHERE send_To='" + this.account + "';";
            DBHelper.GetExcuteNonQuery(sql);
            if (sqlData.HasRows)
            {
                try
                {
                    while(sqlData.Read())
                    {
                        string tips = sqlData["send_From"].ToString() + "发来消息，是否查看？";
                        DialogResult result = MessageBox.Show(tips, "提醒", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if(result == DialogResult.Yes)
                        {
                            frmChats[i] = new FrmChat(this.account, sqlData["send_From"].ToString());
                            frmChats[i].Show();
                            i++;
                        }
                    }
                }
                catch { }
            }
        }
    }
}

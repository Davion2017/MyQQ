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
    public partial class FrmChat : FrmBase
    {
        public FrmChat()
        {
            InitializeComponent();
        }
        private string myAccount, friend;
        private string myName, friendName;
        public FrmChat(string myAccount, string friend)
        {
            InitializeComponent();
            this.myAccount = myAccount;
            this.friend = friend;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmChat_Load(object sender, EventArgs e)
        {
            string sql = "select * from users where account='" + this.friend + "';";
            SqlDataReader sqlData = DBHelper.GetDataReader(sql);
            sqlData.Read();
            this.friendName = sqlData["name"].ToString();
            this.labTitle.Text = this.friendName;
            this.Text = "和" + sqlData["name"].ToString() + "聊天";
            rtxtMsgEdite.Focus();
            sql = "select * from users where account='" + this.myAccount + "';";
            sqlData = DBHelper.GetDataReader(sql);
            sqlData.Read();
            this.myName = sqlData["name"].ToString();
            Msg_Update();
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO msg(send_From, send_To, msg_Time, state, content) VALUES('" + this.myAccount + "', '" + this.friend + "', '" + DateTime.Now + "', '1', '" + rtxtMsgEdite.Text + "');";
            DBHelper.GetExcuteNonQuery(sql);
            rtxtMsgShow.Text += this.myName + "\t" + DateTime.Now + "\n";
            rtxtMsgShow.Text += rtxtMsgEdite.Text + "\n\n";
            rtxtMsgEdite.Clear();
            rtxtMsgShow.SelectionStart = rtxtMsgShow.Text.Length;
            rtxtMsgShow.ScrollToCaret();
        }

        private void Msg_Update()
        {
            string sql = "select * from msg where (send_From='" + this.myAccount + "' and send_To='" + this.friend + "')or(send_From='" + this.friend + "' and send_To='" + this.myAccount + "') ORDER BY msg_Time;";
            SqlDataReader sqlData = DBHelper.GetDataReader(sql);
            try
            {
                if(sqlData.HasRows)
                {
                    while(sqlData.Read())
                    {
                        if(sqlData["send_From"].ToString() == this.myAccount)
                        {
                            rtxtMsgShow.Text += this.myName + "\t" + sqlData["msg_Time"] + "\n";
                            rtxtMsgShow.Text += sqlData["content"].ToString() + "\n\n";
                        }
                        else
                        {
                            rtxtMsgShow.Text += this.friendName + "\t" + sqlData["msg_Time"] + "\n";
                            rtxtMsgShow.Text += sqlData["content"].ToString() + "\n\n";
                        }
                        
                    }
                }
            }
            catch { }
            finally
            {
                rtxtMsgShow.SelectionStart = rtxtMsgShow.Text.Length;
                rtxtMsgShow.ScrollToCaret();
            }
        }
    }
}

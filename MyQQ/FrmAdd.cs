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
    public partial class FrmAdd : FrmBase
    {
        public FrmAdd()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 当前用户账号
        /// </summary>
        string account;
        public FrmAdd(string account)
        {
            InitializeComponent();
            this.account = account;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string sql;
            if(rbtnAccount.Checked == true)
            {
                sql = "select account as '账号', name as '昵称', gender as '性别', birthday as '生日', signature as '个性签名' from users where account='" + txtSearch.Text + "';";
            }
            else
            {
                sql = "select account as '账号', name as '昵称', gender as '性别', birthday as '生日', signature as '个性签名' from users where name like '%" + txtSearch.Text + "%' and account not like '" + this.account + "';";
            }
            SqlDataReader sqlData = DBHelper.GetDataReader(sql);
            DataTable DT = new DataTable();
            DT.Load(sqlData);
            dgvAccountList.DataSource = DT;
        }

        private void DgvAccountList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult result = MessageBox.Show("确认添加TA为好友", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                string friendAccount = dgvAccountList.CurrentRow.Cells[0].Value.ToString();
                string sql = "INSERT into ConfirmationRequest(From_account, To_account) VALUES('" + this.account + "','" + friendAccount + "');";
                if(DBHelper.GetExcuteNonQuery(sql) > 0)
                {
                    MessageBox.Show("好友请求发送成功，等待对方同意");
                }
                else
                {
                    MessageBox.Show("发送失败，请重试");
                }
            }
        }
    }
}

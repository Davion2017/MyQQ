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
//添加应用
using System.IO;

namespace MyQQ
{
    public partial class FrmRegister : Form
    {
        // 创建一个结构体用来存储 账号信息
        public struct User
        {
            public string account;
            public string name;
            public string sex;
            public string password;
            public DateTime birth;
            public string sign;
            public string headerimgPath;
        }

        
        // 实例化结构体
        public User user = new User();

        public FrmRegister()
        {
            InitializeComponent();
        }

        private void FrmRegister_Load(object sender, EventArgs e)
        {
            txtboxPwd1.PasswordChar = '*';
            txtboxPwd2.PasswordChar = '*';
        }

        // 本窗口激活时焦点定位到昵称输入框
        private void FrmRegister_Activated(object sender, EventArgs e)
        {
            txtboxName.Focus();
        }

        // 昵称输入框进入事件
        private void TxtboxName_Enter(object sender, EventArgs e)
        {
            labelNameTip.Text = "请输入昵称!";    
        }

        //昵称输入框文本更改事件
        private void TxtboxName_TextChanged(object sender, EventArgs e)
        {
            if (txtboxName.Text.Length > 0 && txtboxName.Text.Length <= 4)
            {
                labelNameTip.Text = "昵称合法!";
                labelNameTip.ForeColor = Color.Green;
                
            }
            else if (txtboxName.Text.Length == 0)
            {
                labelNameTip.Text = "请输入昵称!";
                labelNameTip.ForeColor = Color.Red;
            }
            else
            {
                labelNameTip.Text = "昵称过长,请重新输入!";
                labelNameTip.ForeColor = Color.Red;
            }

            txtboxName.Text = txtboxName.Text.Replace("\n", "").Replace("\t", "").Replace("\r", "");

            if (txtboxName.Text.IndexOf(' ') >= 0)
            {
                labelNameTip.Text = "昵称中不可以有空格!";
                labelNameTip.ForeColor = Color.Red;
            }

        }

        // 昵称输入框按键键入事件:如果按下了回车键或者Tab键,焦点转移到下一个选项
        private void TxtboxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Tab)
            {             
                
                txtboxPwd1.Focus();    
            }
            
        }

        private void TxtboxName_Leave(object sender, EventArgs e)
        {

        }

        // 密码输入框进入事件
        private void txtboxPwd1_Enter(object sender, EventArgs e)
        {
            labelPwd1Tip.Text = "请输入密码!";
        }

        // 密码输入框文本变化事件
        private void TxtboxPwd1_TextChanged(object sender, EventArgs e)
        {
            
            if (txtboxPwd1.Text.Length == 0)
            {
                labelPwd1Tip.Text = "请输入密码!";
                labelPwd1Tip.ForeColor = Color.Red;
            }
            else if (txtboxPwd1.Text.Length <= 6)
            {
                labelPwd1Tip.Text = "密码合法!";
                labelPwd1Tip.ForeColor = Color.Green;
            }
            else
            {
                labelPwd1Tip.Text = "密码必须是6位以内的!!!!!!!";
                labelPwd1Tip.ForeColor = Color.Red;
            }

            txtboxName.Text = txtboxName.Text.Replace("\n", "").Replace("\t", "").Replace("\r", "");
            if (txtboxPwd1.Text.IndexOf(' ') >= 0)
            {
                labelPwd1Tip.Text = "密码中不可以有空格!";
                labelPwd1Tip.ForeColor = Color.Red;
            }

            if (txtboxPwd2.Text == txtboxPwd1.Text)
            {
                labelPwd2Tip.Text = "两次密码输入相同!";
                labelPwd2Tip.ForeColor = Color.Green;
            }
            else
            {
                labelPwd2Tip.Text = "两次密码输入不同,请重新确认密码!";
                labelPwd2Tip.ForeColor = Color.Red;
            }
        }

        // 密码输入框按键键入事件:如果按下了回车键或者Tab键,焦点转移到下一个选项:确认密码输入框
        private void TxtboxPwd1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Tab)
            {
                txtboxPwd2.Focus();
            }
        }

        // 确认密码输入框进入事件
        private void TxtboxPwd2_Enter(object sender, EventArgs e)
        {
            labelPwd2Tip.Text = "请再次输入密码!";
        }

        // 确认密码输入框文本变化事件
        private void TxtboxPwd2_TextChanged(object sender, EventArgs e)
        {
            if(txtboxPwd2.Text.Length >= txtboxPwd1.Text.Length)
            {
                if (txtboxPwd2.Text == txtboxPwd1.Text)
                {
                    labelPwd2Tip.Text = "两次密码输入相同!";
                    labelPwd2Tip.ForeColor = Color.Green;
                }
                else
                {
                    labelPwd2Tip.Text = "两次密码输入不同,请重新确认密码!";
                    labelPwd2Tip.ForeColor = Color.Red;
                }
            }
            else
            {
                labelPwd2Tip.Text = "请再次输入密码确认!";
                labelPwd2Tip.ForeColor = Color.Black;
            }

            txtboxName.Text = txtboxName.Text.Replace("\n", "").Replace("\t", "").Replace("\r", "");
            if (txtboxPwd1.Text.IndexOf(' ') >= 0)
            {
                labelPwd1Tip.Text = "密码中不可以有空格!";
                labelPwd1Tip.ForeColor = Color.Red;
            }
            if (txtboxPwd2.Text.Length == 0)
            {
                labelPwd2Tip.Text = "请再次输入密码确认!";
                labelPwd2Tip.ForeColor = Color.Red;
            }
        }

        // 确认密码输入框按键键入事件:如果按下了回车键或者Tab键,焦点转移到下一个选项:个性签名输入框
        private void TxtboxPwd2_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Tab)
            {
                txtboxSign.Focus();
            }
        }

        //个性签名输入框文本更改事件
        private void TxtboxSign_TextChanged(object sender, EventArgs e)
        {
            txtboxName.Text = txtboxName.Text.Replace("\n", "").Replace("\t", "").Replace("\r", "");
            labelSignTip.Text = "1";
        }

        // 个性签名输入框按键键入事件:如果按下了回车键或者Tab键,焦点转移到下一个选项:日期时间选择框
        private void TxtboxSign_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Tab)
            {
                dtpBirth.Focus();
            }
        }

        //日期事件选择器改变事件
        private void DtpBirth_ValueChanged(object sender, EventArgs e)
        {
            if(DateTime.Compare(DateTime.Today, dtpBirth.Value) <= 0)
            {
                labelBirthTip.Text = "不可以选择在今天之后的日期!";
                labelBirthTip.ForeColor = Color.Red;
            }
            else
            {
                labelBirthTip.Text = "生日已选择:"+dtpBirth.Value.ToShortDateString();
                labelBirthTip.ForeColor = Color.Green;
            }
        }



        // 日期时间选择器 按钮按下事件
        private void DtpBirth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Tab)
            {
                Register_btn_Click(sender, e);
            }
        }

        // 头像选择事件
        private void BtnHeader_Click(object sender, EventArgs e)
        {

            //定义打开文件的类型,图片格式
            openFileDialog1.Filter = "bmp文件(*.bmp)|*.bmp|gif文件(*.gif)|*.gif|jpg文件(*.jpg)|*.jpg|ico文件(*.ico)|*.ico";

            //获取打开文件返回值
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.user.headerimgPath = openFileDialog1.FileName;
                imgboxHeader.Image = Image.FromFile(this.user.headerimgPath);
            }
            else
            {
                this.user.headerimgPath = Application.StartupPath.Replace("\\bin\\Debug", "") + "/Resources/QQ标志.ico";
                MessageBox.Show("未选择头像,将使用默认头像");

            }
        }

        // 注册信息正确性验证
        private bool Data_Check(object sender, EventArgs e)
        {
            bool check_bool = true;
            if (labelNameTip.ForeColor == Color.Red)
            {
                txtboxName.Focus();
                check_bool = false;
            }
            else if (labelPwd1Tip.ForeColor == Color.Red)
            {
                txtboxPwd1.Focus();
                check_bool = false;
            }
            else if (labelPwd2Tip.ForeColor == Color.Red)
            {
                txtboxPwd2.Focus();
                check_bool = false;
            }
            else if (labelBirthTip.ForeColor == Color.Red)
            {
                dtpBirth.Focus();
                check_bool = false;
            }
            else
            {
                this.user.name = txtboxName.Text;
                this.user.password = txtboxPwd1.Text;
                this.user.sign = txtboxSign.Text;
                this.user.birth = dtpBirth.Value;
            }

            if (rbtnMale.Checked)
            {
                this.user.sex = "男";
            }
            else
            {
                this.user.sex = "女";
            }
            return check_bool;
        }

        //注册按钮按下事件
        private void Register_btn_Click(object sender, EventArgs e)
        {

            if (Data_Check(sender, e))
            {
                DialogResult answer = MessageBox.Show("请再次确认你的注册信息!!\n昵称:"+this.user.name+"\n密码:"+this.user.password+"\n性别:"+this.user.sex+"\n个性签名:"+this.user.sign+"\n生日:"+this.user.birth.ToShortDateString(), "确认注册", MessageBoxButtons.YesNo);
                if(answer is DialogResult.Yes)
                {
                    string sql = "select top 1 account from users  order by id desc;";
                    SqlDataReader sqlData = DBHelper.GetDataReader(sql);
                    sqlData.Read();
                    this.user.account = (Convert.ToInt32(sqlData[0].ToString()) + 1).ToString();

                    //复制头像框保存至头像图片目录并记录
                    File.Copy(this.user.headerimgPath, Application.StartupPath.Replace("\\MyQQ\\bin\\Debug", "") + "/img/headimage/" + this.user.account + ".jpg");
                    this.user.headerimgPath = "/img/headimage/" + this.user.account + ".jpg";
                    MessageBox.Show("请记住你的账号:"+ this.user.account,"Tips",MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // 向用户表中插入记录
                    string sqlInsert = "insert into users values('"+this.user.account+"','"+ this.user.password+"','"+ this.user.name + "','"+this.user.sex+"','"+this.user.birth+"','"+this.user.sign+"','"+this.user.headerimgPath+"','"+ "','"+""+"');";
                    DBHelper.GetExcuteNonQuery(sqlInsert);

                }
                else
                {
                    txtboxName.Focus();
                }
            }
            else
            {
                MessageBox.Show("注册失败,请确保注册信息无误!");
                //string sql = "select top 1 account from users  order by id desc;";
                //SqlDataReader sqlData = DBHelper.GetDataReader(sql);
                //bool flag = false;
                //while (flag == false)
                //{
                //    try
                //    {
                //        sqlData.Read();
                //        this.user.account = (Convert.ToInt32(sqlData[0].ToString())+1).ToString();
                //        MessageBox.Show(this.user.account);
                        
                //    }
                //    catch { flag = true; }
                //}
            }
        }


        

        
    }
}



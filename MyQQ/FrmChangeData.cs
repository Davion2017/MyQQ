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
    public partial class FrmChangeData : FrmBase
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
        public FrmChangeData(string account)
        {
            this.user.account = account;
            InitializeComponent();
        }

        

        private void FrmChangeData_Load(object sender, EventArgs e)
        {
            txtboxPwd1.PasswordChar = '*';
            txtboxPwd2.PasswordChar = '*';
            string sql = "select * from users  where account='"+ this.user.account+"';";
            SqlDataReader sqlData = DBHelper.GetDataReader(sql);
            sqlData.Read();
            this.user.account = sqlData[1].ToString();
            this.user.password = sqlData[2].ToString();
            this.user.name = sqlData[3].ToString();
            this.user.sex = sqlData[4].ToString();
            this.user.birth = (DateTime)sqlData[5];
            this.user.sign = sqlData[6].ToString();
            this.user.headerimgPath = sqlData[7].ToString();


            imgboxHeader.Image = Image.FromFile(Application.StartupPath.Replace("\\MyQQ\\bin\\Debug", "") + "/img/headimage/" + this.user.account + ".jpg");

            

            txtboxName.Text = this.user.name;
            txtboxPwd1.Text = this.user.password;
            txtboxPwd2.Text = this.user.password;
            txtboxSign.Text = this.user.sign;
            if(this.user.sex == "男")
            {
                rbtnMale.Checked = true;
            }
            else
            {
                rbtnFemale.Checked = true;
            }
            dtpBirth.Value = this.user.birth;



        }

        private void FrmChangeData_Activated(object sender, EventArgs e)
        {
            txtboxName.Focus();
        }

        private void TxtboxName_Enter(object sender, EventArgs e)
        {
            
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


        // 头像更换按钮点击事件
        //private void BtnHeaderChange_Click(object sender, EventArgs e)
        //{
        //    //定义打开文件的类型,图片格式
        //    openFileDialog1.Filter = "jpg文件(*.jpg)|*.jpg|ico文件(*.ico)|*.ico|bmp文件(*.bmp)|*.bmp|gif文件(*.gif)|*.gif";

        //    //获取打开文件返回值
        //    if (openFileDialog1.ShowDialog() == DialogResult.OK)
        //    {
        //        this.user.headerimgPath = openFileDialog1.FileName;
        //        imgboxHeader.Image = Image.FromFile(this.user.headerimgPath);

        //        //更换数据库中的头像文件
        //        try
        //        {
        //            File.Move(Application.StartupPath.Replace("\\MyQQ\\bin\\Debug", "") + "/img/headimage/" + this.user.account + ".jpg", Application.StartupPath.Replace("\\MyQQ\\bin\\Debug", "") + "/img/headimage/historyHeadImage/" + this.user.account + DateTime.Now.ToLongTimeString().Replace("/", "-").Replace(":", "_") + ".jpg");

        //            File.Copy(this.user.headerimgPath, Application.StartupPath.Replace("\\MyQQ\\bin\\Debug", "") + "/img/headimage/" + this.user.account + ".jpg");
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show(ex.ToString());
        //        }
        //        finally
        //        {
        //            MessageBox.Show("移动从成功");
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("未选择头像,将使用原有头像");

        //    }
        //}

        // 确认密码输入框文本变化事件
        private void TxtboxPwd2_TextChanged(object sender, EventArgs e)
        {
            if (txtboxPwd2.Text.Length >= txtboxPwd1.Text.Length)
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

        //个性签名输入框文本更改事件
        private void TxtboxSign_TextChanged(object sender, EventArgs e)
        {
            txtboxName.Text = txtboxName.Text.Replace("\n", "").Replace("\t", "").Replace("\r", "");
            labelSignTip.Text = "请输入个性签名!";
        }

        //日期事件选择器改变事件
        private void DtpBirth_ValueChanged(object sender, EventArgs e)
        {
            if (DateTime.Compare(DateTime.Today, dtpBirth.Value) <= 0)
            {
                labelBirthTip.Text = "不可以选择在今天之后的日期!";
                labelBirthTip.ForeColor = Color.Red;
            }
            else
            {
                labelBirthTip.Text = "生日已选择:" + dtpBirth.Value.ToShortDateString();
                labelBirthTip.ForeColor = Color.Green;
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


        // 修改信息按钮按下事件
        private void BtnChange_Click(object sender, EventArgs e)
        {
            
            if (Data_Check(sender, e))
            {
                DialogResult answer = MessageBox.Show("请再次确认你的更改后的信息!!\n昵称:" + this.user.name + "\n密码:" + this.user.password + "\n性别:" + this.user.sex + "\n个性签名:" + this.user.sign + "\n生日:" + this.user.birth.ToShortDateString(), "修改", MessageBoxButtons.YesNo);
                if (answer is DialogResult.Yes)
                {


                    // 向用户表中修改记录
                    string sqlInsert = "update users set passwd = '" + this.user.password+"', name = '"+this.user.name + "', gender = '" +this.user.sex+"', birthday = '" +this.user.birth+"', signature = '"+this.user.sign+"' where account = '"+this.user.account+"'; ";
                    DBHelper.GetExcuteNonQuery(sqlInsert);

                }
                else
                {
                    txtboxName.Focus();
                }
            }
            else
            {
                MessageBox.Show("更改失败,请确保更改的信息无误!");
            }
        }

       
    }
}

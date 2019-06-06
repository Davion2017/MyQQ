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
        public FrmRegister()
        {
            InitializeComponent();
        }

        private void FrmRegister_Load(object sender, EventArgs e)
        {
            pwd_box.PasswordChar = '*';
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            //定义打开文件的类型,图片格式
            openFileDialog1.Filter = "bmp文件(*.bmp)|*.bmp|gif文件(*.gif)|*.gif|jpg文件(*.jpg)|*.jpg|ico文件(*.ico)|*.ico";

            //获取打开文件返回值
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fullpath = openFileDialog1.FileName;
                head_Img_box.Image = Image.FromFile(fullpath);
                MessageBox.Show(fullpath);
            }
            else
            {
                MessageBox.Show("图片打开失败");
            }



            

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

            name_label.ForeColor = Color.Transparent;
            name_label.BackColor = Color.Transparent;
            if (name_box.TextLength >= 6 )
            {
                name_label.Text = "不合法:昵称过长";
                name_label.ForeColor = Color.Red;

            }
            else if (name_box.TextLength == 0)
            {
                name_label.Text = "不合法:昵称不可为空";
                name_label.ForeColor = Color.Red;
            }
            else
            {
                name_label.Text = "合法";
                name_label.ForeColor = Color.Black;
            }

        }

        private void Register_btn_Click(object sender, EventArgs e)
        {
            if (name_label.Text == "合法")
            {
                MessageBox.Show("昵称合法");
            }
            else
            {
                string tip = name_box.Text+"昵称不合法"+"密码:"+pwd_box.Text;
                MessageBox.Show(tip);
            }
        }
    }
}

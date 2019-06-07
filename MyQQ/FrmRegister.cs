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
            txtboxPwd1.PasswordChar = '*';
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            //定义打开文件的类型,图片格式
            openFileDialog1.Filter = "bmp文件(*.bmp)|*.bmp|gif文件(*.gif)|*.gif|jpg文件(*.jpg)|*.jpg|ico文件(*.ico)|*.ico";

            //获取打开文件返回值
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fullpath = openFileDialog1.FileName;
                imgboxHeader.Image = Image.FromFile(fullpath);
                MessageBox.Show(fullpath);
            }
            else
            {
                MessageBox.Show("图片打开失败");
               
            }

        }

        private void Register_btn_Click(object sender, EventArgs e)
        {

        }


        private void Pwd_box_Enter(object sender, EventArgs e)
        {
        }



        private void FrmRegister_Activated(object sender, EventArgs e)
        {
            txtboxName.Focus();
        }
    }
}



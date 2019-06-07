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
    public partial class FrmBase : Form
    {
        public FrmBase()
        {
            InitializeComponent();
            skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            skinEngine1.SkinFile = Application.StartupPath.Replace("\\bin\\Debug", "") + "/Resources/office2007.ssk";
            //MessageBox.Show(Application.StartupPath.ToString().Replace("\\bin\\Debug", ""));
        }
    }
}

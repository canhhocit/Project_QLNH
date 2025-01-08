using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Restaurant_Manager
{
    public partial class Form_AccountI_nfo : Form
    {
        public Form_AccountI_nfo()
        {
            InitializeComponent();
            Loaddatagrv();
        }
        //đang dở thì gửi xuân
        private void Loaddatagrv()
        {
            String query = "SELECT * FROM Account";
            Modify modify = new Modify();
            DataTable dt = modify.GetDataTable(query);
            dtgv_AccountInf.DataSource = dt;


        }
        private void ckb_yes_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_yes.Checked)
            {
                btn_Sua.Enabled = true;
                txbUserName.Enabled = true;
                txbDisplayname.Enabled = true;
                txbPassWord.Enabled = true;

                txbUserName.ReadOnly = false;
                txbDisplayname.ReadOnly = false;
                txbPassWord.ReadOnly = false;
            }
            else
            {
                btn_Sua.Enabled = false;
                txbUserName.Enabled = false;
                txbDisplayname.Enabled = false;
                txbPassWord.Enabled = false;

                txbUserName.ReadOnly = true;
                txbDisplayname.ReadOnly = true;
                txbPassWord.ReadOnly = true;
            }
        }
    }
}

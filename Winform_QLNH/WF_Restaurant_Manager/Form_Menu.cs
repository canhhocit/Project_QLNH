﻿using System;
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
    public partial class Form_Menu : Form
    {
        public Form_Menu()
        {
            InitializeComponent();
        }
        private Form currentFormChild;
        private void OpenChildForm(Form ChildForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panelBody.Controls.Add(ChildForm);
            panelBody.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }
        private void mn_Home_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            btn_Themmon.Enabled = true;
            btn_Suamon.Enabled = true;
            btn_Xoamon.Enabled = true;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            btn_Themmon.Enabled = true;
            btn_Suamon.Enabled = true;
            btn_Xoamon.Enabled = true;
        }
        private void mns1_ThongtinTK_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form_AccountI_nfo());
            btn_Themmon.Enabled = false;
            btn_Suamon.Enabled = false;
            btn_Xoamon.Enabled = false;
        }

        private void mns1_Dangky_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form_Dangky());
            btn_Themmon.Enabled = false;
            btn_Suamon.Enabled = false;
            btn_Xoamon.Enabled = false;
        }
        private void mns1_Dangxuat_Click(object sender, EventArgs e)
        {
            //thực hiện đăng xuất ra ngoài màn hình form đăng nhập
            Form1 form = new Form1();
            this.Hide();
            form.Show();
            //this.Close();
        }

        private void mn_Maytinh_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form_Maytinh());
            btn_Themmon.Enabled = false;
            btn_Suamon.Enabled = false;
            btn_Xoamon.Enabled = false;
        }

        private void mn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form_Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát chương trình ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }




}

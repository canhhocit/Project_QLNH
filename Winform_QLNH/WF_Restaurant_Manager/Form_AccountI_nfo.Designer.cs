namespace WF_Restaurant_Manager
{
    partial class Form_AccountI_nfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgv_AccountInf = new System.Windows.Forms.DataGridView();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DisplayName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PassWord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_left = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.txbPassWord = new System.Windows.Forms.TextBox();
            this.txbDisplayname = new System.Windows.Forms.TextBox();
            this.txbUserName = new System.Windows.Forms.TextBox();
            this.lb_thongbao = new System.Windows.Forms.Label();
            this.ckb_yes = new System.Windows.Forms.CheckBox();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_AccountInf)).BeginInit();
            this.panel_left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv_AccountInf
            // 
            this.dtgv_AccountInf.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgv_AccountInf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_AccountInf.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserName,
            this.DisplayName,
            this.PassWord,
            this.Email});
            this.dtgv_AccountInf.Location = new System.Drawing.Point(533, 1);
            this.dtgv_AccountInf.Name = "dtgv_AccountInf";
            this.dtgv_AccountInf.RowHeadersWidth = 51;
            this.dtgv_AccountInf.RowTemplate.Height = 24;
            this.dtgv_AccountInf.Size = new System.Drawing.Size(620, 509);
            this.dtgv_AccountInf.TabIndex = 0;
            // 
            // UserName
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.UserName.DefaultCellStyle = dataGridViewCellStyle1;
            this.UserName.HeaderText = "Tên tài khoản";
            this.UserName.MinimumWidth = 6;
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            this.UserName.Width = 125;
            // 
            // DisplayName
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.DisplayName.DefaultCellStyle = dataGridViewCellStyle2;
            this.DisplayName.HeaderText = "Tên hiển thị";
            this.DisplayName.MinimumWidth = 6;
            this.DisplayName.Name = "DisplayName";
            this.DisplayName.ReadOnly = true;
            this.DisplayName.Width = 150;
            // 
            // PassWord
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.PassWord.DefaultCellStyle = dataGridViewCellStyle3;
            this.PassWord.HeaderText = "Mật khẩu";
            this.PassWord.MinimumWidth = 6;
            this.PassWord.Name = "PassWord";
            this.PassWord.ReadOnly = true;
            this.PassWord.Width = 125;
            // 
            // Email
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Email.DefaultCellStyle = dataGridViewCellStyle4;
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 200;
            // 
            // panel_left
            // 
            this.panel_left.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel_left.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_left.Controls.Add(this.ckb_yes);
            this.panel_left.Controls.Add(this.btn_Sua);
            this.panel_left.Controls.Add(this.pictureBox1);
            this.panel_left.Controls.Add(this.label4);
            this.panel_left.Controls.Add(this.label3);
            this.panel_left.Controls.Add(this.label2);
            this.panel_left.Controls.Add(this.label1);
            this.panel_left.Controls.Add(this.txbEmail);
            this.panel_left.Controls.Add(this.txbPassWord);
            this.panel_left.Controls.Add(this.txbDisplayname);
            this.panel_left.Controls.Add(this.txbUserName);
            this.panel_left.Controls.Add(this.lb_thongbao);
            this.panel_left.Location = new System.Drawing.Point(-2, 1);
            this.panel_left.Name = "panel_left";
            this.panel_left.Size = new System.Drawing.Size(535, 509);
            this.panel_left.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(71, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 19);
            this.label4.TabIndex = 56;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(58, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 19);
            this.label3.TabIndex = 55;
            this.label3.Text = "Mật khẩu\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(48, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 19);
            this.label2.TabIndex = 54;
            this.label2.Text = "Tên hiển thị";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(36, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 19);
            this.label1.TabIndex = 53;
            this.label1.Text = "Tên đăng nhập";
            // 
            // txbEmail
            // 
            this.txbEmail.Enabled = false;
            this.txbEmail.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbEmail.ForeColor = System.Drawing.Color.Black;
            this.txbEmail.Location = new System.Drawing.Point(182, 340);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.ReadOnly = true;
            this.txbEmail.Size = new System.Drawing.Size(239, 25);
            this.txbEmail.TabIndex = 52;
            // 
            // txbPassWord
            // 
            this.txbPassWord.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbPassWord.ForeColor = System.Drawing.Color.Black;
            this.txbPassWord.Location = new System.Drawing.Point(182, 287);
            this.txbPassWord.Name = "txbPassWord";
            this.txbPassWord.ReadOnly = true;
            this.txbPassWord.Size = new System.Drawing.Size(239, 25);
            this.txbPassWord.TabIndex = 51;
            // 
            // txbDisplayname
            // 
            this.txbDisplayname.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbDisplayname.ForeColor = System.Drawing.Color.Black;
            this.txbDisplayname.Location = new System.Drawing.Point(182, 236);
            this.txbDisplayname.Name = "txbDisplayname";
            this.txbDisplayname.ReadOnly = true;
            this.txbDisplayname.Size = new System.Drawing.Size(239, 25);
            this.txbDisplayname.TabIndex = 50;
            // 
            // txbUserName
            // 
            this.txbUserName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbUserName.ForeColor = System.Drawing.Color.Black;
            this.txbUserName.Location = new System.Drawing.Point(182, 187);
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.ReadOnly = true;
            this.txbUserName.Size = new System.Drawing.Size(239, 25);
            this.txbUserName.TabIndex = 49;
            // 
            // lb_thongbao
            // 
            this.lb_thongbao.AutoSize = true;
            this.lb_thongbao.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lb_thongbao.Enabled = false;
            this.lb_thongbao.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_thongbao.ForeColor = System.Drawing.Color.Maroon;
            this.lb_thongbao.Location = new System.Drawing.Point(14, 393);
            this.lb_thongbao.Name = "lb_thongbao";
            this.lb_thongbao.Size = new System.Drawing.Size(213, 17);
            this.lb_thongbao.TabIndex = 46;
            this.lb_thongbao.Text = "Bạn có muốn thay đổi thông tin:";
            this.lb_thongbao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ckb_yes
            // 
            this.ckb_yes.AutoSize = true;
            this.ckb_yes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckb_yes.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ckb_yes.Location = new System.Drawing.Point(287, 393);
            this.ckb_yes.Name = "ckb_yes";
            this.ckb_yes.Size = new System.Drawing.Size(46, 21);
            this.ckb_yes.TabIndex = 60;
            this.ckb_yes.Text = "có";
            this.ckb_yes.UseVisualStyleBackColor = true;
            this.ckb_yes.CheckedChanged += new System.EventHandler(this.ckb_yes_CheckedChanged);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Sua.Enabled = false;
            this.btn_Sua.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Sua.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Sua.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Sua.Image = global::WF_Restaurant_Manager.Properties.Resources.iconEdit;
            this.btn_Sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sua.Location = new System.Drawing.Point(231, 445);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(119, 42);
            this.btn_Sua.TabIndex = 59;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WF_Restaurant_Manager.Properties.Resources.Userrr1;
            this.pictureBox1.Location = new System.Drawing.Point(182, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            // 
            // Form_AccountI_nfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1151, 509);
            this.Controls.Add(this.panel_left);
            this.Controls.Add(this.dtgv_AccountInf);
            this.DoubleBuffered = true;
            this.Name = "Form_AccountI_nfo";
            this.Text = "Thông tin tài khoản";
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_AccountInf)).EndInit();
            this.panel_left.ResumeLayout(false);
            this.panel_left.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv_AccountInf;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DisplayName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PassWord;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.Panel panel_left;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.TextBox txbPassWord;
        private System.Windows.Forms.TextBox txbDisplayname;
        private System.Windows.Forms.TextBox txbUserName;
        private System.Windows.Forms.Label lb_thongbao;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.CheckBox ckb_yes;
    }
}
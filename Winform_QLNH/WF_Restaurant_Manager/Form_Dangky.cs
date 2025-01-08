using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;//them
using System.Net.Mail;//them
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WF_Restaurant_Manager
{
    public partial class Form_Dangky : Form
    {

        public Form_Dangky()
        {
            InitializeComponent();

        }
        //otp random
        private string otp = "";
        private string GenerateOtp(int length = 6)
        {
            Random random = new Random();
            //string otp = "";
            for (int i = 0; i < length; i++)
            {
                otp += random.Next(0, 10).ToString();
            }
            return otp;
        }

        // Hàm gửi Mail lấy lại mật khẩu
        private void SendOtpEmail(string recipientEmail, string otpCode)
        {
            try
            {
                // Cấu hình SMTP
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential("jacksky2268@gmail.com", "aftt hfbn usdx ycrk"),
                    EnableSsl = true,
                };

                // Tạo email
                MailMessage mailMessage = new MailMessage
                {
                    From = new MailAddress("jacksky2268@gmail.com"),
                    Subject = "Nhà hàng 'Bốn mùa 86' gửi mã OTP",
                    Body = $"Mã OTP của bạn là: {otpCode} .",
                    IsBodyHtml = true
                };

                // Thêm người nhận
                mailMessage.To.Add(recipientEmail);

                // Hiển thị thông báo đang gửi
                lb_thongbao.Text = "Mã của bạn đang được gửi...";
                Application.DoEvents(); // Cập nhật giao diện ngay lập tức

                // Gửi email
                smtpClient.Send(mailMessage);

                // Xóa thông báo và hiển thị thành công
                lb_thongbao.Text = "";
                MessageBox.Show("Gửi OTP thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi gửi email: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // doi tuong modify
        Modify modify = new Modify();
        private void btn_Send_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu email trống
            if (string.IsNullOrWhiteSpace(txbEmail.Text))
            {
                lb_thongbao.Text = "Vui lòng nhập email";
                return;
            }

            string email = txbEmail.Text.Trim(); // Lấy email từ TextBox và loại bỏ khoảng trắng
            string sql = "SELECT Email FROM Account WHERE Email = @Email";

            try
            {
                // Tạo kết nối đến cơ sở dữ liệu và thực thi câu lệnh SQL
                using (SqlConnection connection = ConnectDB.GetSqlConnection())
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        // Thêm tham số để tránh SQL Injection
                        command.Parameters.AddWithValue("@Email", email);

                        // Kiểm tra kết quả trả về
                        var result = command.ExecuteScalar();
                        if (result != null) // Email không tồn tại
                        {
                            MessageBox.Show("Email đã tồn tại trước đó", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                }

                // Nếu email tồn tại, tạo mã OTP và gửi qua email
                string OTP = GenerateOtp();  // Tạo mã OTP
                SendOtpEmail(email, OTP);    // Gửi OTP qua email
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Dangky_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Đăng ký tài khoản thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //txbUserName.Text = ""; txbDisplayname.Text = "";
            //txbEmail.Text = ""; txbPassWord.Text = "";
            //txbOTP.Text = "";
            if (txbUserName.Text.Trim() == "" || txbDisplayname.Text.Trim() == "" || txbPassWord.Text.Trim() == "" || txbEmail.Text.Trim() == "" || txbOTP.Text.Trim() == "")
            {
                lb_thongbao.Text = "Vui lòng nhập đủ thông tin";
            }
            else
            {
                if (txbOTP.Text == otp)// ktra ma otp
                {
                    string Username = txbUserName.Text;
                    string Displayname = txbDisplayname.Text;
                    string Password = txbPassWord.Text;
                    string Email = txbEmail.Text;
                    string query = "INSERT INTO Account(UserName, DisplayName, PassWord, Email) VALUES ('"
                                    + Username + "', '" + Displayname + "', '"
                                    + Password + "', '" + Email + "')";
                    modify.taikhoan(query);
                    MessageBox.Show("Đăng ký tài khoản thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txbUserName.Text = ""; txbDisplayname.Text = "";
                    txbEmail.Text = ""; txbPassWord.Text = "";
                    txbOTP.Text = "";
                }
                else
                {
                    MessageBox.Show("Mã OTP của bạn không đúng, vui lòng kiểm tra lại email !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}

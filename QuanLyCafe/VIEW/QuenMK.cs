using QuanLyCafe.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCafe.VIEW
{
    // hello
    // test
    public partial class QuenMK : Form
    {
        public QuenMK()
        {
            InitializeComponent();
        }
        int otp;
        Random random = new Random();
  
       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

  

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void QuenMK_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (LoginDAO.Instance.quenmk(textBox4.Text, textBox1.Text))
            {
                otp = random.Next(100000, 1000000);
                var fromAddress = new MailAddress("thuctran200411@gmail.com");
                var toAddress = new MailAddress(textBox1.ToString());
                const string frompass = "iavo uipe yfjv rusq";
                const string subject = "OTP code";
                string bodey = otp.ToString();
                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, frompass),
                    Timeout = 200000
                };
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = bodey
                })
                {
                    smtp.Send(message);
                }
                MessageBox.Show("OTP đã được gửi qua mail");
            }
            else
            {
                MessageBox.Show("Lỗi không trùng mail với mã nhân viên");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (otp.ToString().Equals(textBox2.Text))
            {
                if (textBox3.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu mới");
                }
                else
                {
                    LoginDAO.Instance.update(textBox4.Text, textBox3.Text);
                    MessageBox.Show("Đổi mật khẩu thành công");
                }

            }
            else
            {
                MessageBox.Show("Sai mã OTP");

            }
        }
    }
}

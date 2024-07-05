using QuanLyCafe.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCafe.VIEW.UC
{
    public partial class changepass : UserControl
    {
        string id; 
        public changepass(string id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void changepass_Load(object sender, EventArgs e)
        {

        }


        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {

                if (LoginDAO.Instance.login(id, textBox2.Text))
                {
                    if (textBox2.Text == textBox3.Text)
                    {
                        MessageBox.Show("Mật khẩu mới và mật khẩu cũ không được trùng nhau");
                    }
                    else
                    {
                        if (textBox3.Text != textBox4.Text)
                        {
                            MessageBox.Show("Mật khẩu nhập lại không trùng khớp với mật khẩu mới");
                        }
                        else
                        {
                            LoginDAO.Instance.update(id, textBox3.Text);
                            MessageBox.Show("Đổi mật khẩu thành công");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đúng mật khẩu cũ");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
        }
    }
}

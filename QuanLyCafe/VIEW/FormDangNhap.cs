using QuanLyCafe.DAO;
using QuanLyCafe.VIEW;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace QuanLyCafe
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void unhidePass_Click(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = true;
            unhidePass.Hide();
            hidePass.Show();
        }

        private void hidePass_Click(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = false;
            unhidePass.Show();
            hidePass.Hide();
        }

        private void textBoxPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox3.SelectedItem.ToString() == "Nhân viên quản lý")
            {
                textBox4.Text = "QL";
            }    
            else if (comboBox3.SelectedItem.ToString() == "Nhân viên phục vụ")
            {
                textBox4.Text = "NV";
            }

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tmp = textBox4.Text.Substring(0, Math.Min(textBox4.Text.Length, 2));

            if (tmp == "QL")
            {
                if(comboBox3.SelectedItem.ToString() != "Nhân viên quản lý")
                {
                    MessageBox.Show("Vui lòng giữ đúng quy tắc mã nhân viên !" , "Lỗi ");
                }
                else
                {
                    string name = textBox2.Text;
                    string id = textBox4.Text;
                    string date = dateTimePicker1.Text;
                    string pass = textBox3.Text;
                    string gender;
                    if (radioButton3.Checked == true)
                    {
                         gender = radioButton3.Text;
                    }
                    else
                    {
                        gender = radioButton4.Text;
                    }
                    string address = textBox9.Text;
                    string phone = textBox8.Text;
                    if (checkid(id) == false)
                    {
                        if (infor(name, id, date, gender, address, phone) > 0)
                        {
                            signup(id, pass);
                            MessageBox.Show("Done");
                        }
                        else
                        {
                            MessageBox.Show("Lỗi không tạo được");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lỗi trùng mã quản lý");
                    }

                }
                
            } 
            else if(tmp == "NV")
            {
                if (comboBox3.SelectedItem.ToString() != "Nhân viên phục vụ")
                {
                    MessageBox.Show("Vui lòng giữ đúng quy tắc mã nhân viên !", "Lỗi ");
                }
                else
                {
                    string name = textBox2.Text;
                    string id = textBox4.Text;
                    string date = dateTimePicker1.Text;
                    string pass = textBox3.Text;
                    string gender;
                    if (radioButton3.Checked == true)
                    {
                        gender = radioButton3.Text;
                    }
                    else
                    {
                        gender = radioButton4.Text;
                    }
                    string address = textBox9.Text;
                    string phone = textBox8.Text;
                    if (checkid(id) == false)
                    {
                        if (infor(name, id, date, gender, address, phone) > 0 )
                    {
                        signup(id, pass);
                        MessageBox.Show("Done");
                    }
                    else
                    {
                        MessageBox.Show("Lỗi không tạo được");
                    }
                    }
                    else
                    {
                        MessageBox.Show("Lỗi trùng mã nhân viên ");
                    }

                    textBox2.Text = "";
                    textBox4.Text ="";
                    dateTimePicker1.Text ="";
                    textBox3.Text ="";
                    textBox8.Text = "";
                    textBox9.Text = "";
                }

            }
            else
            {
                MessageBox.Show("Vui lòng giữ đúng quy tắc mã nhân viên !", "Lỗi ");
            }
        }
        private int infor(string name, string id,string date, string gender, string address, string phone)
        {
            return LoginDAO.Instance.inforemployee(id, name,date, gender, address, phone);
        }
        private void signup(string id, string pass)
        {
            LoginDAO.Instance.sign(id, pass);
        }    
        private bool checkid (string id )
        {
            return LoginDAO.Instance.check(id); 
        }
        private void FormDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có thật sự muốn thoát chương trình?","Thông báo",MessageBoxButtons.OKCancel) !=System.Windows.Forms.DialogResult.OK)
            {
                // Không cho phép event này thực thi
                e.Cancel = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string textlogin = txtLogin.Text;
            string textpass = txtPass.Text;
            if (Login(textlogin,textpass) == true )
            {
                if (employee(textlogin) == "QL")
                {
                    FormManager f = new FormManager();
                    f.Textboxvalue = textlogin;
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                else if (employee(textlogin) == "NV")
                {
                    FormStaff f = new FormStaff();
                    f.Textboxvalue = textlogin;
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }          
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đúng tài khoản mật khẩu");
            }
        }
        private string employee(string id )
        {
            return id.Substring(0, 2);
        }
        private bool Login(string tlogin, string tpass)
        {
            return LoginDAO.Instance.login(tlogin,tpass); 
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            textBox8.MaxLength = 10;
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
            QuenMK quenMK = new QuenMK();
            this.Hide();
            quenMK.ShowDialog();
            this.Show();    
        }
    }
}


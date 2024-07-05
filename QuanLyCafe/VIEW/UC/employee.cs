using QuanLyCafe.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCafe.VIEW.UC
{
    public partial class employee : UserControl
    {
        public employee()
        {
            InitializeComponent();
            loadnv();
            dataGridView1.CellClick += DataGridView1_CellClick;
        }

        private void employee_Load(object sender, EventArgs e)
        {

        }

        private void loadnv ()
        {
            dataGridView1.DataSource = EmployeeDAO.Instance.listemployee();
        }
        private void xoabidingnv()
        {
            txtmnv.DataBindings.Clear();
            txtname.DataBindings.Clear();
            txtaddress.DataBindings.Clear();
            txtdate.DataBindings.Clear();
            txtphone.DataBindings.Clear();
            radioButton4.DataBindings.Clear();
            radioButton3.DataBindings.Clear();
        }
        private void bindingnv ()
        {
            if (txtmnv.DataBindings.Count == 0)
            {
                txtmnv.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "idEmployee", true, DataSourceUpdateMode.Never));
            }
            if (txtname.DataBindings.Count == 0)
            {
                txtname.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Ename", true, DataSourceUpdateMode.Never));
            }
            if (txtaddress.DataBindings.Count == 0)
            {
                txtaddress.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Email", true, DataSourceUpdateMode.Never));
            }
            if (txtdate.DataBindings.Count == 0)
            {
                txtdate.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "dateOfBirth", true, DataSourceUpdateMode.Never));
            }
            if (txtphone.DataBindings.Count == 0)
            {
                txtphone.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "phoneNumber", true, DataSourceUpdateMode.Never));
            }

            if (radioButton4.DataBindings.Count == 0)
            {
                Binding radioButton1Binding = new Binding("Checked", dataGridView1.DataSource, "gender", true, DataSourceUpdateMode.Never);
                radioButton1Binding.Format += (sender, e) => { e.Value = e.Value.ToString() == "Nam"; };
                radioButton4.DataBindings.Add(radioButton1Binding);
            }

            if (radioButton3.DataBindings.Count == 0)
            {
                Binding radioButton2Binding = new Binding("Checked", dataGridView1.DataSource, "gender", true, DataSourceUpdateMode.Never);
                radioButton2Binding.Format += (sender, e) => { e.Value = e.Value.ToString() == "Nữ"; };
                radioButton3.DataBindings.Add(radioButton2Binding);
            }
        }
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bindingnv();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void UpdateDataInBackground()
        {
            dataGridView1.DataSource = EmployeeDAO.Instance.listemployee();
            dataGridView1.Refresh();
        }
       


        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txtmnv.Text != "" && txtname.Text != "" && txtaddress.Text != "" && txtdate.Text != "" && txtphone.Text != "")
            {
                if (txtmnv.Text.Length > 2 && (txtmnv.Text.Substring(0, 2) == "NV" || txtmnv.Text.Substring(0, 2) == "QL"))
                {
                    if (EmployeeDAO.Instance.checkednv(txtmnv.Text) == true)
                    {
                        string sex;
                        if (radioButton3.Checked == true)
                        {
                            sex = radioButton3.Text;
                        }
                        else
                        {
                            sex = radioButton4.Text;
                        }
                        EmployeeDAO.Instance.updateeployee(txtmnv.Text, txtname.Text, txtaddress.Text, txtdate.Text, txtphone.Text, sex);
                        txtmnv.Clear();
                        txtname.Clear();
                        txtaddress.Clear();
                        txtdate.Clear();
                        txtphone.Clear();
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;

                        UpdateDataInBackground();
                        xoabidingnv();

                    }
                     else
                    {
                        string sex;
                        if (radioButton3.Checked == true)
                        {
                            sex = radioButton3.Text;
                        }
                        else
                        {
                            sex = radioButton4.Text;
                        }
                        EmployeeDAO.Instance.Addeployee(txtmnv.Text, txtname.Text, txtaddress.Text, txtdate.Text, txtphone.Text, sex);
                        txtmnv.Clear();
                        txtname.Clear();
                        txtaddress.Clear();
                        txtdate.Clear();
                        txtphone.Clear();
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;

                        UpdateDataInBackground();
                        xoabidingnv();
                    }
                    

                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đúng quy định mã nhân viên");
                }
            }
                    
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
                    
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            EmployeeDAO.Instance.deleteeployee(txtmnv.Text);
            txtmnv.Clear();
            txtname.Clear();
            txtaddress.Clear();
            txtdate.Clear();
            txtphone.Clear();
            radioButton3.Checked = false;
            radioButton4.Checked = false;

            UpdateDataInBackground();
            xoabidingnv();
        }
    }
}

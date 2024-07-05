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
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;

namespace QuanLyCafe.VIEW.UC
{
    public partial class Customer : UserControl
    {

        public Customer()
        {
            InitializeComponent();
            showlist();
            dtgCustomerList.CellClick += dtgCustomerList_CellContentClick;
        }

        private void dtgCustomerList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            biding();
        }
        private void xoabidingnv()
        {
            txtname.DataBindings.Clear();
            txtaddress.DataBindings.Clear();
            txtphone.DataBindings.Clear();
        }
        public void showlist ()
        {
            dtgCustomerList.DataSource = CustomerDAO.Instance.listcustomer();
        }
        private void biding()
        {
            if (txtname.DataBindings.Count == 0)
            {
                txtname.DataBindings.Add(new Binding("Text", dtgCustomerList.DataSource, "nameCustomer", true, DataSourceUpdateMode.Never));
            }
            if (txtphone.DataBindings.Count == 0)
            {
                txtphone.DataBindings.Add(new Binding("Text", dtgCustomerList.DataSource, "phoneNumber", true, DataSourceUpdateMode.Never));
            }
            if (txtaddress.DataBindings.Count == 0)
            {
                txtaddress.DataBindings.Add(new Binding("Text", dtgCustomerList.DataSource, "Caddress", true, DataSourceUpdateMode.Never));
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            string tmp = txtphone.Text;
            if (tmp != "")
            {
                dtgCustomerList.DataSource = CustomerDAO.Instance.FindC(tmp);
                xoabidingnv();
                biding();
            }
            else
            {
                dtgCustomerList.DataSource = CustomerDAO.Instance.listcustomer();
                txtname.Text = tmp;
                txtaddress.Text = tmp;
                txtphone.Text = tmp;
                xoabidingnv();
            } 
                
            
        }
        private void UpdateDataInBackground()
        {
            dtgCustomerList.DataSource = CustomerDAO.Instance.listcustomer();
            dtgCustomerList.Refresh();
        }

      


        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txtphone.Text != "" && txtname.Text != "" && txtaddress.Text != "")
            {
                if (CustomerDAO.Instance.checkedkh(txtphone.Text))
                {
                    CustomerDAO.Instance.updatecustomer(txtname.Text, txtphone.Text, txtaddress.Text);
                    UpdateDataInBackground();
                    xoabidingnv();
                }
                else
                {
                    int tmp = CustomerDAO.Instance.Addcustomer(txtname.Text, txtphone.Text, txtaddress.Text);
                    if (tmp > 0)
                    {
                        MessageBox.Show("Done");
                    }
                    else
                    {
                        MessageBox.Show("Bug");
                    }
                    UpdateDataInBackground();
                    xoabidingnv();

                }

            }
            else
            {
                MessageBox.Show("Bug");
                UpdateDataInBackground();
                xoabidingnv();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            CustomerDAO.Instance.delecustomer(txtphone.Text);
            txtname.Clear();
            txtaddress.Clear();
            txtphone.Clear();

            UpdateDataInBackground();
            xoabidingnv();
        }
    }
}

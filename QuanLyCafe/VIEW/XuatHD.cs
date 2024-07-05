using QuanLyCafe.DAO;
using QuanLyCafe.VIEW.UC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QuanLyCafe.VIEW
{
    public partial class XuatHD : Form
    {
        string ideployee;
        double total;
        public XuatHD(string ideployee, double total)
        {
            InitializeComponent();
            loadid();
            showlist();
            dtgCustomerList.CellClick += dtgCustomerList_CellContentClick;
            this.total = total;
            this.ideployee = ideployee;
            loaddate();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void txtidbill_TextChanged(object sender, EventArgs e)
        {
            
        }
        public void loadid ()
        {
            DataTable dt = HDDAO.Instance.maxbill();
            int tmp = int.Parse(dt.Rows[0][0].ToString());     
            tmp += 1; 
            txtidbill.Text = tmp.ToString();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtgCustomerList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            biding();
        }
        private void xoabidingnv()
        {
            txtphonenumber.DataBindings.Clear();
        }
        private void biding()
        {
            if (txtphonenumber.DataBindings.Count == 0)
            {
                txtphonenumber.DataBindings.Add(new Binding("Text", dtgCustomerList.DataSource, "phoneNumber", true, DataSourceUpdateMode.Never));
            }  
        }
        public void showlist()
        {
            dtgCustomerList.DataSource = CustomerDAO.Instance.listcustomer();
        }
        

        private void btnfind_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                showlist();
                txtphonenumber.Clear();
                xoabidingnv(); 
            }
            else
            {
                string tmp = textBox1.Text;
                dtgCustomerList.DataSource = CustomerDAO.Instance.FindC(tmp);
                xoabidingnv();
                biding();
            }
        }

        private void txtideployee_TextChanged(object sender, EventArgs e)
        {

        }
        public void loaddate()
        {
            txtdate.Text = DateTime.Now.ToString("yyyy-MM-dd");
            txtideployee.Text = ideployee;
            txtprice.Text = total.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void XuatHD_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtprice.Text == "0" || txtphonenumber.Text == "")
            {
                MessageBox.Show("Không thể xuất hóa đơn");
            }
            else
            {
                if (!(CustomerDAO.Instance.checkedkh(txtphonenumber.Text)))
                {
                    CustomerDAO.Instance.ADD(txtphonenumber.Text);
                }
                HDDAO.Instance.addHD(txtidbill.Text, txtideployee.Text, txtdate.Text, txtphonenumber.Text, txtprice.Text);
                MessageBox.Show("Xuất hóa đơn thành công");
            }
        }
        private void txtdate_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

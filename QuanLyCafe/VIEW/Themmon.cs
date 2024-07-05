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

namespace QuanLyCafe.VIEW
{
    public partial class Themmon : Form
    {
        string id;
        string name;
        string price;
        string sl; 

        public Themmon(string id, string name ,string price ,string sl)
        {
            InitializeComponent();
            this.id = id;
            this.name = name;
            this.price = price;
            this.sl = sl;
            load();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void load ()
        {
            txtid.Text = this.id;
            txtname.Text = this.name;
            txtprice.Text = this.price;
        }
        private void Themmon_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            bool tmp = true; 
            foreach (char c in txtsl.Text)
            {
                if (!char.IsDigit(c))
                {
                    tmp = false;
                }
            }
            if (txtsl.Text == "0" || tmp == false || txtsl.Text == "" )
            {
                MessageBox.Show("Không thể nhập hóa đơn");
            }
            else
            {
                WarehouseDAO.Instance.update(id, int.Parse(txtsl.Text));
                MessageBox.Show("nhập hóa đơn thành công");
                this.Close();
            }

        }

        private void txtsl_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

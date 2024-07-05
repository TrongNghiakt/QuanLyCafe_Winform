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
using System.Xml.Linq;

namespace QuanLyCafe.VIEW.UC
{
    public partial class Bill : UserControl
    {
        public Bill()
        {
            InitializeComponent();
            loadlist();
            dataGridView1.CellClick += DataGridView1_CellClick;

        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            biding();
        }

        private void groupBoxHoaDon_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void loadlist ()
        {
            dataGridView1.DataSource = HDDAO.Instance.showlist();
        }
        private void biding ()
        {
            if (txtidbill.DataBindings.Count == 0)
            {
                txtidbill.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "idBill", true, DataSourceUpdateMode.Never));
            }
            if (txtide.DataBindings.Count == 0)
            {
                txtide.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "idEmployee", true, DataSourceUpdateMode.Never));
            }
            if (txtdate.DataBindings.Count == 0)
            {
                txtdate.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "dateCheck", true, DataSourceUpdateMode.Never));
            }
            if (txtsdt.DataBindings.Count == 0)
            {
                txtsdt.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "phoneNumber", true, DataSourceUpdateMode.Never));
            }
            if (txtaddress.DataBindings.Count == 0)
            {
                txtaddress.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Caddress", true, DataSourceUpdateMode.Never));
            }
            if (txtcustomer.DataBindings.Count == 0)
            {
                txtcustomer.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "nameCustomer", true, DataSourceUpdateMode.Never));
            }
            if (txtprice.DataBindings.Count == 0)
            {
                txtprice.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "price", true, DataSourceUpdateMode.Never));
            }
        }

        private void Bill_Load(object sender, EventArgs e)
        {

        }

        private void txtprice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtidbill_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtide_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

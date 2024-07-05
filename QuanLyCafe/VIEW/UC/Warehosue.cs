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
    public partial class Warehosue : UserControl
    {
        public Warehosue()
        {
            InitializeComponent();
            
            dataGridView1.CellClick += dataGridView1_CellContentClick;
            load();
            biding();
        }

        public void load ()
        {
            dataGridView1.DataSource = WarehouseDAO.Instance.listware();           
        }

        private void groupBoxNhapKho_Enter(object sender, EventArgs e)
        {

        }
        private void xoabidingnv()
        {
            label1.DataBindings.Clear();
            label2.DataBindings.Clear();
            label3.DataBindings.Clear();
            label4.DataBindings.Clear();
        }
        private void biding()
        {
            if (label1.DataBindings.Count == 0)
            {
                label1.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "idIngredient", true, DataSourceUpdateMode.Never));
            }
            if (label2.DataBindings.Count == 0)
            {
                label2.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Iname", true, DataSourceUpdateMode.Never));
            }
            if (label3.DataBindings.Count == 0)
            {
                label3.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "price", true, DataSourceUpdateMode.Never));
            }
            if (label4.DataBindings.Count == 0)
            {
                label4.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "number", true, DataSourceUpdateMode.Never));
            }
        }
        private void pictureBox37_Click(object sender, EventArgs e)
        {
            Themmon themmon = new Themmon(label1.Text,label2.Text,label3.Text,label4.Text);
            themmon.ShowDialog();
            UpdateDataInBackground();
            xoabidingnv();
            
        }
        private void UpdateDataInBackground()
        {
            dataGridView1.DataSource = WarehouseDAO.Instance.listware();
            dataGridView1.Refresh();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            biding();
        }
    }
}

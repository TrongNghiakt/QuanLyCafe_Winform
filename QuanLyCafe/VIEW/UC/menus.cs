using Guna.UI2.WinForms;
using QuanLyCafe.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QuanLyCafe.VIEW.UC
{
    public partial class menus : UserControl
    {
        string ideployee;
        private int _id;
        public menus(string ideployee)
        {
            InitializeComponent();
            list();
            this.ideployee = ideployee;
            dataGridView2.CellClick += dataGridView2_CellContentClick;

        }

        private void button22_Click(object sender, EventArgs e)
        {
            double total = CalculateTotal();
            XuatHD hd = new XuatHD(ideployee, total);
            hd.Show();
            dataGridView2.Rows.Clear();
        }
        private double CalculateTotal()
        {
            double total = 0;
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (!row.IsNewRow)
                {
                    double value;
                    if (double.TryParse(row.Cells[2].Value.ToString(), out value))
                    {
                        total += value;
                    }
                }
            }
            return total;
        }
        private void AddUc(UserControl uc)
        {
            uc.Dock = DockStyle.Top;
            flowLayoutPanel1.Controls.Add(uc);
            uc.BringToFront();
        }

        private void list()
        {
            MenuDAO menu = new MenuDAO();
            DataTable dt = menu.menus();
            foreach (DataRow row in dt.Rows)
            {
                string id = row["idMenu"].ToString();
                string tenMonAn = row["nameMenu"].ToString();
                string moTa = row["price"].ToString();
                byte[] imageData = (byte[])row["img"];
                Image image;
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    image = Image.FromStream(ms);
                }
                UserControl uc = TaoUserControlMenu(tenMonAn, moTa, image, id);
                AddUc(uc);
            }
        }

        private UserControl TaoUserControlMenu(string tenMonAn, string moTa, Image image, string id)
        {
            drink uc = new drink();
            uc.UpdateDrink += f_updateDrink;
            uc.UpdateDrink2 += f_updateDrinkAdd;
            uc.edit(tenMonAn, moTa, image, id);
            return uc;
        }
        public void f_updateDrink(object sender, DrinkEvent e)
        {
            this.txtname.Text = e.Text;
            this.txtsl.Text = "1";
            this.txtprice.Text = e.Price;
            this.label4.Text = e.Id;
        }
        public void f_updateDrinkAdd(object sender, DrinkEvent e)
        {
            string id = e.Id;
            string name = e.Text;
            string sl = "1";
            string price = e.Price;
            if (Checklist(name) == 0)
            {
                if (int.Parse(price) > 0)
                {
                    int tmp = int.Parse(price) * int.Parse(sl);
                    price = tmp.ToString();
                    AddRowToDataGridView(name, price, sl, id);
                }
                else
                {
                    MessageBox.Show("Lỗi");
                }
            }
            else if (Checklist(name) == 1)
            {
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == name)
                    {
                        row.Cells[1].Value = (int.Parse(sl) + int.Parse(row.Cells[1].Value.ToString())).ToString();
                        row.Cells[2].Value = (int.Parse(price) * int.Parse(row.Cells[1].Value.ToString())).ToString();
                    }
                }
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string id = label4.Text;
            string name = txtname.Text;
            string sl = txtsl.Text;
            string price = txtprice.Text;
            if (txtname.Text == "" || txtsl.Text == "" || txtprice.Text == "")
            {
                MessageBox.Show("Lỗi");
            }
            else
            {
                if (Checklist(name) == 0)

                {
                    if (int.Parse(price) > 0)
                    {
                        int tmp = int.Parse(price) * int.Parse(sl);
                        price = tmp.ToString();
                        AddRowToDataGridView(name, price, sl, id);
                    }
                    else
                    {
                        MessageBox.Show("Lỗi");
                    }
                }
                else if (Checklist(name) == 1)
                {
                    foreach (DataGridViewRow row in dataGridView2.Rows)
                    {
                        if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == name)
                        {
                            row.Cells[1].Value = (int.Parse(sl) + int.Parse(row.Cells[1].Value.ToString())).ToString();
                            row.Cells[2].Value = (int.Parse(price) * int.Parse(row.Cells[1].Value.ToString())).ToString();
                        }
                    }
                }
            }

        }
        public int Checklist(string name)
        {
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == name)
                {
                    return 1;
                }
            }
            return 0;
        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dt = dataGridView2.Rows[e.RowIndex];
                _id = e.RowIndex;
            }
       
        }
        private void AddRowToDataGridView(string name, string price, string sl, string id)
        {
            DataGridViewRow row = new DataGridViewRow();

            DataGridViewTextBoxCell cellName = new DataGridViewTextBoxCell();
            cellName.Value = name;

            DataGridViewTextBoxCell cellSl = new DataGridViewTextBoxCell();
            cellSl.Value = sl;

            DataGridViewTextBoxCell cellPrice = new DataGridViewTextBoxCell();
            cellPrice.Value = price;

            DataGridViewTextBoxCell cellId = new DataGridViewTextBoxCell();
            cellId.Value = id;

            row.Cells.Add(cellName);
            row.Cells.Add(cellSl);
            row.Cells.Add(cellPrice);
            row.Cells.Add(cellId);

            dataGridView2.Rows.Add(row);
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void menus_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                if (_id != -1)
                {
                    dataGridView2.Rows.RemoveAt(_id);
                    _id = -1;
                }
            } 
            catch
            {
                MessageBox.Show("Không còn sản phầm nào để xóa!!!!");
            }


        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }


    }
}

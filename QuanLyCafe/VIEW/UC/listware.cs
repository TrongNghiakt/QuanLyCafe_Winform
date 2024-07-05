using QuanLyCafe.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCafe.VIEW.UC
{
    public partial class listware : UserControl
    {
        public listware()
        {
            InitializeComponent();
            load();
        }
        private void AddUc(UserControl uc)
        {
            uc.Dock = DockStyle.Top;
            flowLayoutPanel1.Controls.Add(uc);
            uc.BringToFront();
        }
        public void load ()
        {
            WarehouseDAO itemware = new WarehouseDAO();
            DataTable dt = itemware.listware();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow row = dt.Rows[i];

                string id = row["idIngredient"].ToString();
                string tenMonAn = row["Iname"].ToString();
                string moTa = row["price"].ToString();
                string soluong = row["number"].ToString();
                byte[] imageData = (byte[])row["img"];
                Image image;
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    image = Image.FromStream(ms);
                }
                UserControl uc = TaoUserControlMenu(tenMonAn, moTa, image, id, soluong);
                AddUc(uc);
            }
        }
        private UserControl TaoUserControlMenu(string tenMonAn, string moTa, Image image, string id, string soluong)
        {
            itemware uc = new itemware();
            uc.edit(tenMonAn, moTa, image, id, soluong);
            return uc;
        }
        private void listware_Load(object sender, EventArgs e)
        {

        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox37_Click(object sender, EventArgs e)
        {
            if (txtfind.Text == "")
            {
                flowLayoutPanel1.Controls.Clear();
                load();
            }
            else
            {
                WarehouseDAO warehouseDAO = new WarehouseDAO();               
                DataTable dt = WarehouseDAO.Instance.finditem(txtfind.Text);
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    string id = row["idIngredient"].ToString();
                    string tenMonAn = row["Iname"].ToString();
                    string moTa = row["price"].ToString();
                    string soluong = row["number"].ToString();
                    byte[] imageData = (byte[])row["img"];
                    Image image;
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                    image = Image.FromStream(ms);
                    }
                flowLayoutPanel1.Controls.Clear();
                UserControl uc = TaoUserControlMenu(tenMonAn, moTa, image, id, soluong);
                AddUc(uc);

                }
                else
                {
                    MessageBox.Show("Không tìm thấy");
                } 
                    
                
            }
            
        }
    }
}

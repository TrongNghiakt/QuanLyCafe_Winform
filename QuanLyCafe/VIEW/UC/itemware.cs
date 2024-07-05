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
    public partial class itemware : UserControl
    {
        public itemware()
        {
            InitializeComponent();
        }
        public void edit(string name, string price, Image image, string id, string soluong)
        {
            this.lbname.Text = "Tên món:" + name;
            this.lbprice.Text = "Giá tiền:" + price;
            this.picware.Image = image;
            this.lbid.Text = "Id:" + id;
            this.lbsl.Text = "Số lượng:" + soluong;
        }

        private void picware_Click(object sender, EventArgs e)
        {

        }

        private void itemware_Load(object sender, EventArgs e)
        {

        }

        private void lbsl_Click(object sender, EventArgs e)
        {

        }

        private void lbprice_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

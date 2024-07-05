using QuanLyCafe.VIEW.UC;
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
    public partial class Updateinform : Form
    {
        public string id;
        public Updateinform(string id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void AddUc(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            panel_inform.Controls.Clear();
            panel_inform.Controls.Add(uc);
            uc.BringToFront();
        }
        private void panel_inform_Paint(object sender, PaintEventArgs e)
        {
            
        }
        public void checkpanel1 ()
        {
               viewinform tmp = new viewinform(id);
               AddUc(tmp);
        }
        public void checkpanel2()
        {
            changepass quenMatKhau = new changepass(id);
            AddUc(quenMatKhau);
        }
        public void checkpanel4()
        {
            update view = new update(id);
            AddUc(view);
        }
        private void Updateinform_Load(object sender, EventArgs e)
        {

        }
    }
}

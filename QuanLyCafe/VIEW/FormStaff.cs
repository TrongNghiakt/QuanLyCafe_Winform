using QuanLyCafe.VIEW;
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
using static QuanLyCafe.VIEW.UC.menus;

namespace QuanLyCafe
{
    public partial class FormStaff : Form
    {
        public string Textboxvalue { get; set; }

        public FormStaff()
        {
            InitializeComponent();
            Home home = new Home();
            AddUc(home);
            panelmenusubitem.Visible = false;
            CustomizeDesign();

        }
        private void AddUc(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            panel_mn.Controls.Clear();
            panel_mn.Controls.Add(uc);
            uc.BringToFront();
        }

        private void menupanelaccess_Paint(object sender, PaintEventArgs e)
        {

        }
        private void formstaff_Button22ClickEvent(object sender, EventArgs e)
        {
            this.menupanelaccess.Location = new Point(guna2Button6.Location.X, guna2Button6.Location.Y);
            Customer customer = new Customer();
            AddUc(customer);
            if (panelmenusubitem.Visible == true)
            {
                panelmenusubitem.Visible = false;
            }
            this.guna2Button6.Checked = true;

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (panelmenusubitem.Visible == false)
            {
                panelmenusubitem.Visible = true;
                panelmenusubitem.BringToFront();

            }
            else
            {
                panelmenusubitem.Visible = false;
            }
        }

        private void btninfor_Click(object sender, EventArgs e)
        {
            Updateinform update = new Updateinform(Textboxvalue);
            this.Hide();
            update.checkpanel1();
            update.ShowDialog();
            panelmenusubitem.Visible = false;
            this.Show();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            this.Close ();
        }

        private void btnforgotpass_Click(object sender, EventArgs e)
        {
            Updateinform update = new Updateinform(Textboxvalue);
            this.Hide();
            update.checkpanel2();
            update.ShowDialog();
            panelmenusubitem.Visible = false;
            this.Show();
        }
        private void CustomizeDesign()
        {
            panelware.Visible = false;
        }
        private void hideware()
        {
            if (panelware.Visible == true)
            {
                panelware.Visible = false;
            }
        }
        private void showware(Panel subware)
        {
            if (subware.Visible == false)
            {
                hideware();
                subware.Visible = true;
            }
            else
            {
                subware.Visible = false;
            }
        }
        private void panel_mn_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            this.menupanelaccess.Location = new Point(guna2Button1.Location.X, guna2Button1.Location.Y);
            Home home = new Home();
            AddUc(home);
            if (panelmenusubitem.Visible == true)
            {
                panelmenusubitem.Visible = false;
            }
            hideware();
        }

        private void btnmenu_Click_1(object sender, EventArgs e)
        {
            this.menupanelaccess.Location = new Point(btnmenu.Location.X, btnmenu.Location.Y);
            menus menus = new menus(Textboxvalue);
            AddUc(menus);
            if (panelmenusubitem.Visible == true)
            {
                panelmenusubitem.Visible = false;
            }
            hideware();
        }

        private void btnbill_Click_1(object sender, EventArgs e)
        {
            this.menupanelaccess.Location = new Point(btnbill.Location.X, btnbill.Location.Y);
            Bill bill = new Bill();
            AddUc(bill);
            if (panelmenusubitem.Visible == true)
            {
                panelmenusubitem.Visible = false;
            }
            hideware();

        }

        private void guna2Button6_Click_1(object sender, EventArgs e)
        {
            this.menupanelaccess.Location = new Point(guna2Button6.Location.X, guna2Button6.Location.Y);
            Customer customer = new Customer();
            AddUc(customer);
            if (panelmenusubitem.Visible == true)
            {
                panelmenusubitem.Visible = false;
            }
            hideware();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            showware(panelware);
            this.menupanelaccess.Location = new Point(guna2Button2.Location.X, guna2Button2.Location.Y);

            if (panelmenusubitem.Visible == true)
            {
                panelmenusubitem.Visible = false;
            }

        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            listware listware = new listware();
            AddUc(listware);
            hideware();

        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            Warehosue warehosue = new Warehosue();
            AddUc(warehosue);
            hideware();

        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            hideware();

        }
    }
}

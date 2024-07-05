using QuanLyCafe.VIEW;
using QuanLyCafe.VIEW.UC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;
using static QuanLyCafe.VIEW.UC.menus;
using UserControl = System.Windows.Forms.UserControl;

namespace QuanLyCafe
{
    public partial class FormManager : Form
    {
        public string Textboxvalue { get; set; }

        public FormManager()
        {
 
            InitializeComponent();
            CustomizeDesign(); 
            Home home = new Home();
            AddUc(home);
            panelmenusubitem.Visible = false;

        }
        private void CustomizeDesign ()
        {
            panelware.Visible = false; 
        }
        private void hideware ()
        {
            if (panelware.Visible == true ) {
                panelware.Visible=false;
            }
        }
        private void showware (Panel subware)
        {
            if (subware.Visible == false  )
            {
                hideware();
                subware.Visible=true;
            }
            else
            {
                subware.Visible=false;
            }
        }

        public void AddUc(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            panel_mn.Controls.Clear();
            panel_mn.Controls.Add(uc);
            uc.BringToFront();
        }

        private void btnmenu_Click(object sender, EventArgs e)
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

        private void btnbill_Click(object sender, EventArgs e)
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

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.menupanelaccess.Location = new Point(guna2Button2.Location.X, guna2Button2.Location.Y);
            showware(panelware);
            if (panelmenusubitem.Visible == true)
            {
                panelmenusubitem.Visible = false;
            }

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.menupanelaccess.Location = new Point(guna2Button4.Location.X, guna2Button4.Location.Y);
            profit profit = new profit();
            AddUc(profit);
            if (panelmenusubitem.Visible == true)
            {
                panelmenusubitem.Visible = false;
            }
            hideware();

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            this.menupanelaccess.Location = new Point(guna2Button5.Location.X, guna2Button5.Location.Y);
            employee employee = new employee();
            AddUc(employee);
            if (panelmenusubitem.Visible == true)
            {
                panelmenusubitem.Visible = false;
            }
            hideware();

        }
        public void guna2Button6_Click(object sender, EventArgs e)
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


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {


        }

        private void panel_mn_Paint(object sender, PaintEventArgs e)
        {

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


        private void panelmenusubitem_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btninfor_Click(object sender, EventArgs e)
        {
            Updateinform update = new Updateinform(Textboxvalue);
            this.Hide();
            update.checkpanel4();
            update.ShowDialog();
            panelmenusubitem.Visible = false; 
            this.Show();

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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

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



        private void panelware_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

    
    }
}

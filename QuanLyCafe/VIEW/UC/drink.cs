using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QuanLyCafe.VIEW.UC
{
    public partial class drink : UserControl
    {
        public drink()
        {
            InitializeComponent();
        }

        private event EventHandler<DrinkEvent> updateDrink;
        public event EventHandler<DrinkEvent> UpdateDrink
        {
            add { updateDrink += value; }
            remove { updateDrink -= value; }
        }
        private event EventHandler<DrinkEvent> updateDrink2;
        public event EventHandler<DrinkEvent> UpdateDrink2
        {
            add { updateDrink2 += value; }
            remove { updateDrink2 -= value; }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            updateDrink(this, new DrinkEvent(this.label1.Text, this.label2.Text,this.label3.Text));
        }

        public void edit (string name, string price, Image image, string id)
        {
            this.label1.Text = name;
            this.label2.Text = price;
            this.pictureBox1.Image = image;
            this.label3.Text = id;
        }

        private void pictureBox1DB_Click(object sender, EventArgs e)
        {
            updateDrink2(this, new DrinkEvent(this.label1.Text, this.label2.Text, this.label3.Text));
        }

        private void drink_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
    public class DrinkEvent : EventArgs
    {
        private string id;
        private string text;
        private string price;

        public string Text { get => text; set => text = value; }
        public string Price { get => price; set => price = value; }
        public string Id { get => id; set => id = value; }


        public DrinkEvent(string text, string price , string id)
        {
            this.Text = text;
            this.Price = price;
            this.Id = id;
        }
    }
}

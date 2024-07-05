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
    public partial class update : UserControl
    {
        string id;
        public update(string id )
        {
            InitializeComponent();
            this.id = id;
            load();
        }

        private void update_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string gender;
            if (radioButton3.Checked == true)
            {
                gender = "Nữ";
            }
            else  
            {
                gender = "Nam";

            }
            EmployeeDAO.Instance.updateeployee(id,textBox5.Text,textBox3.Text,textBox6.Text,textBox4.Text ,gender );
            load();
        }
        public void load ()
        {
            textBox1.Text = id;
            DataTable dt = EmployeeDAO.Instance.findeeploy(id); 
            textBox5.Text = dt.Rows[0][1].ToString();
            textBox6.Text = dt.Rows[0][2].ToString();
            if (dt.Rows[0][3].ToString() == "Nữ")
            {
                radioButton3.Checked = true;
            }    
            else
            {
                radioButton4.Checked = true;
            }
            textBox3.Text = dt.Rows[0][4].ToString();
            textBox4.Text = dt.Rows[0][5].ToString();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

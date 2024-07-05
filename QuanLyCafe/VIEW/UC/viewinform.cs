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
    public partial class viewinform : UserControl
    {
        public string id;
        public viewinform(string id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void viewinform_Load(object sender, EventArgs e)
        {
            DataTable dt = EmployeeDAO.Instance.findeeploy(id);
            textBox1.Text = dt.Rows[0]["idEmployee"].ToString();
            textBox5.Text = dt.Rows[0]["Ename"].ToString();
            textBox6.Text = dt.Rows[0]["dateOfBirth"].ToString();
            string tmp = dt.Rows[0]["gender"].ToString();
            if (tmp == "Nữ") 
            { 
                radioButton3.Checked = true;
            }else
            {
                radioButton4.Checked = true;

            }
            textBox3.Text = dt.Rows[0]["Email"].ToString();
            textBox4.Text = dt.Rows[0]["phoneNumber"].ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

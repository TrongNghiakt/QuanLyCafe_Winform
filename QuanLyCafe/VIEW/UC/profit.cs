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
    public partial class profit : UserControl
    {
        public profit()
        {
            InitializeComponent();
        }


        private void textBox66_TextChanged(object sender, EventArgs e)
        {

        }
        void clearlist ()
        {
            txt1.Clear();
            txt2.Clear();
            txt3.Clear();
            txt4.Clear();
            txt5.Clear();
            txt6.Clear();
            txt7.Clear();
            txt8.Clear();
            txt9.Clear();
            txt10.Clear();
            txt11.Clear();
            txt12.Clear();

        }
        private void pictureBox37_Click(object sender, EventArgs e)
        {
            
            string tmp = textBox66.Text;
            clearlist();
            bool tmpcheck = true;
            foreach (char c in textBox66.Text)
            {
                if (!char.IsDigit(c))
                {
                    tmpcheck = false;
                }
            }
            if (tmp == "" || tmpcheck == false)
            {
                MessageBox.Show("Không tìm thấy");
            }
            else
            {
                DataTable dt = HDDAO.Instance.listprofit(tmp);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        DataRow row = dt.Rows[i];
                        string id = row["Month"].ToString();
                        if (id == "1")
                        {
                            txt1.Text = row["TotalAmount"].ToString();
                        }
                        if (id == "2")
                        {
                            txt2.Text = row["TotalAmount"].ToString();
                        }
                        if (id == "3")
                        {
                            txt3.Text = row["TotalAmount"].ToString();
                        }
                        if (id == "4")
                        {
                            txt4.Text = row["TotalAmount"].ToString();
                        }
                        if (id == "5")
                        {
                            txt5.Text = row["TotalAmount"].ToString();
                        }
                        if (id == "6")
                        {
                            txt6.Text = row["TotalAmount"].ToString();
                        }
                        if (id == "7")
                        {
                            txt7.Text = row["TotalAmount"].ToString();
                        }
                        if (id == "8")
                        {
                            txt8.Text = row["TotalAmount"].ToString();
                        }
                        if (id == "9")
                        {
                            txt9.Text = row["TotalAmount"].ToString();
                        }
                        if (id == "10")
                        {
                            txt10.Text = row["TotalAmount"].ToString();
                        }
                        if (id == "11")
                        {
                            txt11.Text = row["TotalAmount"].ToString();
                        }
                        if (id == "12")
                        {
                            txt12.Text = row["TotalAmount"].ToString();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy");
                } 
                    
                    
            }
            
        }

    }
}

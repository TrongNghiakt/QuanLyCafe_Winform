
using QuanLyCafe.VIEW.UC;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QuanLyCafe.DAO
{
    internal class LoginDAO
    {
        private static LoginDAO instance;
        public static LoginDAO Instance
        {
            get { if (instance == null) instance = new LoginDAO(); return instance; }
            private set { instance = value; }
        }
        public bool login (string username, string password)
        {
            string query = "select * from Account where idAccount =N'" + username + "' and ApassWord =N'" + password +"'";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }
        public int inforemployee(string id , string name ,string date, string gender ,string address, string phonen)
        {
            string query = $"INSERT INTO Employee (idEmployee, Ename, dateOfBirth, gender, Email, phoneNumber) VALUES ('{id}', N'{name}', '{date}', N'{gender}', N'{address}', '{phonen}')";

            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result;
        }
        public int sign(string id, string pass)
        {
            string query = $"INSERT INTO Account (idAccount,ApassWord) VALUES ('{id}', '{pass}')";

            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result;
        }
        public bool check(string id)
        {
            string query = "select * from Account where idAccount =N'" + id + "'";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            return result.Rows.Count > 0;
        }
        public bool quenmk(string id,string email)
        {
            string query = "select * from Employee where idEmployee =N'" + id + "' and Email = N'" +email+ "'";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            return result.Rows.Count > 0;
        }
        public void update(string id , string mk)
        {
            string query = "UPDATE Account SET ApassWord = N'" + mk + "' WHERE idAccount = '" + id + "'";
            DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}


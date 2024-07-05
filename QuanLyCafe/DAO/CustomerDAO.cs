using QuanLyCafe.VIEW.UC;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.DAO
{
    internal class CustomerDAO
    {
        private static CustomerDAO instance;
        public static CustomerDAO Instance
        {
            get { if (instance == null) instance = new CustomerDAO(); return instance; }
            private set { instance = value; }
        }
        public CustomerDAO() { }
        public DataTable listcustomer()
        {
            string query = "select * from Customer";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public DataTable FindC (string id )
        {
            string query = "select * from Customer where phoneNumber = N'" + id  +"'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public int Addcustomer (string name, string phone, string address)
        {
            string query = $"INSERT INTO Customer (nameCustomer, Caddress, phoneNumber) VALUES ( N'{name}', N'{address}', '{phone}')";

            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result;
        }
        public void updatecustomer(string name, string phone, string address)
        {
            string query = "UPDATE Customer SET Caddress = N'" + address + "', nameCustomer = N'" + name + "' where phoneNumber = '" + phone + "'";
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public bool checkedkh(string id)
        {
            string query = "select * from Customer where phoneNumber = '"+ id +"'";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }
        public void delecustomer (string id)
        {
            string query = "EXEC delecustomers @idphone = '" + id + "'";
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public void ADD (string id)
        {
            string query2 = $"INSERT INTO Customer (phoneNumber) VALUES ('{id}')";
            DataProvider.Instance.ExecuteNonQuery(query2);
        }

    }
}

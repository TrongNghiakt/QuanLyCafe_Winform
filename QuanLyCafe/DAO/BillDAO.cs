using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.DAO
{
    internal class BillDAO
    {
        private static BillDAO instance;
        public static BillDAO Instance
        {
            get { if (instance == null) instance = new BillDAO(); return instance; }
            private set { instance = value; }
        }
        public DataTable showlist ()
        {
            string query = "select idBill,idEmployee,dateCheck,Bill.phoneNumber,price,Caddress,nameCustomer from Bill,Customer where Customer.phoneNumber = Bill.phoneNumber";
            DataTable dt = DataProvider.Instance.ExecuteQuery (query);
            return dt;
        }
        public DataTable maxbill()
        {
            string query = "SELECT MAX(idBill) FROM Bill;";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public void addHD(string idbill, string idemployee, string date, string phone, string price)
        {
            string query = $"INSERT INTO Bill (idbill, idEmployee, dateCheck, phoneNumber, price) VALUES ('{idbill}', '{idemployee}', '{date}', '{phone}', '{price}')";
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public DataTable listprofit(string year)
        {
            string query = "SELECT YEAR(dateCheck) AS Year,MONTH(dateCheck) AS Month, SUM(price) AS TotalAmount FROM bill where YEAR(dateCheck) = '"+year+"' GROUP BY YEAR(dateCheck),MONTH(dateCheck)";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }

    }
}

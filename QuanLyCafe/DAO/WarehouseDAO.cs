using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.DAO
{
    internal class WarehouseDAO
    {
        private static WarehouseDAO instance;
        public static WarehouseDAO Instance
        {
            get { if (instance == null) instance = new WarehouseDAO(); return instance; }
            private set { instance = value; }
        }
        public DataTable listware()
        {
            string query = "select idIngredient, Iname,price,number, img from Ingredient";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result;
        }
        public DataTable finditem(string id )
        {
            string query = "select idIngredient, Iname,price,number, img from Ingredient where idIngredient ='"+id+ "'";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result;
        }
        public void update(string id, int sl)
        {
            string query = $"UPDATE Ingredient SET number = number +"+sl+ " WHERE idIngredient = '"+ id +"'";
            DataProvider.Instance.ExecuteQuery(query);
        }
    }
}

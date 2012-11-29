using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    class Customers
    {
        public static DataTable GetAllUser()
        {
            DataBase db = new DataBase();
            return db.GetDataTable("Select * from Customer");
        }
        public static void Save()
        {
            DataBase db = new DataBase();
            string sql = "insert ";
        }
    }
}

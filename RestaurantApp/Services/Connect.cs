using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp.Services
{
    class Connect
    {
        public SqlConnection con = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        public string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\PROJEKTY\RestaurantApp\RestaurantApp\App_data\UsersDB.mdf';Integrated Security=True;Connect Timeout=30";
    }
}

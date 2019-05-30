using System;
using MySql.Data.MySqlClient;

namespace projectdatabse
{
    class myConnection
    {
        public MySqlConnection GetConnection()
        {
            string str = "Server=localhost;Port=3306;Database=acopak;Uid=root;password='root'";
 
            MySqlConnection con = new MySqlConnection(str);
            con.Open();
            return con;
        }
    }
    }



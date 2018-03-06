using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;



public class DbConnect
{
    public MySqlConnection sqlConnection;
    public DbConnect()
    {
        //
        //TODO: 在此处添加构造函数逻辑
        //
        string s = "server = localhost; userid = root; password =; database = bookstore";
        sqlConnection = new MySqlConnection(s);
    }
}

